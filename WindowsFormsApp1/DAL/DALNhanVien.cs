using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    class DALHangHoa
    {
        DataConnection dc;
        MySqlDataAdapter da;
        MySqlCommand cmd;
        public DALHangHoa()
        {
            dc = new DataConnection();
        }
        public DataTable getAllNhanVien()
        {
            // B1: Tạo truy vấn
            string sql = "SELECT * FROM tb_employee";
            // B2: Tạo kết nối  đến CSDL
            MySqlConnection con = dc.getConnection();
            // B3: Khởi tạo đối tượng lớp MySqlDataAdapter
            da = new MySqlDataAdapter(sql, con);
            // B4: Mở kết nối
            con.Open();
            // B5: Đổ dữ liệu từ MySqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            // B6: Đóng kết nối
            con.Close();
            return dt;
        }
        public bool insertNV(DTO.NhanVien nv)
        {
            string sql = "INSERT INTO tb_employee(name, phone, address,salaryperday) VALUES (@name, @phone, @address, @salaryperday)";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("name", MySqlDbType.VarChar).Value = nv.name;
                cmd.Parameters.Add("phone", MySqlDbType.VarChar).Value = nv.phone;
                cmd.Parameters.Add("address", MySqlDbType.VarChar).Value = nv.address;
                cmd.Parameters.Add("salaryperday", MySqlDbType.VarChar).Value = nv.salaryperday;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool updateNV(DTO.NhanVien nv)
        {
            string sql = "UPDATE tb_employee SET name=@name, phone=@phone, address=@address, salaryperday=@salaryperday WHERE id=@id";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = nv.id;
                cmd.Parameters.Add("name", MySqlDbType.VarChar).Value = nv.name;
                cmd.Parameters.Add("phone", MySqlDbType.VarChar).Value = nv.phone;
                cmd.Parameters.Add("address", MySqlDbType.VarChar).Value = nv.address;
                cmd.Parameters.Add("salaryperday", MySqlDbType.VarChar).Value = nv.salaryperday;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool deleteNV(DTO.NhanVien nv)
        {
            string sql = "DELETE FROM tb_employee WHERE id=@id";
            MySqlConnection con = dc.getConnection();
            try
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = nv.id;
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
