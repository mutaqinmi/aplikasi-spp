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

            label4.Text = nisn;
            label5.Text = nis;
            label6.Text = nama;
            label7.Text = id_kelas;
            label8.Text = alamat;
            label9.Text = no_telp;
            label10.Text = id_spp;
        }
    }
}
