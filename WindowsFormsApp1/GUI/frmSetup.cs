using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1.GUI
{
    public partial class frmSetup : Form
    {
        Check ck;
        BLLDoiMK bll;
        int id;
        public frmSetup()
        {
            InitializeComponent();
            ck = new Check();
            bll = new BLLDoiMK();
        }

        private void frmSetup_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtUsername.Text = ck.loadName();
            reset();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtPassOld.Text.Trim()) || String.IsNullOrEmpty(txtPassNew.Text.Trim()) || String.IsNullOrEmpty(txtPassRetype.Text.Trim()))
            {
                lbErrorPassOld.Text = "*";
                lbErrorPassNew.Text = "*";
                lbErrorPassRetype.Text = "*";
                label5.Visible = true;
                label6.Visible = true;
            }
            else
            {
                if (bll.checkPasswordOld(txtPassOld.Text.ToString()))
                {
                    lbErrorPassOld.Text = "ok";
                    lbErrorPassOld.ForeColor = Color.Green;
                    if(txtPassOld.Text != txtPassNew.Text)
                    {
                        if (txtPassNew.Text == txtPassRetype.Text)
                        {

                            DTO.User admin = new DTO.User();
                            admin.id = ck.loadID();
                            admin.password = txtPassNew.Text.ToString();
                            admin.username = txtUsername.Text.ToString();
                            bll.updateMK(admin);
                            DialogResult result = MessageBox.Show("Đổi mật khẩu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            if (result == DialogResult.OK)
                            {
                                this.Hide();
                                new frmLogin().ShowDialog();
                                this.Close();
                            }
                        }
                        else
                        {
                            lbErrorPassNew.Text = "";
                            lbErrorPassRetype.Text = "Hai mật khẩu phải trùng nhau!";
                        }

                    }
                    else
                    {
                        lbErrorPassNew.Text = "Bạn nhập mật khẩu cũ!";
                    }
                    
                }
                else
                {
                    lbErrorPassOld.Text = "Không trùng mật khẩu cũ!";
                }
            }
            
        }
        public void reset()
        {
            lbErrorName.Text = "";
            lbErrorPassOld.Text = "";
            lbErrorPassNew.Text = "";
            lbErrorPassRetype.Text = "";
            label5.Visible = false;
            label6.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain().ShowDialog();
            this.Close();
        }
    }
}
