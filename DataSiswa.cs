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
        public SQLQuery sqlquery = new SQLQuery();
        public DataGridView get_dataGrid() { return dataGridView1; }
        public Form1 mainform = null;

        public DataSiswa(Form1 main)
        {
            InitializeComponent();
            this.mainform = main;
        }

        private void refreshData()
        {
            // tampilkan daftar siswa
            dataGridView1.DataSource = sqlquery.selectAll("data_siswa");
        }

        private void search()
        {
            // tampilkan daftar siswa
            dataGridView1.DataSource = sqlquery.search("data_siswa", textBox1.Text);
        }

        private void DataSiswa_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            search();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataRow row in sqlquery.selectAll("data_siswa").Rows){
                if (row["nisn"].ToString() == dataGridView1.SelectedCells[0].Value.ToString() || row["nis"].ToString() == dataGridView1.SelectedCells[0].Value.ToString() || row["nama"].ToString() == dataGridView1.SelectedCells[0].Value.ToString())
                {
                    string data_nisn = row["nisn"].ToString();
                    string data_nis = row["nis"].ToString();
                    string data_nama = row["nama"].ToString();
                    string data_id_kelas = row["id_kelas"].ToString();
                    string data_alamat = row["alamat"].ToString();
                    string data_no_telp = row["no_telp"].ToString();
                    string data_id_spp = row["id_spp"].ToString();

                    // mengirim data ke window detail siswa
                    var detail_siswa = new DetailSiswa(data_nisn, data_nis, data_nama, data_id_kelas, data_alamat, data_no_telp, data_id_spp, mainform, this);
                    detail_siswa.ShowDialog();
                }
            }
        }
    }
}
