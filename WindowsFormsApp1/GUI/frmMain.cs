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
    public partial class frmMain : Form
    {
        Check ck;
        public frmMain()
        {
            InitializeComponent();
            ck = new Check();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbName.Text = ck.loadName();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmEmployee().ShowDialog();
            this.Close();
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
            this.Close();
        }

        private void lbName_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GUI.frmSalary2().ShowDialog();
            this.Close();
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmWarehouse().ShowDialog();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSetup().ShowDialog();
            this.Close();
        }
    }
}
