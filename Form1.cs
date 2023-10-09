using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LogIn login = new LogIn(this);
            this.Hide();
            login.ShowDialog();
            login.Focus();
        }

        public void logged_in()
        {
            MessageBox.Show("Login Berhasil!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = true;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // koneksi ke database
            string myConnectionString = "server=localhost;uid=root;pwd=root;database=spp_app";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            // ambil data petugas
            string data_petugas = "SELECT * FROM data_user";
            MySqlCommand cmd = new MySqlCommand(data_petugas, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            label7.Text = dt.Rows.Count.ToString();

            // ambil data siswa
            string data_siswa = "SELECT * FROM data_siswa";
            MySqlCommand cmd2 = new MySqlCommand(data_siswa, conn);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            label6.Text = dt2.Rows.Count.ToString();

            // tampilkan daftar siswa
            dataGridView1.DataSource = dt2;

            // tutup database
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // koneksi ke database
            string myConnectionString = "server=localhost;uid=root;pwd=root;database=spp_app";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            // ambil data petugas
            string data_petugas = "SELECT * FROM data_user";
            MySqlCommand cmd = new MySqlCommand(data_petugas, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            label7.Text = dt.Rows.Count.ToString();
            
            // ambil data siswa
            string data_siswa = "SELECT * FROM data_siswa";
            MySqlCommand cmd2 = new MySqlCommand(data_siswa, conn);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            label6.Text = dt2.Rows.Count.ToString();

            // tampilkan daftar siswa
            dataGridView1.DataSource = dt2;

            // tutup database
            conn.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}