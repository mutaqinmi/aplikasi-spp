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
    public partial class DataSiswa : Form
    {
        public DataSiswa()
        {
            InitializeComponent();
        }

        private void refreshData()
        {
            // ambil data siswa
            string data_siswa = "SELECT * FROM data_siswa";
            MySqlCommand cmd_siswa = new MySqlCommand(data_siswa, Program.Conn.Connection);
            MySqlDataAdapter adapter_siswa = new MySqlDataAdapter(cmd_siswa);
            DataTable dt_siswa = new DataTable();
            adapter_siswa.Fill(dt_siswa);

            // tampilkan daftar siswa
            dataGridView1.DataSource = dt_siswa;
        }

        private void search()
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
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void DataSiswa_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ambil data siswa yang di klik
            string data_siswa = "SELECT * FROM data_siswa WHERE nisn = '" + dataGridView1.SelectedCells[0].Value.ToString() + "' OR nis = '" + dataGridView1.SelectedCells[0].Value.ToString() + "' OR nama LIKE '%" + dataGridView1.SelectedCells[0].Value.ToString() + "%'";
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
        }
    }
}
