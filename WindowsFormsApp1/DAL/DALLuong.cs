using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    class DALLuong
    {
        DataConnection dc;
        MySqlDataAdapter da;
        MySqlCommand cmd;
        public DALLuong()
        {
            dc = new DataConnection();
        }
        public DataTable getAllLuong()
        {
            string sql = "SELECT id_nv, name, salaryperday,numberpayday,totalsalary FROM tb_employee";
            //string sql = "SELECT * FROM tb_employee";
            MySqlConnection con = dc.getConnection();
            da = new MySqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool updateLuong(DTO.NhanVien nv)
        {
            string sql = "UPDATE tb_employee SET numberpayday=@numberpayday, totalsalary=@totalsalary WHERE id_nv=@id";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = nv.id_nv;
                cmd.Parameters.Add("numberpayday", MySqlDbType.VarChar).Value = nv.numberpayday;
                cmd.Parameters.Add("totalsalary", MySqlDbType.VarChar).Value = nv.totalsalary;
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
