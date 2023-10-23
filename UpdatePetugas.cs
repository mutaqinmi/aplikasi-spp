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
    public partial class UpdatePetugas : Form
    {
        public UpdatePetugas(string id_petugas, string username, string password, string nama_petugas, string jenis_petugas)
        {
            InitializeComponent();

            textBox4.Text = id_petugas;
            textBox1.Text = username;
            textBox2.Text = password;
            textBox3.Text = nama_petugas;
            var jenis = "";
            switch (jenis_petugas)
            {
                case "admin":
                    jenis = "1";
                    break;
                case "petugas":
                    jenis = "2"; 
                    break;
            }
            comboBox1.SelectedIndex = int.Parse(jenis);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
