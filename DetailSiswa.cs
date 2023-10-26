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
        public SQLQuery sqlquery = new SQLQuery();

        public DetailSiswa(string nisn, string nis, string nama, string id_kelas, string alamat, string no_telp, string id_spp)
        {
            InitializeComponent();

            // mengisi value textbox
            label15.Text = id_kelas;
            string kelas = "";

            // ambil data kelas
            for(int i = 0; i <= sqlquery.selectAll("data_kelas").Rows.Count; i++)
            {
                if(i <= int.Parse(id_kelas) - 1)
                {
                    kelas = sqlquery.selectAll("data_kelas").Rows[i]["nama_kelas"].ToString();
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
            sqlquery.deleteData("data_siswa", "nisn", label4.Text);
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