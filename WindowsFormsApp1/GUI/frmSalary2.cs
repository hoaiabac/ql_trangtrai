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
        Check ck;
        public frmSalary2()
        {
            InitializeComponent();
            bll = new BLL.BLLLuong();
            id1 = 0;
            ck = new Check();
        }

        private void frmSalary2_Load(object sender, EventArgs e)
        {
            cbSalaryPerDay.Focus();
            lbName.Text = ck.loadName();
            dgvSalary.DataSource = bll.getAllluong();
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

        private void btnSalaryClosing_Click(object sender, EventArgs e)
        {
            if (id1 != 0)
            {
                DTO.NhanVien nv = new DTO.NhanVien();
                nv.id_nv = id1;
                nv.salaryperday = int.Parse(cbSalaryPerDay.Text.ToString());
                nv.numberpayday = int.Parse(nudNumberPayDay.Value.ToString());
                nv.totalsalary = (nv.salaryperday * nv.numberpayday);
                bll.updateLuong(nv);
                dgvSalary.DataSource = bll.getAllluong();
                reset();
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên cần sửa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSalaryClosing.Enabled = true;
            btnStatistical.Enabled = false;
            int numrow;
            numrow = e.RowIndex;
            id1 = int.Parse(dgvSalary.Rows[numrow].Cells[0].Value.ToString());
            LbNameEmployee.Text = dgvSalary.Rows[numrow].Cells[1].Value.ToString();
            cbSalaryPerDay.Text = dgvSalary.Rows[numrow].Cells[2].Value.ToString();
            nudNumberPayDay.Value = int.Parse(dgvSalary.Rows[numrow].Cells[3].Value.ToString());
        }

        private void dgvSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void reset()
        {
            LbNameEmployee.Text = "";
            cbSalaryPerDay.SelectedIndex = 0;
            btnSalaryClosing.Enabled = false;
            nudNumberPayDay.Value = 0;
            btnStatistical.Enabled = true;
            
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Chức năng đang phát triển.", "THÔNG BÁO");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (LbNameEmployee.Text != "")
            {
                DialogResult result = MessageBox.Show("Hủy tác vụ đang thao tác.", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    reset();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
