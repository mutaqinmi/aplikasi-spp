using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPP
{
    public class SQLQuery
    {
        public DataTable selectAll(string table_name)
        {
            string query = $"SELECT * FROM {table_name}";
            MySqlCommand command = new MySqlCommand(query, Program.Conn.Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }
}
