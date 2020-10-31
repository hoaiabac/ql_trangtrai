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
        public DataTable getAllkho()
        {
            return dalk.getAllKho();
        }
        public DataTable getAllkho1()
        {
            return dalk.getAllKho1();
        }
        public int getNumber(int n)
        {
            DataTable dt = new DataTable();
            dt = dalk.getAllKho();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].Field<int>("id_hh") == n)
                {
                    return dt.Rows[i].Field<int>("number");
                }
            }
            return 0;
        }
        public bool updateWarehouse(DTO.Kho kho)
        {
            return dalk.updateWarehouse(kho);
        }
        public bool insertWarehouse(DTO.Kho kho)
        {
            return dalk.insertWarehouse(kho);
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
            return dalk.loadComboBox("namecommodity", "tb_warehouse", "id_hh");
        }
        public DataTable loadComboBox2()
        {
            return dalk.loadComboBox("namecommodity", "tb_commodity", "id_hh");
        }
    }
}
