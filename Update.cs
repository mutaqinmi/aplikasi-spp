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
    public partial class Update : Form
    {
        public Form1 mainform = null;
        public DataSiswa dataform = null;
        private DetailSiswa detailform = null;
        public SQLQuery sqlquery = new SQLQuery();
        public Update(string nisn, string nis, string nama, string kelas, string alamat, string no_telp, string id_spp, DetailSiswa main_siswa_detail, Form1 main, DataSiswa main_siswa)
        {
            InitializeComponent();

            textBox1.Text = nisn;
            textBox2.Text = nis;
            textBox3.Text = nama;
            comboBox1.SelectedIndex = int.Parse(kelas) - 1;
            textBox4.Text = alamat;
            textBox5.Text = no_telp;
            textBox6.Text = id_spp;

            // menjadikan window utama
            this.detailform = main_siswa_detail;
            this.mainform = main;
            this.dataform = main_siswa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ambil data
            var nisn = textBox1.Text;
            var nis = textBox2.Text;
            var nama = textBox3.Text;
            var kelas = comboBox1.SelectedIndex + 1;
            var alamat = textBox4.Text;
            var telepon = textBox5.Text;
            var id_spp = textBox6.Text;

            // update siswa
            sqlquery.updateSiswa(nisn, nis, nama, kelas, alamat, telepon, id_spp, detailform, mainform, dataform);
            this.Close();
        }
    }
}
