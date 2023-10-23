using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPP
{
    public partial class DataPetugas : Form
    {
        public DataPetugas()
        {
            InitializeComponent();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // koneksi ke database
            string myConnectionString = "server=localhost;uid=root;pwd=root;database=spp_app";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            // ambil data petugas
            string data_petugas = "SELECT * FROM data_petugas";
            MySqlCommand cmd_petugas = new MySqlCommand(data_petugas, conn);
            MySqlDataAdapter adapter_petugas = new MySqlDataAdapter(cmd_petugas);
            DataTable dt_petugas = new DataTable();
            adapter_petugas.Fill(dt_petugas);

            // tampilkan daftar petugas
            dataGridView1.DataSource = dt_petugas;

            // tutup database
            conn.Close();
        }

        private void DataPetugas_Load(object sender, EventArgs e)
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

            // tampilkan daftar petugas
            dataGridView1.DataSource = dt_petugas;

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

            // ambil data petugas dari search
            string keywords = textBox1.Text;
            string cari_data_petugas = "SELECT * FROM data_user WHERE id_petugas = '" + keywords + "' OR username LIKE '%" + keywords + "%' OR password = '" + keywords + "' OR nama_petugas LIKE '%" + keywords + "%' OR jenis_petugas = '" + keywords + "'";
            MySqlCommand cmd_cari_petugas = new MySqlCommand(cari_data_petugas, conn);
            MySqlDataAdapter adapter_cari_petugas = new MySqlDataAdapter(cmd_cari_petugas);
            DataTable dt_cari_petugas = new DataTable();
            adapter_cari_petugas.Fill(dt_cari_petugas);

            // tampilkan daftar siswa
            dataGridView1.DataSource = dt_cari_petugas;

            // tutup database
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // koneksi ke database
            string myConnectionString = "server=localhost;uid=root;pwd=root;database=spp_app";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            // ambil data petugas dari search
            string keywords = textBox1.Text;
            string cari_data_petugas = "SELECT * FROM data_user WHERE id_petugas = '" + keywords + "' OR username LIKE '%" + keywords + "%' OR password = '" + keywords + "' OR nama_petugas LIKE '%" + keywords + "%' OR jenis_petugas = '" + keywords + "'";
            MySqlCommand cmd_cari_petugas = new MySqlCommand(cari_data_petugas, conn);
            MySqlDataAdapter adapter_cari_petugas = new MySqlDataAdapter(cmd_cari_petugas);
            DataTable dt_cari_petugas = new DataTable();
            adapter_cari_petugas.Fill(dt_cari_petugas);

            // tampilkan daftar siswa
            dataGridView1.DataSource = dt_cari_petugas;

            // tutup database
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());

            // koneksi ke database
            string myConnectionString = "server=localhost;uid=root;pwd=root;database=spp_app";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            // ambil data petugas yang di select
            string data_petugas = "SELECT * FROM data_user WHERE id_petugas = '" + dataGridView1.SelectedCells[0].Value.ToString() + "' OR username = '" + dataGridView1.SelectedCells[0].Value.ToString() + "' OR password LIKE '%" + dataGridView1.SelectedCells[0].Value.ToString() + "%' OR nama_petugas = '" + dataGridView1.SelectedCells[0].Value.ToString() + "' OR jenis_petugas LIKE '%" + dataGridView1.SelectedCells[0].Value.ToString() + "'";
            MySqlCommand cmd_petugas = new MySqlCommand(data_petugas, conn);
            MySqlDataAdapter adapter_petugas = new MySqlDataAdapter(cmd_petugas);
            DataTable dt_petugas = new DataTable();
            adapter_petugas.Fill(dt_petugas);

            // memasukkan data
            string id_petugas = dt_petugas.Rows[0]["id_petugas"].ToString();
            string username = dt_petugas.Rows[0]["username"].ToString();
            string password = dt_petugas.Rows[0]["password"].ToString();
            string nama_petugas = dt_petugas.Rows[0]["nama_petugas"].ToString();
            string jenis_petugas = dt_petugas.Rows[0]["jenis_petugas"].ToString();

            var detail_petugas = new DetailPetugas(id_petugas, username, password, nama_petugas, jenis_petugas);
            detail_petugas.ShowDialog();
        }
    }
}
