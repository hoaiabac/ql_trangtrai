using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    class NhanVien
    {
        public int id_nv { set; get; }
        public string name { set; get; }
        public string phone { set; get; }
        public string address { set; get; }
        public int salaryperday { set; get; }
        public int numberpayday { set; get; }
        public int totalsalary { set; get; }
    }
}
