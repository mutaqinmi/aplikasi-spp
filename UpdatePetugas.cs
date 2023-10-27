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
        public Form1 mainform = null;
        public DataPetugas dataform = null;
        private DetailPetugas detailform = null;
        public SQLQuery sqlquery = new SQLQuery();

        public UpdatePetugas(string id_petugas, string username, string password, string nama_petugas, string jenis_petugas, DetailPetugas main_petugas_detail, Form1 main, DataPetugas main_petugas)
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
            this.detailform = main_petugas_detail;
            this.mainform = main;
            this.dataform = main_petugas;
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
            sqlquery.updatePetugas(id_petugas, username, password, nama_petugas, jenis_petugas, detailform, mainform, dataform);
            this.Close();
        }
    }
}
