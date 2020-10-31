using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    class DALDangKy
    {
        DataConnection dc;
        MySqlCommand cmd;
        public DALDangKy()
        {
            dc = new DataConnection();
        }
        public bool regisTration(DTO.User admin)
        {
            string sql = "INSERT INTO tb_admin(username, password) VALUES (@username, @password)";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("username", MySqlDbType.VarChar).Value = admin.username;
                cmd.Parameters.Add("password", MySqlDbType.VarChar).Value = admin.password;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
