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

            // ketika Form 1 dijalankan, login form akan dijalankan terlebih dahulu
            LogIn login = new LogIn(this);
            
            // mainform disembunyikan untuk menampilkan login
            this.Hide();
            login.ShowDialog();
            login.Focus();
        }

        // fungsi untuk merefresh data
        public void refreshData ()
        {
            // ambil data petugas
            string data_petugas = "SELECT * FROM data_user";
            MySqlCommand cmd_petugas = new MySqlCommand(data_petugas, Program.Conn.Connection);
            MySqlDataAdapter adapter_petugas = new MySqlDataAdapter(cmd_petugas);
            DataTable dt_petugas = new DataTable();
            adapter_petugas.Fill(dt_petugas);
            label7.Text = dt_petugas.Rows.Count.ToString();

            // ambil data siswa
            string data_siswa = "SELECT * FROM data_siswa";
            MySqlCommand cmd_siswa = new MySqlCommand(data_siswa, Program.Conn.Connection);
            MySqlDataAdapter adapter_siswa = new MySqlDataAdapter(cmd_siswa);
            DataTable dt_siswa = new DataTable();
            adapter_siswa.Fill(dt_siswa);
            label6.Text = dt_siswa.Rows.Count.ToString();

            // ambil data transaksi
            string data_transaksi = "SELECT * FROM data_pembayaran";
            MySqlCommand cmd_transaksi = new MySqlCommand(data_transaksi, Program.Conn.Connection);
            MySqlDataAdapter adapter_transaksi = new MySqlDataAdapter(cmd_transaksi);
            DataTable dt_transaksi = new DataTable();
            adapter_transaksi.Fill(dt_transaksi);
            label8.Text = dt_transaksi.Rows.Count.ToString();

            // tampilkan daftar siswa
            dataGridView1.DataSource = dt_siswa;

            // tutup database
            Program.Conn.Close();
        }

        // fungsi menampilkan data siswa
        public void showSiswa()
        {
            var lihat_siswa = new DataSiswa();
            lihat_siswa.ShowDialog();
        }

        // fungsi menampilkan data petugas
        public void showPetugas()
        {
            var lihat_petugas = new DataPetugas();
            lihat_petugas.ShowDialog();
        }

        // fungsi dijalankan ketika berhasil login
        public void logged_in(string username)
        {
            MessageBox.Show("Login Berhasil!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // mainform ditampilkan setelah berhasil masuk
            this.Visible = true;
            label5.Text = username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        // logout menu
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ambil data siswa dari search
            string keywords = textBox1.Text;
            string cari_data_siswa = "SELECT * FROM data_siswa WHERE nisn = '" + keywords + "' OR nis = '" + keywords + "' OR nama LIKE '%" + keywords + "%' OR id_kelas = '" + keywords + "' OR alamat LIKE '%" + keywords + "' OR no_telp = '" + keywords + "' OR id_spp = '" + keywords + "'";
            MySqlCommand cmd_cari_siswa = new MySqlCommand(cari_data_siswa, Program.Conn.Connection);
            MySqlDataAdapter adapter_cari_siswa = new MySqlDataAdapter(cmd_cari_siswa);
            DataTable dt_cari_siswa = new DataTable();
            adapter_cari_siswa.Fill(dt_cari_siswa);

            // tampilkan daftar siswa
            dataGridView1.DataSource = dt_cari_siswa;

            // tutup database
            Program.Conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // ambil data siswa dari search
            string keywords = textBox1.Text;
            string cari_data_siswa = "SELECT * FROM data_siswa WHERE nisn = '" + keywords + "' OR nis = '" + keywords + "' OR nama LIKE '%" + keywords + "%' OR id_kelas = '" + keywords + "' OR alamat LIKE '%" + keywords + "' OR no_telp = '" + keywords + "' OR id_spp = '" + keywords + "'";
            MySqlCommand cmd_cari_siswa = new MySqlCommand(cari_data_siswa, Program.Conn.Connection);
            MySqlDataAdapter adapter_cari_siswa = new MySqlDataAdapter(cmd_cari_siswa);
            DataTable dt_cari_siswa = new DataTable();
            adapter_cari_siswa.Fill(dt_cari_siswa);

            // tampilkan daftar siswa
            dataGridView1.DataSource = dt_cari_siswa;

            // tutup database
            Program.Conn.Close();
        }

        // tampilkan window tambahkan siswa
        private void tambahkanSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tambah_siswa = new TambahSiswa();
            tambah_siswa.ShowDialog();
            tambah_siswa.Focus();
        }

        // tampilkan window tambahkan petugas
        private void tambahkanPetugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tambah_petugas = new TambahPetugas();
            tambah_petugas.ShowDialog();
            tambah_petugas.Focus();
        }

        // ketika cell pada Data Grid di klik
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ambil data siswa yang di klik
            string data_siswa = "SELECT * FROM data_siswa WHERE nisn = '" + dataGridView1.SelectedCells[0].Value.ToString() + "' OR nis = '" + dataGridView1.SelectedCells[0].Value.ToString() + "' OR nama LIKE '%" + dataGridView1.SelectedCells[0].Value.ToString() + "%' OR id_kelas = '" + dataGridView1.SelectedCells[0].Value.ToString() + "' OR alamat LIKE '%" + dataGridView1.SelectedCells[0].Value.ToString() + "' OR no_telp = '" + dataGridView1.SelectedCells[0].Value.ToString() + "' OR id_spp = '" + dataGridView1.SelectedCells[0].Value.ToString() + "'";
            MySqlCommand cmd_siswa = new MySqlCommand(data_siswa, Program.Conn.Connection);
            MySqlDataAdapter adapter_siswa = new MySqlDataAdapter(cmd_siswa);
            DataTable dt_siswa = new DataTable();
            adapter_siswa.Fill(dt_siswa);

            // memasukkan data
            string nisn = dt_siswa.Rows[0]["nisn"].ToString();
            string nis = dt_siswa.Rows[0]["nis"].ToString();
            string nama = dt_siswa.Rows[0]["nama"].ToString();
            string id_kelas = dt_siswa.Rows[0]["id_kelas"].ToString();
            string alamat = dt_siswa.Rows[0]["alamat"].ToString();
            string no_telp = dt_siswa.Rows[0]["no_telp"].ToString();
            string id_spp = dt_siswa.Rows[0]["id_spp"].ToString();

            // mengirim data ke window detail siswa
            var detail_siswa = new DetailSiswa(nisn, nis, nama, id_kelas, alamat, no_telp, id_spp);
            detail_siswa.ShowDialog();

            // tutup database
            Program.Conn.Close();
        }

        // tampilkan daftar siswa
        private void lihatSemuaSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSiswa();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            showSiswa();
        }

        // tampilkan daftar petugas
        private void lihatSemuaPetugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPetugas();
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            showPetugas();
        }

        // tampilkan daftar transaksi
        private void panel3_Click(object sender, EventArgs e)
        {

        }
    }
}