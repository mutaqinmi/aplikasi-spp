using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SPP
{
    public class SQLQuery
    {
        public Form1 mainform = null;
        public DataSiswa mainform_siswa = null;
        public DataPetugas mainform_petugas = null;
        public DetailSiswa mainform_detail_siswa = null;
        public DetailPetugas mainform_detail_petugas = null;

        public void log(string id_user, string activity)
        {
            string query = $"INSERT INTO data_log VALUES (NULL, '{id_user}', '{activity}', NOW())";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            command.ExecuteNonQuery();
        }

        public DataTable logIn(string username)
        {
            string query = $"SELECT * FROM data_user WHERE username = '{username}'";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable selectAll(string table_name)
        {
            string orderby = "";
            if(table_name == "data_siswa")
            {
                orderby = $" ORDER BY nis";
            } else if (table_name == "data_user")
            {
                orderby = $" ORDER BY nama_petugas";
            } else if (table_name == "data_log")
            {
                orderby = $" ORDER BY waktu DESC LIMIT 20";
            } else if (table_name == "data_pembayaran")
            {
                orderby = $" ORDER BY tgl_bayar LIMIT 20";
            }
            string query = $"SELECT * FROM {table_name}" + orderby;
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        // EXPERIMENTAL!!!
        public void refreshData(Form1 main, DataSiswa main_siswa, DataPetugas main_petugas)
        {
            Form1 mainform = main;
            DataSiswa mainform_siswa = main_siswa;
            DataPetugas mainform_petugas = main_petugas;

            // ambil data petugas
            mainform.get_dataPetugas().Text = selectAll("data_user").Rows.Count.ToString();

            // ambil data siswa
            mainform.get_dataSiswa().Text = selectAll("data_siswa").Rows.Count.ToString();

            // ambil data transaksi
            mainform.get_dataTransaksi().Text = selectAll("data_pembayaran").Rows.Count.ToString();

            // tampilkan daftar siswa
            mainform.get_dataGridSiswa().DataSource = selectAll("data_siswa");
            mainform.get_dataGridLog().DataSource = selectAll("data_log");
            if(mainform_siswa != null)
            {
                mainform_siswa.get_dataGrid().DataSource = selectAll("data_siswa");
            } 
            
            if (mainform_petugas != null)
            {
                mainform_petugas.get_dataGrid().DataSource = selectAll("data_user");
            }
        }

        public void refreshDetailSiswa(DetailSiswa main_detail_siswa)
        {
            DetailSiswa mainform_detail_siswa = main_detail_siswa;

            string id_kelas = mainform_detail_siswa.get_data_idkelas().Text;
            string kelas = "";

            // ambil data kelas
            for (int i = 0; i <= selectAll("data_kelas").Rows.Count; i++)
            {
                if (i <= int.Parse(id_kelas) - 1)
                {
                    kelas = selectAll("data_kelas").Rows[i]["nama_kelas"].ToString();
                }
            }

            mainform_detail_siswa.get_data_nisn().Text = mainform_detail_siswa.get_data_nisn().Text;
            mainform_detail_siswa.get_data_nis().Text = mainform_detail_siswa.get_data_nis().Text;
            mainform_detail_siswa.get_data_nama().Text = mainform_detail_siswa.get_data_nama().Text;
            mainform_detail_siswa.get_data_kelas().Text = kelas;
            mainform_detail_siswa.get_data_alamat().Text = mainform_detail_siswa.get_data_alamat().Text;
            mainform_detail_siswa.get_data_telp().Text = mainform_detail_siswa.get_data_telp().Text;
            mainform_detail_siswa.get_data_spp().Text = mainform_detail_siswa.get_data_spp().Text;
        }

        public void refreshDetailPetugas(DetailPetugas main_detail_petugas)
        {
            DetailPetugas mainform_detail_petugas = main_detail_petugas;

            mainform_detail_petugas.get_data_id().Text = mainform_detail_petugas.get_data_id().Text;
            mainform_detail_petugas.get_data_username().Text = mainform_detail_petugas.get_data_username().Text;
            mainform_detail_petugas.get_data_password().Text = mainform_detail_petugas.get_data_password().Text;
            mainform_detail_petugas.get_data_nama().Text = mainform_detail_petugas.get_data_nama().Text;
            mainform_detail_petugas.get_data_jenis().Text = mainform_detail_petugas.get_data_jenis().Text;
        }

        public DataTable search(string table_name, string data)
        {
            string keywords = data;
            string query = "";
            if(table_name == "data_siswa")
            {
                query = $"SELECT * FROM data_siswa WHERE nisn LIKE '%{keywords}%' OR nis LIKE '%{keywords}%' OR nama LIKE '%{keywords}%' OR id_kelas LIKE '%{keywords}%' OR alamat LIKE '%{keywords}' OR no_telp LIKE '%{keywords}%'";
            } else if (table_name == "data_user")
            {
                query = $"SELECT * FROM data_user WHERE id_petugas LIKE '%{keywords}%' OR username LIKE '%{keywords}%' OR nama_petugas LIKE '%{keywords}%' OR jenis_petugas LIKE '%{keywords}%'";
            }
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public void insert(string table_name, object[] arr, Form1 main)
        {
            Form1 mainform = main;
            object[] data = arr;
            string query = "";
            if(table_name == "data_siswa")
            {
                query = $"INSERT INTO data_siswa VALUES ('{data[0]}', '{data[1]}', '{data[2]}', '{data[3]}', '{data[4]}', '{data[5]}', '{data[6]}', '{data[7]}', 'belum lunas')";
            } else if (table_name == "data_user")
            {
                query = $"INSERT INTO data_user VALUES (NULL, '{data[0]}', '{data[1]}', '{data[2]}', '{data[3]}')";
            } else if (table_name == "data_pembayaran")
            {
                query = $"INSERT INTO data_pembayaran VALUES (NULL, '{data[0]}', '{data[1]}', '{data[2]}', '{data[3]}', '{data[4]}', '{data[5]}', '{data[6]}')";
            }
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            if (!data.Contains(string.Empty))
            {
                command.ExecuteNonQuery();
                if (table_name == "data_siswa")
                {
                    log(mainform.id_user(), $"Insert siswa {data[2]}");
                }
                else if (table_name == "data_user")
                {
                    log(mainform.id_user(), $"Insert petugas {data[2]}");
                }

                if (table_name != "data_pembayaran")
                {
                    MessageBox.Show("Data berhasil ditambahkan!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshData(mainform, null, null);
                }
            } else
            {
                MessageBox.Show("Masukkan data dengan benar!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void deleteData(string table_name, string id_variable, string id, string nama, Form1 main, DataSiswa main_siswa, DataPetugas main_petugas)
        {
            Form1 mainform = main;
            DataSiswa mainform_siswa = main_siswa;
            DataPetugas mainform_petugas = main_petugas;
            string jenis_petugas = "";
            if(table_name == "data_siswa")
            {
                jenis_petugas = "siswa";
            } else if (table_name == "data_user")
            {
                jenis_petugas = "petugas";
            }

            string query = $"DELETE FROM {table_name} WHERE {id_variable} = '{id}'";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            var confirm = MessageBox.Show("Apakah anda yakin menghapus data ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                log(mainform.id_user(), $"Hapus {jenis_petugas} {nama}");
                MessageBox.Show("Data berhasil dihapus!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshData(mainform, mainform_siswa, mainform_petugas);
        }

        public void updateSiswa(string nisn, string nis, string nama, int kelas, string alamat, string telepon, string id_spp, DetailSiswa main_detail_siswa, Form1 main, DataSiswa main_siswa)
        {
            Form1 mainform = main;
            DataSiswa mainform_siswa = main_siswa;
            DetailSiswa mainform_detail_siswa = main_detail_siswa;

            string query = $"UPDATE data_siswa SET nisn = '{nisn}', nis = '{nis}', nama = '{nama}', id_kelas = '{kelas}', alamat = '{alamat}', no_telp = '{telepon}', id_spp = '{id_spp}' WHERE nisn = '{nisn}'";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            var confirm = MessageBox.Show("Apakah anda yakin mengedit data ini?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                log(mainform.id_user(), $"Update siswa {nama}");
                MessageBox.Show("Data berhasil diupdate!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshData(mainform, mainform_siswa, null);
            refreshDetailSiswa(mainform_detail_siswa);
        }

        public void updatePetugas(string id_petugas, string username, string password, string nama_petugas, int jenis_petugas, DetailPetugas main_detail_petugas, Form1 main, DataPetugas main_petugas)
        {
            Form1 mainform = main;
            DataPetugas mainform_petugas = main_petugas;
            DetailPetugas mainform_detail_petugas = main_detail_petugas;

            string query = $"UPDATE data_user SET id_petugas = '{id_petugas}', username = '{username}', password = '{password}', nama_petugas = '{nama_petugas}', jenis_petugas = '{jenis_petugas}' WHERE id_petugas = '{id_petugas}'";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            var confirm = MessageBox.Show("Apakah anda yakin mengedit data ini?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                log(mainform.id_user(), $"Update petugas {nama_petugas}");
                MessageBox.Show("Data berhasil diupdate!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refreshData(mainform, null, mainform_petugas);
            refreshDetailPetugas(mainform_detail_petugas);
        }

        public void bayar(string id_petugas, object[] data_bayar, string nama_siswa, int jumlah)
        {
            insert("data_pembayaran", data_bayar, null);

            if(jumlah >= 0)
            {
                string query = "";
                if(jumlah == 0)
                {
                    query = $"UPDATE data_siswa SET jumlah_spp = '{jumlah}', status_pembayaran = 'lunas' WHERE nisn = '{data_bayar[1]}'";
                } else
                {
                    query = $"UPDATE data_siswa SET jumlah_spp = '{jumlah}' WHERE nisn = '{data_bayar[1]}'";
                }
                MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
                command.ExecuteNonQuery();
                log(id_petugas, $"Bayar {nama_siswa}");
            
                MessageBox.Show("Pembayaran berhasil!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Masukkan jumlah yang sesuai!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}