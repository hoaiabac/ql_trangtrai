using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
    class BLLHangHoa
    {
        DAL.DALHang dalh;
        public BLLHangHoa()
        {
            dalh = new DAL.DALHang();
        }
        public DataTable getAllHang()
        {
            return dalh.getAllHang();
        }
        public bool insertHH(DTO.HangHoa hh)
        {
            return dalh.insertHH(hh);
        }
        public bool updateHH(DTO.HangHoa hh)
        {
            return dalh.updateHH(hh);
        }
        public bool deleteHH(DTO.HangHoa hh)
        {
            return dalh.deleteHH(hh);
        }
    }
}
