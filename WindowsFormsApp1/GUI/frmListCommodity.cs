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
    public partial class frmListCommodity : Form
    {
        BLL.BLLHangHoa bll;
        Check ck;
        int id1=0;
        public frmListCommodity()
        {
            InitializeComponent();
            bll = new BLL.BLLHangHoa();
            ck = new Check();
        }
        public void loadDgv()
        {
            dgvListCommodity.DataSource = bll.getAllHang();
        }
        private void frmListCommodity_Load(object sender, EventArgs e)
        {
            txtNameCommodity.Focus();
            lbName1.Text = ck.loadName();
            loadDgv();
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

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmWarehouse().ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddSpeciesCommodity_Click(object sender, EventArgs e)
        {
            if (ck.checkNullTextbox(txtNameCommodity.Text.ToString()) && ck.checkNullTextbox(txtDistributor.Text.ToString()))
            {
                DTO.HangHoa hh = new DTO.HangHoa();
                hh.namecommodity = txtNameCommodity.Text;
                hh.distributor = txtDistributor.Text;
                hh.unit = cbUnit.Text;
                bll.insertHH(hh);
                reset();
                loadDgv();
            }
            else
            {
                MessageBox.Show("Thiếu thông tin nhân viên", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void reset()
        {
            txtNameCommodity.Clear();
            txtDistributor.Clear();
            cbUnit.SelectedIndex = 0;
            btnAddSpeciesCommodity.Enabled = true;
            btnUpdateSpeciesCommodity.Enabled = false;
            btnDeleteSpeciesCommodity.Enabled = false;
        }

        private void dgvListCommodity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddSpeciesCommodity.Enabled = false;
            btnUpdateSpeciesCommodity.Enabled = true;
            btnDeleteSpeciesCommodity.Enabled = true;
            int numrow;
            numrow = e.RowIndex;
            id1 = int.Parse(dgvListCommodity.Rows[numrow].Cells[0].Value.ToString());
            txtNameCommodity.Text = dgvListCommodity.Rows[numrow].Cells[1].Value.ToString();
            cbUnit.Text = dgvListCommodity.Rows[numrow].Cells[2].Value.ToString();
            txtDistributor.Text = dgvListCommodity.Rows[numrow].Cells[3].Value.ToString();
            
        }

        private void btnUpdateSpeciesCommodity_Click(object sender, EventArgs e)
        {
            if (id1 != 0)
            {
                if (ck.checkNullTextbox(txtNameCommodity.Text.ToString()) && ck.checkNullTextbox(txtDistributor.Text.ToString()))
                {
                    DTO.HangHoa hh = new DTO.HangHoa();
                    hh.id_hh = id1;
                    hh.namecommodity = txtNameCommodity.Text;
                    hh.distributor = txtDistributor.Text;
                    hh.unit = cbUnit.Text;
                    bll.updateHH(hh);
                    loadDgv();
                    reset();
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

        private void dgvListCommodity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteSpeciesCommodity_Click(object sender, EventArgs e)
        {
            if (id1 != 0)
            {
                DialogResult result = MessageBox.Show("Xác nhân xóa loại hàng", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    DTO.HangHoa hh = new DTO.HangHoa();
                    hh.id_hh = id1;
                    bll.deleteHH(hh);
                    loadDgv();
                    reset();
                }
                else
                {
                    MessageBox.Show("Hủy xóa loại hàng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn loại hàng cần xóa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(ck.checkNullTextbox(txtNameCommodity.Text.ToString()) || ck.checkNullTextbox(txtDistributor.Text.ToString())){
                DialogResult result = MessageBox.Show("Hủy tác vụ đang thao tác.", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    reset();
                }
            } 
        }
    }
}
