namespace WindowsFormsApp1
{
    partial class frmListCommodity
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
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.dgvListCommodity = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecommodity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitofsupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnAddSpeciesCommodity = new System.Windows.Forms.Button();
            this.btnUpdateSpeciesCommodity = new System.Windows.Forms.Button();
            this.btnDeleteSpeciesCommodity = new System.Windows.Forms.Button();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.txtDistributor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNameCommodity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommodity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(-76, 266);
            this.lbName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 18);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Bắc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-216, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Xin chào,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bắc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Xin chào,";
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Location = new System.Drawing.Point(791, 11);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(75, 16);
            this.lbLogout.TabIndex = 4;
            this.lbLogout.TabStop = true;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLogout_LinkClicked);
            // 
            // dgvListCommodity
            // 
            this.dgvListCommodity.AllowUserToAddRows = false;
            this.dgvListCommodity.AllowUserToDeleteRows = false;
            this.dgvListCommodity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCommodity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.namecommodity,
            this.unit,
            this.unitofsupply});
            this.dgvListCommodity.Location = new System.Drawing.Point(12, 229);
            this.dgvListCommodity.MultiSelect = false;
            this.dgvListCommodity.Name = "dgvListCommodity";
            this.dgvListCommodity.ReadOnly = true;
            this.dgvListCommodity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCommodity.Size = new System.Drawing.Size(851, 274);
            this.dgvListCommodity.TabIndex = 3;
            this.dgvListCommodity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCommodity_CellClick);
            this.dgvListCommodity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCommodity_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 47.97294F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // namecommodity
            // 
            this.namecommodity.DataPropertyName = "namecommodity";
            this.namecommodity.FillWeight = 81.28346F;
            this.namecommodity.HeaderText = "Tên hàng hóa";
            this.namecommodity.Name = "namecommodity";
            this.namecommodity.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.FillWeight = 63.17979F;
            this.unit.HeaderText = "Đơn vị tính";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // unitofsupply
            // 
            this.unitofsupply.DataPropertyName = "distributor";
            this.unitofsupply.FillWeight = 208.1833F;
            this.unitofsupply.HeaderText = "Đơn vị cung cấp";
            this.unitofsupply.Name = "unitofsupply";
            this.unitofsupply.ReadOnly = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(721, 165);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 49);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Location = new System.Drawing.Point(562, 165);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(140, 49);
            this.btnWarehouse.TabIndex = 2;
            this.btnWarehouse.Text = "Quản lý kho";
            this.btnWarehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnAddSpeciesCommodity
            // 
            this.btnAddSpeciesCommodity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpeciesCommodity.Location = new System.Drawing.Point(12, 165);
            this.btnAddSpeciesCommodity.Name = "btnAddSpeciesCommodity";
            this.btnAddSpeciesCommodity.Size = new System.Drawing.Size(140, 49);
            this.btnAddSpeciesCommodity.TabIndex = 17;
            this.btnAddSpeciesCommodity.Text = "Thêm loại hàng";
            this.btnAddSpeciesCommodity.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddSpeciesCommodity.UseVisualStyleBackColor = true;
            this.btnAddSpeciesCommodity.Click += new System.EventHandler(this.btnAddSpeciesCommodity_Click);
            // 
            // btnUpdateSpeciesCommodity
            // 
            this.btnUpdateSpeciesCommodity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSpeciesCommodity.Location = new System.Drawing.Point(158, 165);
            this.btnUpdateSpeciesCommodity.Name = "btnUpdateSpeciesCommodity";
            this.btnUpdateSpeciesCommodity.Size = new System.Drawing.Size(140, 49);
            this.btnUpdateSpeciesCommodity.TabIndex = 17;
            this.btnUpdateSpeciesCommodity.Text = "Sửa loại hàng";
            this.btnUpdateSpeciesCommodity.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateSpeciesCommodity.UseVisualStyleBackColor = true;
            this.btnUpdateSpeciesCommodity.Click += new System.EventHandler(this.btnUpdateSpeciesCommodity_Click);
            // 
            // btnDeleteSpeciesCommodity
            // 
            this.btnDeleteSpeciesCommodity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSpeciesCommodity.Location = new System.Drawing.Point(304, 165);
            this.btnDeleteSpeciesCommodity.Name = "btnDeleteSpeciesCommodity";
            this.btnDeleteSpeciesCommodity.Size = new System.Drawing.Size(140, 49);
            this.btnDeleteSpeciesCommodity.TabIndex = 17;
            this.btnDeleteSpeciesCommodity.Text = "Xóa loại hàng";
            this.btnDeleteSpeciesCommodity.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteSpeciesCommodity.UseVisualStyleBackColor = true;
            this.btnDeleteSpeciesCommodity.Click += new System.EventHandler(this.btnDeleteSpeciesCommodity_Click);
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "Bao",
            "Kg",
            "Hộp",
            "Chai",
            "Ống",
            "Vỉ"});
            this.cbUnit.Location = new System.Drawing.Point(202, 77);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(121, 24);
            this.cbUnit.TabIndex = 19;
            // 
            // txtDistributor
            // 
            this.txtDistributor.Location = new System.Drawing.Point(202, 118);
            this.txtDistributor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistributor.Name = "txtDistributor";
            this.txtDistributor.Size = new System.Drawing.Size(319, 23);
            this.txtDistributor.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Đơn vị cung cấp:";
            // 
            // txtNameCommodity
            // 
            this.txtNameCommodity.Location = new System.Drawing.Point(202, 39);
            this.txtNameCommodity.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameCommodity.Name = "txtNameCommodity";
            this.txtNameCommodity.Size = new System.Drawing.Size(319, 23);
            this.txtNameCommodity.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Đơn vị tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tên hàng hóa:";
            // 
            // frmListCommodity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 563);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.txtDistributor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNameCommodity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateSpeciesCommodity);
            this.Controls.Add(this.btnDeleteSpeciesCommodity);
            this.Controls.Add(this.btnAddSpeciesCommodity);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dgvListCommodity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListCommodity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListCommodity";
            this.Load += new System.EventHandler(this.frmListCommodity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommodity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.DataGridView dgvListCommodity;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecommodity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitofsupply;
        private System.Windows.Forms.Button btnAddSpeciesCommodity;
        private System.Windows.Forms.Button btnUpdateSpeciesCommodity;
        private System.Windows.Forms.Button btnDeleteSpeciesCommodity;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TextBox txtDistributor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameCommodity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}