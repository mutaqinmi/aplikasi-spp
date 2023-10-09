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

namespace SPP
{
    public partial class LogIn : Form
    {
        private Form1 mainform = null;

        public LogIn(Form1 main)
        {
            InitializeComponent();

            this.mainform = main;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
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
            string myConnectionString = "server=localhost;uid=root;pwd=root;database=spp_app";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string strQuery = "SELECT * FROM data_user WHERE USERNAME = '" + textBox1.Text + "' AND PASSWORD = '" + textBox2.Text + "'";
            MySqlCommand cmd = new MySqlCommand(strQuery, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (textBox1.Text == dt.Rows[0]["username"].ToString() && textBox2.Text == dt.Rows[0]["password"].ToString())
                {
                    mainform.logged_in();
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
            conn.Close();
        }
    }
}
