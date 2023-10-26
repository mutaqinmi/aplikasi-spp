using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;

namespace SPP
{
    public partial class LogIn : Form
    {
        private Form1 mainform = null;
        public SQLQuery sql_query = new SQLQuery();

        public LogIn(Form1 main)
        {
            InitializeComponent();

            // menentukan main form menjadi login form
            this.mainform = main;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // membuat kondisi checkbox pada password
            if(checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;            
            } else
            {
                textBox2.UseSystemPasswordChar= true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // mengecek data apakah tersedia
            if (sql_query.logIn(textBox1.Text).Rows.Count == 1)
            {
                if (textBox1.Text == sql_query.logIn(textBox1.Text).Rows[0]["username"].ToString() && textBox2.Text == sql_query.logIn(textBox1.Text).Rows[0]["password"].ToString())
                {
                    mainform.logged_in(textBox1.Text);
                    this.Close();
                } else
                {
                    MessageBox.Show("Username atau password salah!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}