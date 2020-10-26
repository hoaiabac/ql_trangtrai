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
        public frmWarehouse()
        {
            InitializeComponent();
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {

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

        private void btnAddSpeciesCommodity_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAddCommodity().ShowDialog();
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
            new frmOutWarehouse().ShowDialog();
            this.Close();
        }
    }
}
