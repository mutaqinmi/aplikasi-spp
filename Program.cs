using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SPP
{
    internal static class Program
    {
        // membuat fungsi koneksi
        public static MySqlConnection Conn = new MySqlConnection("server=localhost;uid=root;pwd=root;database=spp_app");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // koneksi ke database
            try
            {
                Conn.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            // memulai aplikasi
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
