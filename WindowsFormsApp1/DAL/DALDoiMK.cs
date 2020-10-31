using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    class DALDoiMK
    {
        DataConnection dc;
        MySqlCommand cmd;
        public DALDoiMK()
        {
            dc = new DataConnection();
        }
        public bool updateMK(DTO.User admin)
        {
            string sql = "UPDATE tb_admin SET username=@username, password=@password WHERE id=@id";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = admin.id;
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
