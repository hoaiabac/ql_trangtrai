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
            cbNameCommodity.Focus();
            lbName.Text = ck.loadName();
            cbNameCommodity.DataSource = bll.loadComboBox2();
            cbNameCommodity.ValueMember = "id_hh";
            cbNameCommodity.DisplayMember = "namecommodity";
            reset();
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
                    nk.id_hh = int.Parse(cbNameCommodity.SelectedValue.ToString());
                    nk.namecommodity = cbNameCommodity.Text;
                    nk.unitprice = int.Parse(txtUnitPrice.Text);
                    nk.number = int.Parse(txtNumber.Text);
                    nk.totalprice = (int.Parse(txtNumber.Text)*int.Parse(txtUnitPrice.Text));
                    DateTime tn = DateTime.Now;
                    nk.time = tn.ToString("yyyy-MM-dd HH:mm:ss");
                    bll.insertNK(nk);
                    if(bll.getNumber(nk.id_hh) == 0)
                    {
                        DTO.Kho kho = new DTO.Kho();
                        kho.id_hh = int.Parse(cbNameCommodity.SelectedValue.ToString());
                        kho.namecommodity = cbNameCommodity.Text;
                        kho.number = int.Parse(txtNumber.Text);
                        bll.insertWarehouse(kho);
                        reset();
                    }
                    else
                    {
                        DTO.Kho kho = new DTO.Kho();
                        kho.id_hh = int.Parse(cbNameCommodity.SelectedValue.ToString());
                        kho.number = (bll.getNumber(int.Parse(cbNameCommodity.SelectedValue.ToString())) + int.Parse(txtNumber.Text));
                        bll.updateWarehouse(kho);
                        reset();
                    }    
                }
                else
                {
                    MessageBox.Show("Hủy nhập kho", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reset();
                }   
            }
            else
            {
                lbErrorTotal.Text = "Thông tin bắt buộc!";
                lbErrorNumber.Text = "Thông tin bắt buộc!";
            }
        }


        private void btnNo_Click(object sender, EventArgs e)
        {
            if (ck.checkNullTextbox(txtNumber.Text.ToString()) || ck.checkNullTextbox(txtUnitPrice.Text.ToString()))
            {
                DialogResult result = MessageBox.Show("Xác nhận hủy nhập kho.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    new frmManagementInport().ShowDialog();
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                new frmManagementInport().ShowDialog();
                this.Close();
            }
             
        }
        public void reset()
        {
            txtNumber.Clear();
            txtUnitPrice.Clear();
            cbNameCommodity.SelectedIndex = 0;
            lbErrorNumber.Text = "";
            lbErrorTotal.Text = "";
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
