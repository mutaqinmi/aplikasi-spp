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
    public partial class Form2 : Form
    {
        public SQLQuery sqlquery = new SQLQuery();
        public LogIn login = null;
        public string id = "";
        public string id_user() { return id; }

        public Form2(LogIn main, string id_petugas, string nama_petugas)
        {
            InitializeComponent();
            this.login = main;
            id = id_petugas;
            label12.Text = nama_petugas;
            label14.Text = sqlquery.selectAll("data_pembayaran").Rows.Count.ToString();
            label16.Text = sqlquery.selectAll("data_siswa").Rows.Count.ToString();
            dataGridView1.DataSource = sqlquery.selectAll("data_pembayaran");

            for (int i = 0; i < sqlquery.selectAll("data_siswa").Rows.Count; i++)
            {
                comboBox1.Items.Add(sqlquery.selectAll("data_siswa").Rows[i]["nama"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data_siswa = sqlquery.search("data_siswa", comboBox1.Text);

            if(data_siswa.Rows[0]["status_pembayaran"].ToString() == "lunas")
            {
                MessageBox.Show($"SPP {data_siswa.Rows[0]["nama"]} sudah lunas!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button1.Visible = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                textBox3.Enabled = false;
                textBox5.Enabled = false;
            } else
            {
                button1.Enabled = true;
                button1.Visible = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                textBox3.Enabled = true;
                textBox5.Enabled = true;
            }

            textBox4.Text = data_siswa.Rows[0]["jumlah_spp"].ToString();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Select(Right, 0);
            for (int i = 0; i < sqlquery.search("data_siswa", comboBox1.Text).Rows.Count; i++)
            {
                comboBox1.Items.Add(sqlquery.search("data_siswa", comboBox1.Text).Rows[i]["nama"].ToString());
                comboBox1.DroppedDown = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable data_siswa = sqlquery.search("data_siswa", comboBox1.Text);

            string nama_siswa = data_siswa.Rows[0]["nama"].ToString();
            string id_petugas = id;
            string nisn = data_siswa.Rows[0]["nisn"].ToString();
            string tgl_bayar = comboBox2.Text;
            string bln_bayar = comboBox3.Text;
            string thn_bayar = textBox3.Text;
            string id_spp = data_siswa.Rows[0]["id_spp"].ToString();
            string jumlah_bayar = textBox5.Text;

            int jumlah = int.Parse(textBox4.Text) - int.Parse(textBox5.Text);

            object[] data_bayar = { id, nisn, tgl_bayar, bln_bayar, thn_bayar, id_spp, jumlah_bayar };

            sqlquery.bayar(id_petugas, data_bayar, nama_siswa, jumlah);

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            textBox3.Clear();
            textBox5.Clear();
            label14.Text = sqlquery.selectAll("data_pembayaran").Rows.Count.ToString();
            dataGridView1.DataSource = sqlquery.selectAll("data_pembayaran");
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            DataSiswa data_siswa = new DataSiswa(null);
            data_siswa.ShowDialog();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            DataTransaksi data_transaksi = new DataTransaksi();
            data_transaksi.ShowDialog();
        }
    }
}
