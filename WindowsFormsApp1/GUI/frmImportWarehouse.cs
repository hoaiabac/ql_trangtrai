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
    public partial class frmImportWarehouse : Form
    {
        BLL.BLLKho bll;
        Check ck;
        public frmImportWarehouse()
        {
            InitializeComponent();
            bll = new BLL.BLLKho();
            ck = new Check();
        }
        private void frmImportWarehouse_Load(object sender, EventArgs e)
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
            if (ck.checkNullTextbox(txtNumber.Text.ToString()) && ck.checkNullTextbox(txtUnitPrice.Text.ToString()))
            {
                DialogResult result1 = MessageBox.Show("Xác nhân nhập kho", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                if(result1 == DialogResult.Yes)
                {
                    DTO.NhapKho nk = new DTO.NhapKho();
                    nk.namecommodity = cbNameCommodity.Text;
                    nk.unitprice = int.Parse(txtUnitPrice.Text);
                    nk.number = int.Parse(txtNumber.Text);
                    nk.totalprice = (int.Parse(txtNumber.Text)*int.Parse(txtUnitPrice.Text));
                    DateTime tn = DateTime.Now;
                    nk.time = tn.ToString("yyyy-MM-dd HH:mm:ss");
                    //MessageBox.Show(nk.time, "");
                    bll.insertNK(nk);
                    resetTextbox();
                    DialogResult result2 = MessageBox.Show("Tiếp tục nhập kho", "Nhập kho thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if(result2 == DialogResult.No){
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


        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nhập kho thất bại.", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            if (result == DialogResult.OK)
            {
                this.Hide();
                new frmWarehouse().ShowDialog();
                this.Close();
            }
        }
        public void resetTextbox()
        {
            txtNumber.Clear();
            txtUnitPrice.Clear();
            cbNameCommodity.SelectedIndex = 0;
        }


    }
}
