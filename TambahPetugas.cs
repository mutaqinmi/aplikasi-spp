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
    public partial class TambahPetugas : Form
    {
        public TambahPetugas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // koneksi ke database
            string myConnectionString = "server=localhost;uid=root;pwd=root;database=spp_app";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            var username = textBox1.Text;
            var password = textBox2.Text;
            var nama = textBox3.Text;
            var jenis_petugas = comboBox1.Text;

            // tambah data petugas
            string insert_petugas = "INSERT INTO data_user(username, password, nama_petugas, jenis_petugas) VALUES ('" + username + "', '" + password + "', '" + nama + "', '" + jenis_petugas + "')";
            MySqlCommand cmd_insert_petugas = new MySqlCommand(insert_petugas, conn);
            cmd_insert_petugas.ExecuteNonQuery();
            MessageBox.Show("Data berhasil ditambahkan!\nSilahkan untuk refresh halaman melalui tombol 'Refresh' pada kanan menu", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            this.Close();
        }
    }
}
