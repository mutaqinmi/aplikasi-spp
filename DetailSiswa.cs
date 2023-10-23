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

            label15.Text = id_kelas;
            string kelas = "";

            switch (id_kelas)
            {
                case "1":
                    kelas = "X DPIB 1";
                    break;
                case "2":
                    kelas = "X DPIB 2";
                    break;
                case "3":
                    kelas = "X DPIB 3";
                    break;
                case "4":
                    kelas = "X DPIB 4";
                    break;
                case "5":
                    kelas = "X TE 1";
                    break;
                case "6":
                    kelas = "X TE 2";
                    break;
                case "7":
                    kelas = "X TE 3";
                    break;
                case "8":
                    kelas = "X TK 1";
                    break;
                case "9":
                    kelas = "X TK 2";
                    break;
                case "10":
                    kelas = "X TK 3";
                    break;
                case "11":
                    kelas = "X TK 4";
                    break;
                case "12":
                    kelas = "X TM 1";
                    break;
                case "13":
                    kelas = "X TM 2";
                    break;
                case "14":
                    kelas = "X TM 3";
                    break;
                case "15":
                    kelas = "X TM 4";
                    break;
                case "16":
                    kelas = "X TO 1";
                    break;
                case "17":
                    kelas = "X TO 2";
                    break;
                case "18":
                    kelas = "X TO 3";
                    break;
                case "19":
                    kelas = "X TO 4";
                    break;
                case "20":
                    kelas = "X TJKT 1";
                    break;
                case "21":
                    kelas = "X TJKT 2";
                    break;
                case "22":
                    kelas = "X PPLG";
                    break;
                case "23":
                    kelas = "X BP 1";
                    break;
                case "24":
                    kelas = "X BP 2";
                    break;
                case "25":
                    kelas = "XI DPIB 1";
                    break;
                case "26":
                    kelas = "XI DPIB 2";
                    break;
                case "27":
                    kelas = "XI DPIB 3";
                    break;
                case "28":
                    kelas = "XI DPIB 4";
                    break;
                case "29":
                    kelas = "XI TE 1";
                    break;
                case "30":
                    kelas = "XI TE 2";
                    break;
                case "31":
                    kelas = "XI TE 3";
                    break;
                case "32":
                    kelas = "XI TK 1";
                    break;
                case "33":
                    kelas = "XI TK 2";
                    break;
                case "34":
                    kelas = "XI TK 3";
                    break;
                case "35":
                    kelas = "XI TK 4";
                    break;
                case "36":
                    kelas = "XI TM 1";
                    break;
                case "37":
                    kelas = "XI TM 2";
                    break;
                case "38":
                    kelas = "XI TM 3";
                    break;
                case "39":
                    kelas = "XI TM 4";
                    break;
                case "40":
                    kelas = "XI TO 1";
                    break;
                case "41":
                    kelas = "XI TO 2";
                    break;
                case "42":
                    kelas = "XI TO 3";
                    break;
                case "43":
                    kelas = "XI TO 4";
                    break;
                case "44":
                    kelas = "XI TJKT 1";
                    break;
                case "45":
                    kelas = "XI TJKT 2";
                    break;
                case "46":
                    kelas = "XI PPLG";
                    break;
                case "47":
                    kelas = "XI BP 1";
                    break;
                case "48":
                    kelas = "XI BP 2";
                    break;
                case "49":
                    kelas = "XII DPIB 1";
                    break;
                case "50":
                    kelas = "XII DPIB 2";
                    break;
                case "51":
                    kelas = "XII DPIB 3";
                    break;
                case "52":
                    kelas = "XII DPIB 4";
                    break;
                case "53":
                    kelas = "XII TE 1";
                    break;
                case "54":
                    kelas = "XII TE 2";
                    break;
                case "55":
                    kelas = "XII TE 3";
                    break;
                case "56":
                    kelas = "XII TK 1";
                    break;
                case "57":
                    kelas = "XII TK 2";
                    break;
                case "58":
                    kelas = "XII TK 3";
                    break;
                case "59":
                    kelas = "XII TK 4";
                    break;
                case "60":
                    kelas = "XII TM 1";
                    break;
                case "61":
                    kelas = "XII TM 2";
                    break;
                case "62":
                    kelas = "XII TM 3";
                    break;
                case "63":
                    kelas = "XII TM 4";
                    break;
                case "64":
                    kelas = "XII TO 1";
                    break;
                case "65":
                    kelas = "XII TO 2";
                    break;
                case "66":
                    kelas = "XII TO 3";
                    break;
                case "67":
                    kelas = "XII TO 4";
                    break;
                case "68":
                    kelas = "XII TJKT 1";
                    break;
                case "69":
                    kelas = "XII TJKT 2";
                    break;
                case "70":
                    kelas = "XII PPLG";
                    break;
                case "71":
                    kelas = "XII BP 1";
                    break;
                case "72":
                    kelas = "XII BP 2";
                    break;
            }

            label4.Text = nisn;
            label5.Text = nis;
            label6.Text = nama;
            label8.Text = kelas;
            label10.Text = alamat;
            label12.Text = no_telp;
            label14.Text = id_spp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // koneksi ke database
            string myConnectionString = "server=localhost;uid=root;pwd=root;database=spp_app";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            // hapus siswa
            string hapus_siswa = "DELETE FROM data_siswa WHERE nisn = '" + label4.Text + "'";
            MySqlCommand cmd_hapus_siswa = new MySqlCommand(hapus_siswa, conn);
            var confirm = MessageBox.Show("Apakah anda yakin menghapus data siswa " + label6.Text + "?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                cmd_hapus_siswa.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus!\nSilahkan untuk refresh halaman melalui tombol 'Refresh' pada kanan menu", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nisn = label4.Text;
            string nis = label5.Text;
            string nama = label6.Text;
            string id_kelas = label15.Text;
            string alamat = label10.Text;
            string no_telp = label12.Text;
            string id_spp = label14.Text;

            var update_data = new Update(nisn, nis, nama, id_kelas, alamat, no_telp, id_spp);
            update_data.ShowDialog();
            update_data.Focus();
        }
    }
}
