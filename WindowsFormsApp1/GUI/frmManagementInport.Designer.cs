namespace WindowsFormsApp1.GUI
{
    partial class frmManagementInport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteImport = new System.Windows.Forms.Button();
            this.btnImportWarehouse = new System.Windows.Forms.Button();
            this.dgvImportWarehouse = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecommodity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totallprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeimport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Danh sách nhập kho";
            // 
            // btnDeleteImport
            // 
            this.btnDeleteImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteImport.Location = new System.Drawing.Point(588, 606);
            this.btnDeleteImport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDeleteImport.Name = "btnDeleteImport";
            this.btnDeleteImport.Size = new System.Drawing.Size(233, 68);
            this.btnDeleteImport.TabIndex = 5;
            this.btnDeleteImport.Text = "Xóa nhập";
            this.btnDeleteImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteImport.UseVisualStyleBackColor = true;
            this.btnDeleteImport.Click += new System.EventHandler(this.btnDeleteImport_Click);
            // 
            // btnImportWarehouse
            // 
            this.btnImportWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportWarehouse.Location = new System.Drawing.Point(315, 606);
            this.btnImportWarehouse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnImportWarehouse.Name = "btnImportWarehouse";
            this.btnImportWarehouse.Size = new System.Drawing.Size(233, 68);
            this.btnImportWarehouse.TabIndex = 4;
            this.btnImportWarehouse.Text = "Nhập kho";
            this.btnImportWarehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImportWarehouse.UseVisualStyleBackColor = true;
            this.btnImportWarehouse.Click += new System.EventHandler(this.btnImportWarehouse_Click);
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
            this.dgvImportWarehouse.Location = new System.Drawing.Point(18, 199);
            this.dgvImportWarehouse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvImportWarehouse.MultiSelect = false;
            this.dgvImportWarehouse.Name = "dgvImportWarehouse";
            this.dgvImportWarehouse.ReadOnly = true;
            this.dgvImportWarehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportWarehouse.Size = new System.Drawing.Size(1138, 379);
            this.dgvImportWarehouse.TabIndex = 3;
            this.dgvImportWarehouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImportWarehouse_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id_nk";
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
            dataGridViewCellStyle4.Format = "HH:mm dd/MM/yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.timeimport.DefaultCellStyle = dataGridViewCellStyle4;
            this.timeimport.FillWeight = 158.3396F;
            this.timeimport.HeaderText = "Thời gian";
            this.timeimport.Name = "timeimport";
            this.timeimport.ReadOnly = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(104, 11);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 18);
            this.lbName.TabIndex = 22;
            this.lbName.Text = "Bắc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Xin chào,";
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Location = new System.Drawing.Point(1064, 11);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(92, 18);
            this.lbLogout.TabIndex = 21;
            this.lbLogout.TabStop = true;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLogout_LinkClicked);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Location = new System.Drawing.Point(204, 51);
            this.btnWarehouse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(164, 68);
            this.btnWarehouse.TabIndex = 2;
            this.btnWarehouse.Text = "Kho";
            this.btnWarehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(18, 51);
            this.btnHome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(164, 68);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmManagementInport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 703);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteImport);
            this.Controls.Add(this.btnImportWarehouse);
            this.Controls.Add(this.dgvImportWarehouse);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManagementInport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementInport";
            this.Load += new System.EventHandler(this.frmManagementInport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteImport;
        private System.Windows.Forms.Button btnImportWarehouse;
        private System.Windows.Forms.DataGridView dgvImportWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecommodity;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totallprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeimport;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnHome;
    }
}