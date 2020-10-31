using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    class DALHang
    {
        DataConnection dc;
        MySqlDataAdapter da;
        MySqlCommand cmd;
        public DALHang()
        {
            dc = new DataConnection();
        }
        public DataTable getAllHang()
        {
            string sql = "SELECT * FROM tb_commodity";
            MySqlConnection con = dc.getConnection();
            da = new MySqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool insertHH(DTO.HangHoa hh)
        {
            string sql = "INSERT INTO tb_commodity(namecommodity, unit, distributor) VALUES (@namecommodity, @unit, @distributor)";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("namecommodity", MySqlDbType.VarChar).Value = hh.namecommodity;
                cmd.Parameters.Add("unit", MySqlDbType.VarChar).Value = hh.unit;
                cmd.Parameters.Add("distributor", MySqlDbType.VarChar).Value = hh.distributor;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool updateHH(DTO.HangHoa hh)
        {
            string sql = "UPDATE tb_commodity SET namecommodity=@namecommodity, unit=@unit, distributor=@distributor WHERE id_hh=@id";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = hh.id_hh;
                cmd.Parameters.Add("namecommodity", MySqlDbType.VarChar).Value = hh.namecommodity;
                cmd.Parameters.Add("unit", MySqlDbType.VarChar).Value = hh.unit;
                cmd.Parameters.Add("distributor", MySqlDbType.VarChar).Value = hh.distributor;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool deleteHH(DTO.HangHoa hh)
        {
            string sql = "DELETE FROM tb_commodity  WHERE id_hh=@id";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = hh.id_hh;
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
