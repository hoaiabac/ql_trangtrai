namespace WindowsFormsApp1.GUI
{
    partial class frmManagementExport
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletrExport = new System.Windows.Forms.Button();
            this.btnOutWarehouse = new System.Windows.Forms.Button();
            this.dgvExportWarehouse = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Danh sách xuất kho";
            // 
            // btnDeletrExport
            // 
            this.btnDeletrExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletrExport.Location = new System.Drawing.Point(446, 586);
            this.btnDeletrExport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDeletrExport.Name = "btnDeletrExport";
            this.btnDeletrExport.Size = new System.Drawing.Size(176, 68);
            this.btnDeletrExport.TabIndex = 5;
            this.btnDeletrExport.Text = "Xóa xuất";
            this.btnDeletrExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeletrExport.UseVisualStyleBackColor = true;
            this.btnDeletrExport.Click += new System.EventHandler(this.btnDeletrExport_Click);
            // 
            // btnOutWarehouse
            // 
            this.btnOutWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutWarehouse.Location = new System.Drawing.Point(193, 586);
            this.btnOutWarehouse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOutWarehouse.Name = "btnOutWarehouse";
            this.btnOutWarehouse.Size = new System.Drawing.Size(176, 68);
            this.btnOutWarehouse.TabIndex = 4;
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
            this.dgvExportWarehouse.Location = new System.Drawing.Point(29, 181);
            this.dgvExportWarehouse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvExportWarehouse.MultiSelect = false;
            this.dgvExportWarehouse.Name = "dgvExportWarehouse";
            this.dgvExportWarehouse.ReadOnly = true;
            this.dgvExportWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExportWarehouse.Size = new System.Drawing.Size(783, 379);
            this.dgvExportWarehouse.TabIndex = 3;
            this.dgvExportWarehouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExportWarehouse_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_xk";
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
            dataGridViewCellStyle1.Format = "HH:mm dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.timeout.DefaultCellStyle = dataGridViewCellStyle1;
            this.timeout.FillWeight = 151.4976F;
            this.timeout.HeaderText = "Thời gian";
            this.timeout.Name = "timeout";
            this.timeout.ReadOnly = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(108, 9);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 18);
            this.lbName.TabIndex = 22;
            this.lbName.Text = "Bắc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Xin chào,";
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Location = new System.Drawing.Point(720, 9);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(92, 18);
            this.lbLogout.TabIndex = 6;
            this.lbLogout.TabStop = true;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLogout_LinkClicked);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(19, 53);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(164, 68);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Location = new System.Drawing.Point(205, 53);
            this.btnWarehouse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(164, 68);
            this.btnWarehouse.TabIndex = 2;
            this.btnWarehouse.Text = "Kho";
            this.btnWarehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // frmManagementExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 678);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeletrExport);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnOutWarehouse);
            this.Controls.Add(this.dgvExportWarehouse);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManagementExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementExport";
            this.Load += new System.EventHandler(this.frmManagementExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeletrExport;
        private System.Windows.Forms.Button btnOutWarehouse;
        private System.Windows.Forms.DataGridView dgvExportWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeout;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnWarehouse;
    }
}