using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
    class BLLKho
    {
        DAL.DALKho dalk;
        public BLLKho()
        {
            dalk = new DAL.DALKho();
        }
        public DataTable getAllNhapkho()
        {
            return dalk.getAllNhapKho();
        }
        public DataTable getAllXuatKho()
        {
            return dalk.getAllXuatKho();
        }
        public bool insertNK(DTO.NhapKho nk)
        {
            return dalk.insertNK(nk);
        }
        public bool insertXK(DTO.XuatKho xk)
        {
            return dalk.insertXK(xk);
        }
        public bool deleteNK(DTO.NhapKho nk)
        {
            return dalk.deleteNK(nk);
        }
        public bool deleteXK(DTO.XuatKho xk)
        {
            return dalk.deleteXK(xk);
        }
        public DataTable loadComboBox()
        {
            return dalk.loadComboBox("namecommodity", "tb_commodity");
        }
    }
}
