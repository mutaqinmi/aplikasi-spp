﻿using MySql.Data.MySqlClient;
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
    public partial class DetailPetugas : Form
    {
        public SQLQuery sqlquery = new SQLQuery();
        public Form1 mainform = null;
        public DataPetugas dataform = null;

        public Label get_data_id() { return label4; }
        public Label get_data_username() { return label6; }
        public Label get_data_password() { return label8; }
        public Label get_data_nama() { return label10; }
        public Label get_data_jenis() { return label12; }

        public DetailPetugas(string id_petugas, string username, string password, string nama_petugas, string jenis_petugas, Form1 main, DataPetugas main_petugas)
        {
            InitializeComponent();
            this.mainform = main;
            this.dataform = main_petugas;

            // mengambil data dari cell
            label4.Text = id_petugas;
            label6.Text = username;
            label8.Text = password;
            label10.Text = nama_petugas;
            label12.Text = jenis_petugas;
        }

        // hapus data
        private void button1_Click(object sender, EventArgs e)
        {
            // hapus petugas
            sqlquery.deleteData("data_user", "id_petugas", label4.Text, label10.Text, mainform, null, dataform);
            this.Close();
        }

        // update data
        private void button2_Click(object sender, EventArgs e)
        {
            // ambil data
            string id_petugas = label4.Text;
            string username = label6.Text;
            string password = label8.Text;
            string nama_petugas = label10.Text;
            string jenis_petugas = label12.Text;

            // tampilkan window update
            UpdatePetugas update_data = new UpdatePetugas(id_petugas, username, password, nama_petugas, jenis_petugas, this, mainform, dataform);
            this.Hide();
            update_data.ShowDialog();
            update_data.Focus();
        }
    }
}
