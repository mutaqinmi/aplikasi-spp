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

namespace SPP
{
    public class SQLQuery
    {
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
            string query = $"SELECT * FROM {table_name}";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        // EXPERIMENTAL!!!
        /*public void refreshDataSiswa()
        {
            // ambil data petugas
            label7.Text = selectAll("data_user").Rows.Count.ToString();

            // ambil data siswa
            label6.Text = selectAll("data_siswa").Rows.Count.ToString();

            // ambil data transaksi
            label8.Text = selectAll("data_pembayaran").Rows.Count.ToString();

            // tampilkan daftar siswa
            dataGridView1.DataSource = selectAll("data_siswa");
        }

        public void refreshDataPetugas()
        {
            // ambil data petugas
            label7.Text = sqlquery.selectAll("data_user").Rows.Count.ToString();

            // ambil data siswa
            label6.Text = sqlquery.selectAll("data_siswa").Rows.Count.ToString();

            // ambil data transaksi
            label8.Text = sqlquery.selectAll("data_pembayaran").Rows.Count.ToString();

            // tampilkan daftar siswa
            Form1.dataGridView1.DataSource = sqlquery.selectAll("data_siswa");
        }*/

        public DataTable searchSiswa(string data)
        {
            string keywords = data;
            string query = $"SELECT * FROM data_siswa WHERE nisn LIKE '%{keywords}%' OR nis LIKE '%{keywords}%' OR nama LIKE '%{keywords}%' OR id_kelas LIKE '%{keywords}%' OR alamat LIKE '%{keywords}' OR no_telp LIKE '%{keywords}%'";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public DataTable searchPetugas(string data)
        {
            string keywords = data;
            string query = $"SELECT * FROM data_user WHERE id_petugas LIKE '%{keywords}%' OR username LIKE '%{keywords}%' OR nama_petugas LIKE '%{keywords}%' OR jenis_petugas LIKE '%{keywords}%'";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public void insertSiswa(string nisn, string nis, string nama, int kelas, string alamat, string telepon)
        {
            string query = $"INSERT INTO data_siswa(nisn, nis, nama, id_kelas, alamat, no_telp, id_spp) VALUES ('{nisn}', '{nis}', '{nama}', '{kelas}', '{alamat}', '{telepon}', '" + 1 + "')";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            command.ExecuteNonQuery();

            MessageBox.Show("Data berhasil ditambahkan!\nSilahkan untuk refresh halaman melalui tombol 'Refresh' pada kanan menu", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public void insertPetugas(string username, string password, string nama, string jenis_petugas)
        {
            string query = $"INSERT INTO data_user(username, password, nama_petugas, jenis_petugas) VALUES ('{username}', '{password}', '{nama}', '{jenis_petugas}')";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            command.ExecuteNonQuery();

            MessageBox.Show("Data berhasil ditambahkan!\nSilahkan untuk refresh halaman melalui tombol 'Refresh' pada kanan menu", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void deleteData(string table_name, string id_variable, string id)
        {
            string query = $"DELETE FROM {table_name} WHERE {id_variable} = '{id}'";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            var confirm = MessageBox.Show("Apakah anda yakin menghapus data ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus!\nSilahkan untuk refresh halaman melalui tombol 'Refresh' pada kanan menu", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void updateSiswa(string nisn, string nis, string nama, int kelas, string alamat, string telepon, string id_spp)
        {
            string query = $"UPDATE data_siswa SET nisn = '{nisn}', nis = '{nis}', nama = '{nama}', id_kelas = '{kelas}', alamat = '{alamat}', no_telp = '{telepon}', id_spp = '{id_spp}' WHERE nisn = '{nisn}'";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            var confirm = MessageBox.Show("Apakah anda yakin mengedit data ini?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate!\nSilahkan untuk refresh halaman melalui tombol 'Refresh' pada kanan menu", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void updatePetugas(string id_petugas, string username, string password, string nama_petugas, int jenis_petugas)
        {
            string query = $"UPDATE data_user SET id_petugas = '{id_petugas}', username = '{username}', password = '{password}', nama_petugas = '{nama_petugas}', jenis_petugas = '{jenis_petugas}' WHERE id_petugas = '{id_petugas}'";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            var confirm = MessageBox.Show("Apakah anda yakin mengedit data ini?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate!\nSilahkan untuk refresh halaman melalui tombol 'Refresh' pada kanan menu", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
