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
        private DetailSiswa mainform = null;

        public Update(string nisn, string nis, string nama, string kelas, string alamat, string no_telp, string id_spp, DetailSiswa main)
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
            this.mainform = main;
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
            string update_siswa = "UPDATE data_siswa SET nisn = '" + nisn + "', nis = '" + nis + "', nama = '" + nama + "', id_kelas = '" + kelas + "', alamat = '" + alamat + "', no_telp = '" + telepon + "', id_spp = '" + id_spp + "' WHERE nisn = '" + nisn + "'";
            MySqlCommand cmd_update_siswa = new MySqlCommand(update_siswa, Program.Conn.Connection);
            var confirm = MessageBox.Show("Apakah anda yakin mengedit data siswa " + textBox3.Text + "?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                cmd_update_siswa.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate!\nSilahkan untuk refresh halaman melalui tombol 'Refresh' pada kanan menu", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
