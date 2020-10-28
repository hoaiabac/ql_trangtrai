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
    public partial class frmExportWarehouse : Form
    {
        BLL.BLLKho bll;
        Check ck;
        public frmExportWarehouse()
        {
            InitializeComponent();
            bll = new BLL.BLLKho();
            ck = new Check();
        }

        private void frmOutWarehouse_Load(object sender, EventArgs e)
        {
            cbNameCommodity.DataSource = bll.loadComboBox();
            cbNameCommodity.ValueMember = "namecommodity";
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (ck.checkNullTextbox(txtNumber.Text.ToString()))
            {
                DialogResult result1 = MessageBox.Show("Xác nhân xuất kho", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result1 == DialogResult.Yes)
                {
                    DTO.XuatKho xk = new DTO.XuatKho();
                    xk.namecommodity = cbNameCommodity.Text;
                    xk.number = int.Parse(txtNumber.Text);
                    DateTime tn = DateTime.Now;
                    xk.time = tn.ToString("yyyy-MM-dd HH:mm:ss");
                    bll.insertXK(xk);
                    resetTextbox();
                    DialogResult result2 = MessageBox.Show("Tiếp tục nhập kho", "Nhập kho thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (result2 == DialogResult.No)
                    {
                        this.Hide();
                        new frmWarehouse().ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        resetTextbox();
                    }

                }
                else
                {
                    MessageBox.Show("Hủy nhập kho", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    resetTextbox();
                }
            }
            else
            {
                MessageBox.Show("Thiếu thông tin hàng hóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resetTextbox()
        {
            cbNameCommodity.SelectedIndex = 0;
            txtNumber.Clear();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xuất thất bại.", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            if (result == DialogResult.OK)
            {
                this.Hide();
                new frmWarehouse().ShowDialog();
                this.Close();
            }
        }
    }
}
