using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class frmRegisTration : Form
    {
        BLL.BLLDangKy bll;
        private string username;
        private string password;
        private string retypepassword;
        public frmRegisTration()
        {
            InitializeComponent();
            bll = new BLL.BLLDangKy();
        }

        private void frmRegisTration_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            lbError.Text = "";
        }

        private void btnRegisTration_Click(object sender, EventArgs e)
        {
            username = txtUserName.Text.Trim();
            password = txtPassWord.Text.Trim();
            retypepassword = txtRetypePass.Text.Trim();
            if (String.IsNullOrEmpty(username))
            {
                lbError.Text = "Tên tài khoản là trường bắt buộc!";
                txtUserName.Focus();
            }
            else if (String.IsNullOrEmpty(password))
            {
                lbError.Text = "Mật khẩu là trường bắt buộc!";
                txtPassWord.Focus();
            }
            else if (String.IsNullOrEmpty(retypepassword))
            {
                lbError.Text = "Nhập lại mật khẩu!";
                txtRetypePass.Focus();
            }else if (txtPassWord.Text.Equals(txtRetypePass.Text))
            {
                DTO.User admin = new DTO.User();
                admin.username = username;
                admin.password = password;
                bll.regisTration(admin);
                reset();
                DialogResult result = MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if(result == DialogResult.OK)
                {
                    this.Hide();
                    new frmLogin().ShowDialog();
                    this.Close();
                }
            }
            else
            {
                lbError.Text = "* Hai mật khẩu phải trùng nhau!";
            }
        }
        public void reset()
        {
            txtUserName.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
            this.Close();
        }
    }
}
