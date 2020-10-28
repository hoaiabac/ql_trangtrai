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
    public partial class frmWarehouse : Form
    {
        BLL.BLLKho bll;
        int id1 = 0;
        public frmWarehouse()
        {
            InitializeComponent();
            bll = new BLL.BLLKho();
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            dgvImportWarehouse.DataSource = bll.getAllNhapkho();
            dgvExportWarehouse.DataSource = bll.getAllXuatKho();

        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain().ShowDialog();
            this.Close();
        }

        private void btnListCommodity_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmListCommodity().ShowDialog();
            this.Close();
        }


        private void btnImportWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmImportWarehouse().ShowDialog();
            this.Close();
        }

        private void btnOutWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmExportWarehouse().ShowDialog();
            this.Close();
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDeleteCommodity_Click(object sender, EventArgs e)
        {
            if (id1 != 0)
            {
                DialogResult result = MessageBox.Show("Xác nhân xóa thông tin nhập kho", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    DTO.NhapKho nk = new DTO.NhapKho();
                    nk.id = id1;
                    bll.deleteNK(nk);
                    id1 = 0;
                    dgvImportWarehouse.DataSource = bll.getAllNhapkho();
                }
                else
                {
                    MessageBox.Show("Hủy xóa thông tin nhập kho", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn thông tin cần xóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvImportWarehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id1 = int.Parse(dgvImportWarehouse.CurrentRow.Cells[0].Value.ToString());
        }

        private void btDeletrExport_Click(object sender, EventArgs e)
        {
            if (id1 != 0)
            {
                DialogResult result = MessageBox.Show("Xác nhân xóa thông tin xuất kho", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    DTO.XuatKho xk = new DTO.XuatKho();
                    xk.id = id1;
                    bll.deleteXK(xk);
                    id1 = 0;
                    dgvExportWarehouse.DataSource = bll.getAllXuatKho();
                }
                else
                {
                    MessageBox.Show("Hủy xóa thông tin xuất kho", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn thông tin cần xóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvExportWarehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id1 = int.Parse(dgvExportWarehouse.CurrentRow.Cells[0].Value.ToString());
        }

        private void dgvImportWarehouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
