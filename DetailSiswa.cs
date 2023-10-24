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
    public partial class DetailSiswa : Form
    {
        public DetailSiswa(string nisn, string nis, string nama, string id_kelas, string alamat, string no_telp, string id_spp)
        {
            InitializeComponent();

            // mengisi value textbox
            label15.Text = id_kelas;
            string kelas = "";

            // ambil data kelas
            string data_kelas = "SELECT * FROM data_kelas";
            MySqlCommand cmd_kelas = new MySqlCommand(data_kelas, Program.Conn.Connection);
            MySqlDataAdapter adapter_kelas = new MySqlDataAdapter(cmd_kelas);
            DataTable dt_kelas = new DataTable();
            adapter_kelas.Fill(dt_kelas);

            for (var i = 0; i <= dt_kelas.Rows.Count; i++)
            {
                if (i <= int.Parse(id_kelas) - 1)
                {
                    kelas = dt_kelas.Rows[i]["nama_kelas"].ToString();
                }
            }

            label4.Text = nisn;
            label5.Text = nis;
            label6.Text = nama;
            label8.Text = kelas;
            label10.Text = alamat;
            label12.Text = no_telp;
            label14.Text = id_spp;
        }

        // menghapus data
        private void button1_Click(object sender, EventArgs e)
        {
            // hapus siswa
            string hapus_siswa = "DELETE FROM data_siswa WHERE nisn = '" + label4.Text + "'";
            MySqlCommand cmd_hapus_siswa = new MySqlCommand(hapus_siswa, Program.Conn.Connection);
            var confirm = MessageBox.Show("Apakah anda yakin menghapus data siswa " + label6.Text + "?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                cmd_hapus_siswa.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus!\nSilahkan untuk refresh halaman melalui tombol 'Refresh' pada kanan menu", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        // menampilkan update window
        private void button2_Click(object sender, EventArgs e)
        {
            // mengambil data
            string nisn = label4.Text;
            string nis = label5.Text;
            string nama = label6.Text;
            string id_kelas = label15.Text;
            string alamat = label10.Text;
            string no_telp = label12.Text;
            string id_spp = label14.Text;

            // tampilkan window
            Update update_data = new Update(nisn, nis, nama, id_kelas, alamat, no_telp, id_spp, this);
            this.Hide();
            update_data.ShowDialog();
            update_data.Focus();
        }
    }
}
