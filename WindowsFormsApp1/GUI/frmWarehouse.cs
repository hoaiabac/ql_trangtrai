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
    public partial class frmWarehouse : Form
    {
        BLL.BLLKho bll;
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
            dgvWarehouse.DataSource = bll.getAllkho1();
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

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Chức năng đang phát triển.", "THÔNG BÁO");
        }
        private void dgvImportWarehouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmManagementInport().ShowDialog();
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmManagementExport().ShowDialog();
            this.Close();
        }

        private void dgvWarehouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
