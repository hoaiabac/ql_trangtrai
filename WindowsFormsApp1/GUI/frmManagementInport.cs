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
    public partial class frmManagementInport : Form
    {
        Check ck;
        BLL.BLLKho bll;
        int id1 = 0;
        public frmManagementInport()
        {
            InitializeComponent();
            ck = new Check();
            bll = new BLL.BLLKho();
        }

        private void frmManagementInport_Load(object sender, EventArgs e)
        {
            lbName.Text = ck.loadName();
            dgvImportWarehouse.DataSource = bll.getAllNhapkho();
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
            this.Close();
        }
        private void dgvImportWarehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            id1 = int.Parse(dgvImportWarehouse.Rows[numrow].Cells[0].Value.ToString());
            btnDeleteImport.Enabled = true;
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

        private void btnImportWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmImportWarehouse().ShowDialog();
            this.Close();
        }
        public void reset()
        {
            id1 = 0;
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmWarehouse().ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain().ShowDialog();
            this.Close();
        }
    }
}
