using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
    class BLLDoiMK
    {
        DAL.DALDoiMK daldmk;
        DAL.DALDangNhap daldn;
        public BLLDoiMK()
        {
            daldmk = new DAL.DALDoiMK();
            daldn = new DAL.DALDangNhap();
        }
        public bool checkPasswordOld(String passwordold)
        {
            DataTable dt = new DataTable();
            dt = daldn.registration();
            if (passwordold == dt.Rows[0].Field<String>("password"))
            {
                return true;
            }
            return false;
        }
        public bool updateMK(DTO.User admin)
        {
            return daldmk.updateMK(admin);
        }
    }
    
}
