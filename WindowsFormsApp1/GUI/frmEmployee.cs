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
    public partial class frmEmployee : Form
    {
        BLL.BLLNhanVien bll;
        int id=0;
        Check ck;
        public frmEmployee()
        {
            InitializeComponent();
            bll = new BLL.BLLNhanVien();
            ck = new Check();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            dgvListEmployee.DataSource = bll.getAllNhanVien();
            cbSalaryPerDay.SelectedIndex = 0;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(ck.checkNullTextbox(txtName.Text.ToString()) && ck.checkNullTextbox(txtAddress.Text.ToString()) && ck.checkNullTextbox(txtPhone.Text.ToString()))
            {
                if(ck.IsNaturalNumber(txtPhone.Text.ToString())){
                    DTO.NhanVien nv = new DTO.NhanVien();
                    nv.name = txtName.Text;
                    nv.phone = txtPhone.Text;
                    nv.address = txtAddress.Text;
                    nv.salaryperday = int.Parse(cbSalaryPerDay.Text);
                    bll.insertNV(nv);
                    resetTextbox();
                    loadDgv();
                }
                else
                {
                    lbError.Text = "Định dạng phải là số!";
                    lbError.ForeColor = Color.Red;
                }   
            }
            else
            {
                MessageBox.Show("Thiếu thông tin nhân viên","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void pnListUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(id != 0)
            {
                if (ck.checkNullTextbox(txtName.Text.ToString()) && ck.checkNullTextbox(txtAddress.Text.ToString()) && ck.checkNullTextbox(txtPhone.Text.ToString()))
                {
                    DTO.NhanVien nv = new DTO.NhanVien();
                    nv.id = id;
                    nv.name = txtName.Text;
                    nv.address = txtAddress.Text;
                    nv.phone = txtPhone.Text;
                    nv.salaryperday = int.Parse(cbSalaryPerDay.Text);
                    bll.updateNV(nv);
                    loadDgv();
                    resetTextbox();
                }
                else
                {
                    MessageBox.Show("Thiếu thông tin nhân viên", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên cần sửa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void dgvListEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtName.Text = dgvListEmployee.CurrentRow.Cells[1].Value.ToString();
            //txtPhone.Text = dgvListEmployee.CurrentRow.Cells[2].Value.ToString();
            //txtAddress.Text = dgvListEmployee.CurrentRow.Cells[3].Value.ToString();
            //cbSalaryPerDay.Text = dgvListEmployee.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvListEmployee.CurrentRow.Cells[0].Value.ToString());
            txtName.Text = dgvListEmployee.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = dgvListEmployee.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = dgvListEmployee.CurrentRow.Cells[3].Value.ToString();
            cbSalaryPerDay.Text = dgvListEmployee.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDetele_Click(object sender, EventArgs e)
        {
            if(id != 0)
            {
                DialogResult result = MessageBox.Show("Xác nhân xóa nhân viên", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    DTO.NhanVien nv = new DTO.NhanVien();
                    nv.id = id;
                    bll.deleteNV(nv);
                    loadDgv();
                    resetTextbox();
                }
                else
                {
                    MessageBox.Show("Hủy xóa nhân viên", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên cần xóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }
        public void resetTextbox()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            cbSalaryPerDay.SelectedIndex = 0;
            id = 0;
            lbError.Text = "";
        }
        public void loadDgv()
        {
            dgvListEmployee.DataSource = bll.getAllNhanVien();
        }

        //private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
