using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Check
    {
        BLL.BLLDangNhap bll;
        public bool checkNullTextbox(String str)
        {
            if (str.Equals(""))
            {
                return false;
            }
            return true;
        }
        public bool IsNaturalNumber(String strNumber)
        {
            Regex objNotNaturalPattern = new Regex("[^0-9]");
            Regex objNaturalPattern = new Regex("0*[1-9][0-9]*");
            return !objNotNaturalPattern.IsMatch(strNumber) && objNaturalPattern.IsMatch(strNumber);
        }
        public bool numberPhone(String strPhone)
        {
            if(strPhone.Length == 10)
            {
                return true;
            }
            return false;
        }
        public String loadName()
        {
            bll = new BLL.BLLDangNhap();
            DataTable dt = new DataTable();
            dt = bll.registration();
            return dt.Rows[0].Field<String>("username").ToString();
        }
        public int loadID()
        {
            bll = new BLL.BLLDangNhap();
            DataTable dt = new DataTable();
            dt = bll.registration();
            return dt.Rows[0].Field<int>("id");
        }

    }
}
