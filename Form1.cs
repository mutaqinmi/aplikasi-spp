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

        public void logged_in(string username)
        {
            MessageBox.Show("Login Berhasil!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = true;
            label5.Text = username;
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
            MySqlCommand cmd_petugas = new MySqlCommand(data_petugas, conn);
            MySqlDataAdapter adapter_petugas = new MySqlDataAdapter(cmd_petugas);
            DataTable dt_petugas = new DataTable();
            adapter_petugas.Fill(dt_petugas);
            label7.Text = dt_petugas.Rows.Count.ToString();

            // ambil data siswa
            string data_siswa = "SELECT * FROM data_siswa";
            MySqlCommand cmd_siswa = new MySqlCommand(data_siswa, conn);
            MySqlDataAdapter adapter_siswa = new MySqlDataAdapter(cmd_siswa);
            DataTable dt_siswa = new DataTable();
            adapter_siswa.Fill(dt_siswa);
            label6.Text = dt_siswa.Rows.Count.ToString();

            // ambil data transaksi
            string data_transaksi = "SELECT * FROM data_pembayaran";
            MySqlCommand cmd_transaksi = new MySqlCommand(data_transaksi, conn);
            MySqlDataAdapter adapter_transaksi = new MySqlDataAdapter(cmd_transaksi);
            DataTable dt_transaksi = new DataTable();
            adapter_transaksi.Fill(dt_transaksi);
            label8.Text = dt_transaksi.Rows.Count.ToString();

            // tampilkan daftar siswa
            dataGridView1.DataSource = dt_siswa;

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
            MySqlCommand cmd_petugas = new MySqlCommand(data_petugas, conn);
            MySqlDataAdapter adapter_petugas = new MySqlDataAdapter(cmd_petugas);
            DataTable dt_petugas = new DataTable();
            adapter_petugas.Fill(dt_petugas);
            label7.Text = dt_petugas.Rows.Count.ToString();

            // ambil data siswa
            string data_siswa = "SELECT * FROM data_siswa";
            MySqlCommand cmd_siswa = new MySqlCommand(data_siswa, conn);
            MySqlDataAdapter adapter_siswa = new MySqlDataAdapter(cmd_siswa);
            DataTable dt_siswa = new DataTable();
            adapter_siswa.Fill(dt_siswa);
            label6.Text = dt_siswa.Rows.Count.ToString();

            // ambil data transaksi
            string data_transaksi = "SELECT * FROM data_pembayaran";
            MySqlCommand cmd_transaksi = new MySqlCommand(data_transaksi, conn);
            MySqlDataAdapter adapter_transaksi = new MySqlDataAdapter(cmd_transaksi);
            DataTable dt_transaksi = new DataTable();
            adapter_transaksi.Fill(dt_transaksi);
            label8.Text = dt_transaksi.Rows.Count.ToString();

            // tampilkan daftar siswa
            dataGridView1.DataSource = dt_siswa;

            // tutup database
            conn.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // koneksi ke database
            string myConnectionString = "server=localhost;uid=root;pwd=root;database=spp_app";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            // ambil data siswa dari search
            string keywords = textBox1.Text;
            string cari_data_siswa = "SELECT * FROM data_siswa WHERE nisn = '" + keywords + "' OR nis = '" + keywords + "' OR nama LIKE '%" + keywords + "%' OR id_kelas = '" + keywords + "' OR alamat LIKE '%" + keywords + "' OR no_telp = '" + keywords + "' OR id_spp = '" + keywords + "'";
            MySqlCommand cmd_cari_siswa = new MySqlCommand(cari_data_siswa, conn);
            MySqlDataAdapter adapter_cari_siswa = new MySqlDataAdapter(cmd_cari_siswa);
            DataTable dt_cari_siswa = new DataTable();
            adapter_cari_siswa.Fill(dt_cari_siswa);

            // tampilkan daftar siswa
            dataGridView1.DataSource = dt_cari_siswa;

            // tutup database
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // koneksi ke database
            string myConnectionString = "server=localhost;uid=root;pwd=root;database=spp_app";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            // ambil data siswa dari search
            string keywords = textBox1.Text;
            string cari_data_siswa = "SELECT * FROM data_siswa WHERE nisn = '" + keywords + "' OR nis = '" + keywords + "' OR nama LIKE '%" + keywords + "%' OR id_kelas = '" + keywords + "' OR alamat LIKE '%" + keywords + "' OR no_telp = '" + keywords + "' OR id_spp = '" + keywords + "'";
            MySqlCommand cmd_cari_siswa = new MySqlCommand(cari_data_siswa, conn);
            MySqlDataAdapter adapter_cari_siswa = new MySqlDataAdapter(cmd_cari_siswa);
            DataTable dt_cari_siswa = new DataTable();
            adapter_cari_siswa.Fill(dt_cari_siswa);

            // tampilkan daftar siswa
            dataGridView1.DataSource = dt_cari_siswa;

            // tutup database
            conn.Close();
        }

        private void tambahkanSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tambah_siswa = new TambahSiswa();
            tambah_siswa.ShowDialog();
            tambah_siswa.Focus();
        }

        private void tambahkanPetugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tambah_petugas = new TambahPetugas();
            tambah_petugas.ShowDialog();
            tambah_petugas.Focus();
        }
    }
}