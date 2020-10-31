using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        private string username = "";
        private string password = "";
        BLL.BLLDangNhap bll;
        public frmLogin()
        {
            InitializeComponent();
            bll = new BLL.BLLDangNhap();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //new frmSetup().ShowDialog();
            //this.Close();
            registration();
            reset();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text.Trim();
            password = txtPassword.Text.Trim();            
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
                if (bll.login(username, password))
                {
                    this.Hide();
                    new frmMain().ShowDialog();
                    this.Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Sai tài khoản hoặc mật khẩu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        reset();
                    }
                }
                //MessageBox.Show("" + bll.login(username,password));
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
        public void registration()
        {
            if (bll.registration().Rows.Count > 0)
            {
                llbRegistration.Text = "";
                lbQues.Text = "";
            }

        }
        public void reset()
        {
            lbNotice.Text = "";
        }

        private void llbRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmRegisTration().ShowDialog();
            this.Close();
        }
    }
}
