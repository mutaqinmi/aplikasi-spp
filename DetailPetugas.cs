﻿using MySql.Data.MySqlClient;
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
    public partial class DetailPetugas : Form
    {
        public DetailPetugas(string id_petugas, string username, string password, string nama_petugas, string jenis_petugas)
        {
            InitializeComponent();

            // mengambil data dari cell
            label4.Text = id_petugas;
            label6.Text = username;
            label8.Text = password;
            label10.Text = nama_petugas;
            label12.Text = jenis_petugas;
        }

        // hapus data
        private void button1_Click(object sender, EventArgs e)
        {
            // hapus petugas
            string hapus_petugas = "DELETE FROM data_user WHERE id_petugas = '" + label4.Text + "'";
            MySqlCommand cmd_hapus_petugas = new MySqlCommand(hapus_petugas, Program.Conn.Connection);
            var confirm = MessageBox.Show("Apakah anda yakin menghapus data petugas " + label10.Text + "?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                cmd_hapus_petugas.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus!\nSilahkan untuk refresh halaman melalui tombol 'Refresh' pada kanan menu", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        // update data
        private void button2_Click(object sender, EventArgs e)
        {
            // ambil data
            string id_petugas = label4.Text;
            string username = label6.Text;
            string password = label8.Text;
            string nama_petugas = label10.Text;
            string jenis_petugas = label12.Text;

            // tampilkan window update
            UpdatePetugas update_data = new UpdatePetugas(id_petugas, username, password, nama_petugas, jenis_petugas, this);
            this.Hide();
            update_data.ShowDialog();
            update_data.Focus();
        }
    }
}
