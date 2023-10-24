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
        public TambahSiswa()
        {
            InitializeComponent();
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
            string insert_siswa = "INSERT INTO data_siswa(nisn, nis, nama, id_kelas, alamat, no_telp, id_spp) VALUES ('" + nisn + "', '" + nis + "', '" + nama + "', '" + kelas + "', '" + alamat + "', '" + telepon + "', '" + 1 + "')";
            MySqlCommand cmd_insert_siswa = new MySqlCommand(insert_siswa, Program.Conn.Connection);
            Program.Conn.Open();
            cmd_insert_siswa.ExecuteNonQuery();
            MessageBox.Show("Data berhasil ditambahkan!\nSilahkan untuk refresh halaman melalui tombol 'Refresh' pada kanan menu", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.Conn.Close();
            this.Close();
        }
    }
}