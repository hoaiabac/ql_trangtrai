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
            txtName.Focus();
            lbName.Text = ck.loadName();
            dgvListEmployee.DataSource = bll.getAllNhanVien();
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


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtPhone.Text) || String.IsNullOrEmpty(txtAddress.Text))
            {
                if (ck.numberPhone(txtPhone.Text.ToString()))
                {
                    if (ck.IsNaturalNumber(txtPhone.Text.ToString()))
                    {
                        DialogResult result = MessageBox.Show("Xác nhận thay đổi thông tin nhân viên.", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                        if(result == DialogResult.Yes)
                        {
                            DTO.NhanVien nv = new DTO.NhanVien();
                            nv.id_nv = id;
                            nv.name = txtName.Text;
                            nv.address = txtAddress.Text;
                            nv.phone = txtPhone.Text;
                            nv.salaryperday = int.Parse(cbSalaryPerDay.Text);
                            bll.updateNV(nv);
                            loadDgv();
                            reset();
                        }
                    }
                    else
                    {
                        lbErrorPhone.Text = "Định dạng phải là số!";
                    }
                }
                else
                {
                    lbErrorPhone.Text = "Số điện thoại không đủ!";
                }

            }
            else
            {
                MessageBox.Show("Thiếu thông tin nhân viên", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddEmployee.Enabled = false;
            btnUpdate.Enabled = true;
            btnDetele.Enabled = true;
            int numrow;
            numrow = e.RowIndex;
            id = int.Parse(dgvListEmployee.Rows[numrow].Cells[0].Value.ToString());
            //id = int.Parse(dgvListEmployee.CurrentRow.Cells[0].Value.ToString());
            //MessageBox.Show(""+ dgvListEmployee.CurrentRow.Cells[0].Value.ToString());
            txtName.Text = dgvListEmployee.Rows[numrow].Cells[1].Value.ToString();
            txtPhone.Text = dgvListEmployee.Rows[numrow].Cells[2].Value.ToString();
            txtAddress.Text = dgvListEmployee.Rows[numrow].Cells[3].Value.ToString();
            cbSalaryPerDay.Text = dgvListEmployee.Rows[numrow].Cells[4].Value.ToString();
        }

        private void btnDetele_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa nhân viên", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                DTO.NhanVien nv = new DTO.NhanVien();
                nv.id_nv = id;
                bll.deleteNV(nv);
                loadDgv();
                reset();
            }
            else
            {
                MessageBox.Show("Hủy xóa nhân viên", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void reset()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            id = 0;
            cbSalaryPerDay.SelectedIndex = 0;
            txtPhone.MaxLength = 10;
            lbErrorName.Text = "";
            lbErrorPhone.Text = "";
            lbErrorAddress.Text = "";
            btnAddEmployee.Enabled = true;
            btnUpdate.Enabled = false;
            btnDetele.Enabled = false;
        }
        public void loadDgv()
        {
            dgvListEmployee.DataSource = bll.getAllNhanVien();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ck.checkNullTextbox(txtName.Text.ToString()) || ck.checkNullTextbox(txtPhone.Text.ToString()) || ck.checkNullTextbox(txtAddress.Text.ToString()))
            {
                DialogResult result = MessageBox.Show("Hủy tác vụ đang thao tác.", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    reset();
                }
            }
                       
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (ck.checkNullTextbox(txtName.Text.ToString()) && ck.checkNullTextbox(txtAddress.Text.ToString()) && ck.checkNullTextbox(txtPhone.Text.ToString()))
            {

                if (ck.numberPhone(txtPhone.Text.ToString()))
                {
                    if (ck.IsNaturalNumber(txtPhone.Text.ToString()))
                    {
                        DTO.NhanVien nv = new DTO.NhanVien();
                        nv.name = txtName.Text;
                        nv.phone = txtPhone.Text;
                        nv.address = txtAddress.Text;
                        nv.salaryperday = int.Parse(cbSalaryPerDay.Text);
                        bll.insertNV(nv);
                        reset();
                        loadDgv();
                    }
                    else
                    {
                        lbErrorPhone.Text = "Định dạng phải là số!";
                    }
                }
                else
                {
                    lbErrorPhone.Text = "Số điện thoại không đủ!";
                }
            }
            else
            {
                lbErrorName.Text = "Thông tin bắt buộc!";
                lbErrorPhone.Text = "Thông tin bắt buộc!";
                lbErrorAddress.Text = "Thông tin bắt buộc!";
            }
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
