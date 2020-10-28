using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DataConnection
    {
        string str;
        public DataConnection()
        {
            str = "datasource=127.0.0.1; username=root; password=; database=trangtrai; convert zero datetime=True";
        }
        public MySqlConnection getConnection()
        {
            return new MySqlConnection(str);
        }
    }
}
