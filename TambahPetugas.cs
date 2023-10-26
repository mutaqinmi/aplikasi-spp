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
            // mengambil data dari textbox
            var username = textBox1.Text;
            var password = textBox2.Text;
            var nama = textBox3.Text;
            var jenis_petugas = comboBox1.Text;

            // tambah data petugas
            SQLQuery insert = new SQLQuery();
            insert.insertPetugas(username, password, nama, jenis_petugas);
            this.Close();
        }
    }
}
