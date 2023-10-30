using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SPP
{
    public partial class Form1 : Form
    {
        public SQLQuery sqlquery = new SQLQuery();
        public LogIn login = null;
        public string id = "";

        public Form1(LogIn main, string id_petugas)
        {
            InitializeComponent();
            this.login = main;
            id = id_petugas;
/*
            // ketika Form 1 dijalankan, login form akan dijalankan terlebih dahulu
            LogIn login = new LogIn(this);
            
            // mainform disembunyikan untuk menampilkan login
            this.Hide();
            login.ShowDialog();
            login.Focus();*/
        }

        public Label get_dataSiswa() { return label6; }
        public Label get_dataPetugas() { return label7; }
        public Label get_dataTransaksi() { return label8; }
        public DataGridView get_dataGridSiswa() { return dataGridView1; }
        public DataGridView get_dataGridLog() { return dataGridView2; }
        public string id_user() { return id; }

        // fungsi untuk merefresh data
        public void refreshData ()
        {
            // ambil data petugas
            label7.Text = sqlquery.selectAll("data_user").Rows.Count.ToString();

            // ambil data siswa
            label6.Text = sqlquery.selectAll("data_siswa").Rows.Count.ToString();

            // ambil data transaksi
            label8.Text = sqlquery.selectAll("data_pembayaran").Rows.Count.ToString();

            // tampilkan daftar siswa
            dataGridView1.DataSource = sqlquery.selectAll("data_siswa");
            dataGridView2.DataSource = sqlquery.selectAll("data_log");
        }

        public void search()
        {
            // tampilkan daftar siswa
            dataGridView1.DataSource = sqlquery.search("data_siswa", textBox1.Text);
        }

        // fungsi menampilkan data siswa
        public void showSiswa()
        {
            var lihat_siswa = new DataSiswa(this);
            lihat_siswa.ShowDialog();
        }

        // fungsi menampilkan data petugas
        public void showPetugas()
        {
            var lihat_petugas = new DataPetugas(this);
            lihat_petugas.ShowDialog();
        }

        public void logged_in(string username)
        {
            MessageBox.Show("Login Berhasil!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label5.Text = username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        // logout menu
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }

        // =============================================================================================================================================
        private void button2_Click(object sender, EventArgs e)
        {
            search();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void tambahkanSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tambah_siswa = new TambahSiswa(this);
            tambah_siswa.ShowDialog();
            tambah_siswa.Focus();
        }

        private void tambahkanPetugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tambah_petugas = new TambahPetugas(this);
            tambah_petugas.ShowDialog();
            tambah_petugas.Focus();
        }

        private void lihatSemuaSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSiswa();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            showSiswa();
        }

        private void lihatSemuaPetugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPetugas();
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            showPetugas();
        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }
    }
}