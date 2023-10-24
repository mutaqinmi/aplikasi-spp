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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SPP
{
    public partial class UpdatePetugas : Form
    {
        public DetailPetugas mainform = null;
        public UpdatePetugas(string id_petugas, string username, string password, string nama_petugas, string jenis_petugas, DetailPetugas main)
        {
            InitializeComponent();

            // mengisi value textbox
            textBox4.Text = id_petugas;
            textBox1.Text = username;
            textBox2.Text = password;
            textBox3.Text = nama_petugas;
            var jenis = "";
            switch (jenis_petugas)
            {
                case "admin":
                    jenis = "0";
                    break;
                case "petugas":
                    jenis = "1"; 
                    break;
            }
            comboBox1.SelectedIndex = int.Parse(jenis);

            // jadikan window sebagai utama
            this.mainform = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // mengambil data dari textbox
            var id_petugas = textBox4.Text;
            var username = textBox1.Text;
            var password = textBox2.Text;
            var nama_petugas = textBox3.Text;
            var jenis_petugas = comboBox1.SelectedIndex + 1;

            // update petugas
            string update_petugas = "UPDATE data_user SET id_petugas = '" + id_petugas + "', username = '" + username + "', password = '" + password + "', nama_petugas = '" + nama_petugas + "', jenis_petugas = '" + jenis_petugas + "' WHERE id_petugas = '" + id_petugas + "'";
            MySqlCommand cmd_update_petugas = new MySqlCommand(update_petugas, Program.Conn.Connection);
            var confirm = MessageBox.Show("Apakah anda yakin mengedit data petugas " + textBox3.Text + "?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                cmd_update_petugas.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate!\nSilahkan untuk refresh halaman melalui tombol 'Refresh' pada kanan menu", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
