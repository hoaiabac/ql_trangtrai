using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    class DALKho
    {
        DAL.DALKho dalk;
        
        DataConnection dc;
        MySqlDataAdapter da;
        MySqlCommand cmd;
        public DALKho()
        {
            dc = new DataConnection();
        }
        public DataTable getAllKho()
        {
            string sql = "SELECT * FROM tb_warehouse";
            MySqlConnection con = dc.getConnection();
            da = new MySqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getAllKho1()
        {
            string sql = "SELECT namecommodity, number FROM tb_warehouse";
            MySqlConnection con = dc.getConnection();
            da = new MySqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool updateWarehouse(DTO.Kho kho)
        {
            string sql = "UPDATE tb_warehouse SET number=@number WHERE id_hh=@id";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = kho.id_hh;
                cmd.Parameters.Add("number", MySqlDbType.VarChar).Value = kho.number;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool insertWarehouse(DTO.Kho kho)
        {
            string sql = "INSERT INTO tb_warehouse(id_hh, namecommodity, number) VALUES (@id_hh, @namecommodity, @number)";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("id_hh", MySqlDbType.VarChar).Value = kho.id_hh;
                cmd.Parameters.Add("namecommodity", MySqlDbType.VarChar).Value = kho.namecommodity;
                cmd.Parameters.Add("number", MySqlDbType.VarChar).Value = kho.number;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public DataTable getAllNhapKho()
        {
            string sql = "SELECT id_nk, namecommodity, unitprice, number, totalprice, time  FROM tb_importwarehouse";
            MySqlConnection con = dc.getConnection();
            da = new MySqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable getAllXuatKho()
        {
            string sql = "SELECT id_xk, namecommodity, number,time FROM tb_exportwarehouse";
            MySqlConnection con = dc.getConnection();
            da = new MySqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool insertNK(DTO.NhapKho nk)
        {
            string sql = "INSERT INTO tb_importwarehouse(id_hh, namecommodity, unitprice, number,totalprice,time) VALUES (@id_hh, @namecommodity, @unitprice, @number, @totalprice,@time)";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("id_hh", MySqlDbType.VarChar).Value = nk.id_hh;
                cmd.Parameters.Add("namecommodity", MySqlDbType.VarChar).Value = nk.namecommodity;
                cmd.Parameters.Add("unitprice", MySqlDbType.VarChar).Value = nk.unitprice;
                cmd.Parameters.Add("number", MySqlDbType.VarChar).Value = nk.number;
                cmd.Parameters.Add("totalprice", MySqlDbType.VarChar).Value = nk.totalprice;
                cmd.Parameters.Add("time", MySqlDbType.VarChar).Value = nk.time;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool insertXK(DTO.XuatKho xk)
        {
            string sql = "INSERT INTO tb_exportwarehouse(id_hh, namecommodity,number,time) VALUES (@id_hh,@namecommodity,@number,@time)";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("id_hh", MySqlDbType.VarChar).Value = xk.id_hh;
                cmd.Parameters.Add("namecommodity", MySqlDbType.VarChar).Value = xk.namecommodity;
                cmd.Parameters.Add("number", MySqlDbType.VarChar).Value = xk.number;
                cmd.Parameters.Add("time", MySqlDbType.VarChar).Value = xk.time;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool deleteNK(DTO.NhapKho nk)
        {
            string sql = "DELETE FROM tb_importwarehouse WHERE id_nk=@id";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = nk.id_nk;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public bool deleteXK(DTO.XuatKho xk)
        {
            string sql = "DELETE FROM tb_exportwarehouse WHERE id_xk=@id";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = xk.id_xk;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public DataTable loadComboBox(String str1, String str2, String str3)
        {
            string sql = "SELECT " + str3 + "," + str1 + " FROM " + str2;
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
