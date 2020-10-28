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
    public partial class frmSalary2 : Form
    {
        BLL.BLLLuong bll;
        int id1;
        public frmSalary2()
        {
            InitializeComponent();
            bll = new BLL.BLLLuong();
            id1 = 0;
        }

        private void frmSalary2_Load(object sender, EventArgs e)
        {
            dgvSalary.DataSource = bll.getAllluong();
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

        private void btnSalaryClosing_Click(object sender, EventArgs e)
        {
            if (id1 != 0)
            {
                DTO.NhanVien nv = new DTO.NhanVien();
                nv.id = id1;
                nv.salaryperday = int.Parse(txtSalaryPerDay.Text.ToString());
                nv.numberpayday = int.Parse(nudNumberPayDay.Value.ToString());
                nv.totalsalary = (nv.salaryperday * nv.numberpayday);
                bll.updateLuong(nv);
                dgvSalary.DataSource = bll.getAllluong();
                resetTextbox();
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên cần sửa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //
            //

            int numrow;
            numrow = e.RowIndex;
            id1 = int.Parse(dgvSalary.Rows[numrow].Cells[0].Value.ToString());
            txtName.Text = dgvSalary.Rows[numrow].Cells[1].Value.ToString();
            txtSalaryPerDay.Text = dgvSalary.Rows[numrow].Cells[2].Value.ToString();
        }

        private void dgvSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void resetTextbox()
        {
            txtName.Clear();
            txtSalaryPerDay.Clear();
        }
    }
}
