using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP
{
    public class DatabaseConnection
    {
        public MySqlConnection Connection { get; set; }
        public DatabaseConnection(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
        }
        public void Open()
        {
            Connection.Open();
        }
        public void Close()
        {
            Connection.Close();
        }
    }
}
