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
    public partial class TambahSiswa : Form
    {
        public Form1 mainform = null;
        public SQLQuery sqlquery = new SQLQuery();
        public string nominal = "";
        public string id_spp = "";

        public TambahSiswa(Form1 main)
        {
            InitializeComponent();

            this.mainform = main;

            for (int i = 0; i < sqlquery.selectAll("data_spp").Rows.Count; i++)
            {
                comboBox2.Items.Add(sqlquery.selectAll("data_spp").Rows[i]["tahun"].ToString());
                nominal = sqlquery.selectAll("data_spp").Rows[i]["nominal"].ToString();
                id_spp = sqlquery.selectAll("data_spp").Rows[i]["id_spp"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ambil data dari textbox;
            var nisn = textBox1.Text;
            var nis = textBox2.Text;
            var nama = textBox3.Text;
            var kelas = comboBox1.SelectedIndex + 1;
            var alamat = textBox4.Text;
            var telepon = textBox5.Text;
            var spp = nominal;
            var id = id_spp;
            
            object[] data = { nisn, nis, nama, kelas, alamat, telepon, id, spp };

            SQLQuery insert = new SQLQuery();
            insert.insert("data_siswa", data, mainform);
            this.Close();
        }
    }
}