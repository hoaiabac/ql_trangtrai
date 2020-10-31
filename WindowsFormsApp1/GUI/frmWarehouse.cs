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
        Check ck;
        public frmWarehouse()
        {
            InitializeComponent();
            bll = new BLL.BLLKho();
            ck = new Check();
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            lbName.Text = ck.loadName();
            dgvImportWarehouse.DataSource = bll.getAllNhapkho();
            dgvExportWarehouse.DataSource = bll.getAllXuatKho();
            reset();

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

       

        private void btnDeletrExport_Click(object sender, EventArgs e)
        {
            if (id1 != 0)
            {
                DialogResult result = MessageBox.Show("Xác nhân xóa thông tin xuất kho", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    DTO.XuatKho xk = new DTO.XuatKho();
                    xk.id_xk = id1;
                    bll.deleteXK(xk);
                    reset();
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
            int numrow;
            numrow = e.RowIndex;
            id1 = int.Parse(dgvExportWarehouse.Rows[numrow].Cells[0].Value.ToString());
            btnDeletrExport.Enabled = true;
            btnDeleteImport.Enabled = false;
        }
        private void dgvImportWarehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            id1 = int.Parse(dgvImportWarehouse.Rows[numrow].Cells[0].Value.ToString());
            btnDeleteImport.Enabled = true;
            btnDeletrExport.Enabled = false;
        }


        private void btnStatistical_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Chức năng đang phát triển.", "THÔNG BÁO");
        }
        public void reset()
        {
            id1 = 0;
            btnDeleteImport.Enabled = false;
            btnDeletrExport.Enabled = false;
        }

        private void btnDeleteImport_Click(object sender, EventArgs e)
        {
            if (id1 != 0)
            {
                DialogResult result = MessageBox.Show("Xác nhân xóa thông tin nhập kho", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    DTO.NhapKho nk = new DTO.NhapKho();
                    nk.id_nk = id1;
                    bll.deleteNK(nk);
                    reset();
                    dgvImportWarehouse.DataSource = bll.getAllNhapkho();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn thông tin nhập xóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvImportWarehouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
