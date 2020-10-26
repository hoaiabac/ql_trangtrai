using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        private string username = "";
        private string password = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text.ToLower().Trim();//lay username chuyen het ve ky tu thuong,cat khoang trang dau cuoi
            password = txtPassword.Text.Trim();// lay password, cat khoang trang dau cuoi;
            if (String.IsNullOrEmpty(username))
            {
                lbNotice.Text = "Tên tài khoản là trường bắt buộc!";
                txtUsername.Focus();
            }
            else if (String.IsNullOrEmpty(password))
            {
                lbNotice.Text = "Mật khẩu là trường bắt buộc!";
                txtPassword.Focus();
            }
            else
            {
                if (username == "admin" && password == "123")
                {
                    this.Hide(); // an man hinh hien tai
                    new frmMain().ShowDialog(); // hien thi man hinh moi
                    this.Close(); // dong man hinh cu
                }
                else
                {
                    lbNotice.Text = "Tài khoản không chính xác!";
                    txtUsername.Focus();
                }
            }

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_DoubleClick(object sender, EventArgs e)
        {
            txtUsername.SelectAll();
        }

        private void txtPassword_DoubleClick(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }
    }
}
