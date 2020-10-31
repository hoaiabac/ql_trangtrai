using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
    class BLLDangNhap
    {
        DAL.DALDangNhap daldn;

        public BLLDangNhap()
        {
            daldn = new DAL.DALDangNhap();
        }
        //public DataTable login(String str1, String str2)
        //{
        //    return daldn.login(str1, str2);
        //}
        public bool login(String str1, String str2)
        {
            DataTable dt = new DataTable();
            dt = daldn.login(str1, str2);
            if (dt.Rows.Count > 0)
            {
                if (str1 == dt.Rows[0].Field<String>("username").ToString())
                {
                    if (str2 == dt.Rows[0].Field<String>("password").ToString())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //public String login(String str1, String str2)
        //{
        //    DataTable dt = new DataTable();
        //    dt = daldn.login(str1, str2);
        //    return dt.Rows[0].Field<String>("password").ToString();
        //}
        public DataTable registration()
        {
            return daldn.registration();
        }
    }
}
