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
        public string jumlah_spp = "";
        public string id_spp = "";
        public string id = "";
        public string id_user() { return id; }

        public Form2(LogIn main, string id_petugas)
        {
            InitializeComponent();
            this.login = main;
            id = id_petugas;

            for (int i = 0; i < sqlquery.selectAll("data_siswa").Rows.Count; i++)
            {
                comboBox1.Items.Add(sqlquery.selectAll("data_siswa").Rows[i]["nama"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*jumlah_spp = sqlquery.selectAll("data_spp").Rows[i]["jumlah_spp"].ToString();
            id_spp = sqlquery.selectAll("data_spp").Rows[i]["id_spp"].ToString();*/

            textBox4.Text = comboBox1.Text;
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
    }
}
