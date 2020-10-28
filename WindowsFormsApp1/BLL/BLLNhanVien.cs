using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    class BLLNhanVien
    {
        DAL.DALHangHoa dalnv;
        public BLLNhanVien()
        {
            dalnv = new DALHangHoa();
        }
        public DataTable getAllNhanVien()
        {
            return dalnv.getAllNhanVien();
        }

        public bool insertNV(DTO.NhanVien nv)
        {
            return dalnv.insertNV(nv);
        }
        public bool updateNV(DTO.NhanVien nv)
        {
            return dalnv.updateNV(nv);
        }
        public bool deleteNV(DTO.NhanVien nv)
        {
            return dalnv.deleteNV(nv);
        }
    }
}
