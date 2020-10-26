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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }


        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                this.Hide();
                new frmEmployee().ShowDialog();
                this.Close();
            }
           
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            if (result == DialogResult.OK)
            {
                this.Hide();
                new frmEmployee().ShowDialog();
                this.Close();
            }
        }
    }
}
