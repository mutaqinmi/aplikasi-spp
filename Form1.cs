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
            string myConnectionString = "server=localhost;uid=root;pwd=root;database=spp_app";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string data_petugas = "SELECT * FROM data_user";
            string data_siswa = "SELECT * FROM data_siswa";
            MySqlCommand cmd = new MySqlCommand(data_petugas, conn);
            MySqlCommand cmd2 = new MySqlCommand(data_siswa, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            adapter.Fill(dt);
            adapter2.Fill(dt2);
            label7.Text = dt.Rows.Count.ToString();
            label6.Text = dt2.Rows.Count.ToString();
            dataGridView1.DataSource = dt2;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string myConnectionString = "server=localhost;uid=root;pwd=root;database=spp_app";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string data_petugas = "SELECT * FROM data_user";
            string data_siswa = "SELECT * FROM data_siswa";
            MySqlCommand cmd = new MySqlCommand(data_petugas, conn);
            MySqlCommand cmd2 = new MySqlCommand(data_siswa, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            adapter.Fill(dt);
            adapter2.Fill(dt2);
            label7.Text = dt.Rows.Count.ToString();
            label6.Text = dt2.Rows.Count.ToString();
            dataGridView1.DataSource = dt2;
            conn.Close();
        }
    }
}