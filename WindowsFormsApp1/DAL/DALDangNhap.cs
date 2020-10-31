using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    class DALDangNhap
    {
        DataConnection dc;
        MySqlDataAdapter da;
        public DALDangNhap()
        {
            dc = new DataConnection();
        }
        public DataTable login(String str1, String str2)
        {
            String sql = "SELECT * FROM tb_admin Where username= '" + str1 + "' and password='" + str2 + "' ";
            MySqlConnection con = dc.getConnection();
            da = new MySqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable registration()
        {
            String sql = "SELECT * FROM tb_admin";
            MySqlConnection con = dc.getConnection();
            da = new MySqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
