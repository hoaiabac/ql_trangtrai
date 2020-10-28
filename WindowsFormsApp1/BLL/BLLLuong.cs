using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    class BLLLuong
    {
        DALLuong dalluong;
        public BLLLuong()
        {
            dalluong = new DALLuong();
        }
        public DataTable getAllluong()
        {
            return dalluong.getAllLuong();
        }
        public bool updateLuong(DTO.NhanVien nv)
        {
            return dalluong.updateLuong(nv);
        }
    }
}
