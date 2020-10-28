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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.dgvImportWarehouse = new System.Windows.Forms.DataGridView();
            this.btnImportWarehouse = new System.Windows.Forms.Button();
            this.btnOutWarehouse = new System.Windows.Forms.Button();
            this.dgvExportWarehouse = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnListCommodity = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btDeleteCommodity = new System.Windows.Forms.Button();
            this.btDeletrExport = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecommodity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totallprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeimport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(119, 28);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 18);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Bắc";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xin chào,";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Location = new System.Drawing.Point(1138, 30);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(75, 16);
            this.lbLogout.TabIndex = 9;
            this.lbLogout.TabStop = true;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLogout_LinkClicked);
            // 
            // dgvImportWarehouse
            // 
            this.dgvImportWarehouse.AllowUserToAddRows = false;
            this.dgvImportWarehouse.AllowUserToDeleteRows = false;
            this.dgvImportWarehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.namecommodity,
            this.number,
            this.unitprice,
            this.totallprice,
            this.timeimport});
            this.dgvImportWarehouse.Location = new System.Drawing.Point(16, 194);
            this.dgvImportWarehouse.MultiSelect = false;
            this.dgvImportWarehouse.Name = "dgvImportWarehouse";
            this.dgvImportWarehouse.ReadOnly = true;
            this.dgvImportWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportWarehouse.Size = new System.Drawing.Size(683, 274);
            this.dgvImportWarehouse.TabIndex = 5;
            this.dgvImportWarehouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImportWarehouse_CellClick);
            this.dgvImportWarehouse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImportWarehouse_CellContentClick);
            // 
            // btnImportWarehouse
            // 
            this.btnImportWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportWarehouse.Location = new System.Drawing.Point(198, 487);
            this.btnImportWarehouse.Name = "btnImportWarehouse";
            this.btnImportWarehouse.Size = new System.Drawing.Size(140, 49);
            this.btnImportWarehouse.TabIndex = 6;
            this.btnImportWarehouse.Text = "Nhập kho";
            this.btnImportWarehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImportWarehouse.UseVisualStyleBackColor = true;
            this.btnImportWarehouse.Click += new System.EventHandler(this.btnImportWarehouse_Click);
            // 
            // btnOutWarehouse
            // 
            this.btnOutWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutWarehouse.Location = new System.Drawing.Point(847, 487);
            this.btnOutWarehouse.Name = "btnOutWarehouse";
            this.btnOutWarehouse.Size = new System.Drawing.Size(140, 49);
            this.btnOutWarehouse.TabIndex = 8;
            this.btnOutWarehouse.Text = "Xuất kho";
            this.btnOutWarehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOutWarehouse.UseVisualStyleBackColor = true;
            this.btnOutWarehouse.Click += new System.EventHandler(this.btnOutWarehouse_Click);
            // 
            // dgvExportWarehouse
            // 
            this.dgvExportWarehouse.AllowUserToAddRows = false;
            this.dgvExportWarehouse.AllowUserToDeleteRows = false;
            this.dgvExportWarehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExportWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExportWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.timeout});
            this.dgvExportWarehouse.Location = new System.Drawing.Point(743, 194);
            this.dgvExportWarehouse.MultiSelect = false;
            this.dgvExportWarehouse.Name = "dgvExportWarehouse";
            this.dgvExportWarehouse.ReadOnly = true;
            this.dgvExportWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExportWarehouse.Size = new System.Drawing.Size(470, 274);
            this.dgvExportWarehouse.TabIndex = 7;
            this.dgvExportWarehouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExportWarehouse_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Danh sách nhập kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(738, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Danh sách xuất kho";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(16, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 49);
            this.button4.TabIndex = 2;
            this.button4.Text = "Thống kê";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnListCommodity
            // 
            this.btnListCommodity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListCommodity.Location = new System.Drawing.Point(162, 60);
            this.btnListCommodity.Name = "btnListCommodity";
            this.btnListCommodity.Size = new System.Drawing.Size(140, 49);
            this.btnListCommodity.TabIndex = 3;
            this.btnListCommodity.Text = "Danh sách hàng hóa";
            this.btnListCommodity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListCommodity.UseVisualStyleBackColor = true;
            this.btnListCommodity.Click += new System.EventHandler(this.btnListCommodity_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(308, 60);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 49);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btDeleteCommodity
            // 
            this.btDeleteCommodity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteCommodity.Location = new System.Drawing.Point(362, 487);
            this.btDeleteCommodity.Name = "btDeleteCommodity";
            this.btDeleteCommodity.Size = new System.Drawing.Size(140, 49);
            this.btDeleteCommodity.TabIndex = 6;
            this.btDeleteCommodity.Text = "Xóa nhập";
            this.btDeleteCommodity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDeleteCommodity.UseVisualStyleBackColor = true;
            this.btDeleteCommodity.Click += new System.EventHandler(this.btDeleteCommodity_Click);
            // 
            // btDeletrExport
            // 
            this.btDeletrExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletrExport.Location = new System.Drawing.Point(993, 487);
            this.btDeletrExport.Name = "btDeletrExport";
            this.btDeletrExport.Size = new System.Drawing.Size(140, 49);
            this.btDeletrExport.TabIndex = 6;
            this.btDeletrExport.Text = "Xóa xuất";
            this.btDeletrExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDeletrExport.UseVisualStyleBackColor = true;
            this.btDeletrExport.Click += new System.EventHandler(this.btDeletrExport_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 60.83126F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // namecommodity
            // 
            this.namecommodity.DataPropertyName = "namecommodity";
            this.namecommodity.FillWeight = 108.1502F;
            this.namecommodity.HeaderText = "Tên hàng hóa";
            this.namecommodity.Name = "namecommodity";
            this.namecommodity.ReadOnly = true;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.FillWeight = 93.15858F;
            this.number.HeaderText = "Số lượng";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // unitprice
            // 
            this.unitprice.DataPropertyName = "unitprice";
            this.unitprice.FillWeight = 104.0128F;
            this.unitprice.HeaderText = "Đơn giá";
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            // 
            // totallprice
            // 
            this.totallprice.DataPropertyName = "totalprice";
            this.totallprice.FillWeight = 99.36555F;
            this.totallprice.HeaderText = "Tổng giá";
            this.totallprice.Name = "totallprice";
            this.totallprice.ReadOnly = true;
            // 
            // timeimport
            // 
            this.timeimport.DataPropertyName = "time";
            dataGridViewCellStyle3.Format = "HH:mm dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.timeimport.DefaultCellStyle = dataGridViewCellStyle3;
            this.timeimport.FillWeight = 158.3396F;
            this.timeimport.HeaderText = "Thời gian";
            this.timeimport.Name = "timeimport";
            this.timeimport.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.FillWeight = 35.78732F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "namecommodity";
            this.dataGridViewTextBoxColumn2.FillWeight = 105.134F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên hàng hóa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn4.FillWeight = 86.5714F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // timeout
            // 
            this.timeout.DataPropertyName = "time";
            dataGridViewCellStyle4.Format = "HH:mm dd/MM/yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.timeout.DefaultCellStyle = dataGridViewCellStyle4;
            this.timeout.FillWeight = 151.4976F;
            this.timeout.HeaderText = "Thời gian";
            this.timeout.Name = "timeout";
            this.timeout.ReadOnly = true;
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDeletrExport);
            this.Controls.Add(this.btDeleteCommodity);
            this.Controls.Add(this.btnImportWarehouse);
            this.Controls.Add(this.btnOutWarehouse);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnListCommodity);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dgvExportWarehouse);
            this.Controls.Add(this.dgvImportWarehouse);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLogout);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWarehouse";
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.DataGridView dgvImportWarehouse;
        private System.Windows.Forms.Button btnImportWarehouse;
        private System.Windows.Forms.Button btnOutWarehouse;
        private System.Windows.Forms.DataGridView dgvExportWarehouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnListCommodity;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btDeleteCommodity;
        private System.Windows.Forms.Button btDeletrExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecommodity;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totallprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeimport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeout;
    }
}