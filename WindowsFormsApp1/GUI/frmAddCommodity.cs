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
    public partial class frmAddCommodity : Form
    {
        public frmAddCommodity()
        {
            InitializeComponent();
        }

        

        private void frmAddCommodity_Load(object sender, EventArgs e)
        {

        }
        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Hide();
                new frmWarehouse().ShowDialog();
                this.Close();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            if (result == DialogResult.OK)
            {
                this.Hide();
                new frmWarehouse().ShowDialog();
                this.Close();
            }
        }
    }
}
