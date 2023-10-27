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
        public TambahSiswa(Form1 main)
        {
            InitializeComponent();

            this.mainform = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ambil data dari textbox
            var nisn = textBox1.Text;
            var nis = textBox2.Text;
            var nama = textBox3.Text;
            var kelas = comboBox1.SelectedIndex + 1;
            var alamat = textBox4.Text;
            var telepon = textBox5.Text;
            // tambah data siswa

            SQLQuery insert = new SQLQuery();
            insert.insertSiswa(nisn, nis, nama, kelas, alamat, telepon, mainform);
            this.Close();
        }
    }
}