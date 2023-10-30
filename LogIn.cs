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
        public SQLQuery sql_query = new SQLQuery();

        public LogIn()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // membuat kondisi checkbox pada password
            if(checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;            
            } else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // mengecek data apakah tersedia
            if(textBox1.Text != "")
            {
                if (sql_query.logIn(textBox1.Text).Rows.Count == 1)
                {
                    if (textBox1.Text == sql_query.logIn(textBox1.Text).Rows[0]["username"].ToString())
                    {
                        if(textBox2.Text == sql_query.logIn(textBox1.Text).Rows[0]["password"].ToString())
                        {
                            if(sql_query.logIn(textBox1.Text).Rows[0]["jenis_petugas"].ToString() == "admin")
                            {
                                Form1 form1 = new Form1(this, sql_query.logIn(textBox1.Text).Rows[0]["id_petugas"].ToString());

                                sql_query.log(sql_query.logIn(textBox1.Text).Rows[0]["id_petugas"].ToString(), "Log In");
                                form1.logged_in(sql_query.logIn(textBox1.Text).Rows[0]["nama_petugas"].ToString());
                                form1.Show();
                                this.Hide();
                            } else
                            {
                                Form2 petugas = new Form2();

                                sql_query.log(sql_query.logIn(textBox1.Text).Rows[0]["id_petugas"].ToString(), "Log In");
                                petugas.Show();
                            }
                        } else
                        {
                            MessageBox.Show("Password salah!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Username salah!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Data tidak tersedia!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}