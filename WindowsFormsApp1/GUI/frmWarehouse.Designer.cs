namespace WindowsFormsApp1
{
    partial class frmWarehouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.btnListCommodity = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvWarehouse = new System.Windows.Forms.DataGridView();
            this.namehh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(129, 10);
            this.lbName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 18);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Bắc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xin chào,";
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Location = new System.Drawing.Point(678, 12);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(92, 18);
            this.lbLogout.TabIndex = 8;
            this.lbLogout.TabStop = true;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLogout_LinkClicked);
            // 
            // btnStatistical
            // 
            this.btnStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistical.Location = new System.Drawing.Point(208, 52);
            this.btnStatistical.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(175, 55);
            this.btnStatistical.TabIndex = 2;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // btnListCommodity
            // 
            this.btnListCommodity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListCommodity.Location = new System.Drawing.Point(26, 52);
            this.btnListCommodity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnListCommodity.Name = "btnListCommodity";
            this.btnListCommodity.Size = new System.Drawing.Size(175, 55);
            this.btnListCommodity.TabIndex = 1;
            this.btnListCommodity.Text = "Quản lý loại hàng hóa";
            this.btnListCommodity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListCommodity.UseVisualStyleBackColor = true;
            this.btnListCommodity.Click += new System.EventHandler(this.btnListCommodity_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(614, 52);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(175, 55);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvWarehouse
            // 
            this.dgvWarehouse.AllowUserToAddRows = false;
            this.dgvWarehouse.AllowUserToDeleteRows = false;
            this.dgvWarehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarehouse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namehh,
            this.number1});
            this.dgvWarehouse.Location = new System.Drawing.Point(22, 37);
            this.dgvWarehouse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvWarehouse.MultiSelect = false;
            this.dgvWarehouse.Name = "dgvWarehouse";
            this.dgvWarehouse.ReadOnly = true;
            this.dgvWarehouse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarehouse.Size = new System.Drawing.Size(722, 269);
            this.dgvWarehouse.TabIndex = 5;
            this.dgvWarehouse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWarehouse_CellContentClick);
            // 
            // namehh
            // 
            this.namehh.DataPropertyName = "namecommodity";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namehh.DefaultCellStyle = dataGridViewCellStyle1;
            this.namehh.HeaderText = "Tên hàng hóa";
            this.namehh.Name = "namehh";
            this.namehh.ReadOnly = true;
            // 
            // number1
            // 
            this.number1.DataPropertyName = "number";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1.DefaultCellStyle = dataGridViewCellStyle2;
            this.number1.HeaderText = "Số lượng";
            this.number1.Name = "number1";
            this.number1.ReadOnly = true;
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(189, 490);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(175, 55);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Nhập kho";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(434, 490);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(175, 55);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Xuất kho";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvWarehouse);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 326);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hàng hóa";
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStatistical);
            this.Controls.Add(this.btnListCommodity);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLogout);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho";
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.Button btnListCommodity;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvWarehouse;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namehh;
        private System.Windows.Forms.DataGridViewTextBoxColumn number1;
    }
}