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
            cbNameCommodity.Focus();
            lbName.Text = ck.loadName();
            cbNameCommodity.DataSource = bll.loadComboBox();
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
            if (ck.checkNullTextbox(txtNumber.Text.ToString()))
            {
                if (int.Parse(txtNumber.Text) <= bll.getNumber(int.Parse(cbNameCommodity.SelectedValue.ToString())))
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
                        DTO.Kho kho = new DTO.Kho();
                        //MessageBox.Show("" + (bll.getNumber(int.Parse(cbNameCommodity.SelectedValue.ToString()))-int.Parse(txtNumber.Text)));
                        kho.id_hh = int.Parse(cbNameCommodity.SelectedValue.ToString());
                        kho.number = (bll.getNumber(int.Parse(cbNameCommodity.SelectedValue.ToString())) - int.Parse(txtNumber.Text));
                        bll.updateWarehouse(kho);
                        reset();
                    }
                    else
                    {
                        reset();
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng hàng hóa trong kho không đủ");
                }
            }
            else
            {
                lbErrorNumber.Text = "Thông tin bắt buộc!";
            }   
        }
        private void reset()
        {
            cbNameCommodity.SelectedIndex = 0;
            txtNumber.Clear();
            lbErrorNumber.Text = "";
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (ck.checkNullTextbox(txtNumber.Text.ToString()))
            {
                DialogResult result = MessageBox.Show("Xác nhân hủy xuất kho.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    new frmManagementExport().ShowDialog();
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                new frmManagementExport().ShowDialog();
                this.Close();
            }
             
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
