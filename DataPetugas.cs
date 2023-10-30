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
        public SQLQuery sqlquery = new SQLQuery();
        public Form1 mainform = null;

        public DataPetugas(Form1 main)
        {
            InitializeComponent();
            this.mainform = main;
        }
        public DataGridView get_dataGrid() { return dataGridView1; }

        public void refreshData()
        {
            // tampilkan daftar petugas
            dataGridView1.DataSource = sqlquery.selectAll("data_user");
        }

        public void search()
        {
            // tampilkan daftar siswa
            dataGridView1.DataSource = sqlquery.search("data_user", textBox1.Text);
        }

        private void DataPetugas_Load(object sender, EventArgs e)
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
            foreach (DataRow row in sqlquery.selectAll("data_user").Rows)
            {
                if (row["id_petugas"].ToString() == dataGridView1.SelectedCells[0].Value.ToString() || row["username"].ToString() == dataGridView1.SelectedCells[0].Value.ToString() || row["nama_petugas"].ToString() == dataGridView1.SelectedCells[0].Value.ToString())
                {
                    string data_id_petugas = row["id_petugas"].ToString();
                    string data_username = row["username"].ToString();
                    string data_password = row["password"].ToString();
                    string data_nama_petugas = row["nama_petugas"].ToString();
                    string data_jenis_petugas = row["jenis_petugas"].ToString();

                    // mengirim data ke window detail petugas
                    var detail_petugas = new DetailPetugas(data_id_petugas, data_username, data_password, data_nama_petugas, data_jenis_petugas, mainform, this);
                    detail_petugas.ShowDialog();
                }
            }
        }
    }
}
