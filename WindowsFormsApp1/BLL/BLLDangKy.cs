using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
    class BLLDangKy
    {
        DAL.DALDangKy daldk;
        public BLLDangKy()
        {
            daldk = new DAL.DALDangKy();
        }
        public bool regisTration(DTO.User admin)
        {
            return daldk.regisTration(admin);
        }
    }
}
