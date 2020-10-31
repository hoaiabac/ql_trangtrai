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
    public partial class frmManagementExport : Form
    {
        Check ck;
        BLL.BLLKho bll;
        int id1 = 0;
        public frmManagementExport()
        {
            InitializeComponent();
            ck = new Check();
            bll = new BLL.BLLKho();
        }
        private void frmManagementExport_Load(object sender, EventArgs e)
        {
            lbName.Text = ck.loadName();
            dgvExportWarehouse.DataSource = bll.getAllXuatKho();
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
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
        }
        private void btnOutWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmExportWarehouse().ShowDialog();
            this.Close();
        }
        public void reset()
        {
            id1 = 0;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain().ShowDialog();
            this.Close();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmWarehouse().ShowDialog();
            this.Close();
        }
    }
}
