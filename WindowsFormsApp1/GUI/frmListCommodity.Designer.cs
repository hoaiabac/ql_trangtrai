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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.dgvListCommodity = new System.Windows.Forms.DataGridView();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecommodity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitofsupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommodity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(-95, 299);
            this.lbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 18);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Bắc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-270, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Xin chào,";
            // 
            // lbName1
            // 
            this.lbName1.AutoSize = true;
            this.lbName1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName1.Location = new System.Drawing.Point(124, 8);
            this.lbName1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName1.Name = "lbName1";
            this.lbName1.Size = new System.Drawing.Size(37, 18);
            this.lbName1.TabIndex = 16;
            this.lbName1.Text = "Bắc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Xin chào,";
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lbLogout.Location = new System.Drawing.Point(1145, 9);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(92, 18);
            this.lbLogout.TabIndex = 13;
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
            this.dgvListCommodity.Location = new System.Drawing.Point(16, 26);
            this.dgvListCommodity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvListCommodity.MultiSelect = false;
            this.dgvListCommodity.Name = "dgvListCommodity";
            this.dgvListCommodity.ReadOnly = true;
            this.dgvListCommodity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCommodity.Size = new System.Drawing.Size(1186, 308);
            this.dgvListCommodity.TabIndex = 12;
            this.dgvListCommodity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCommodity_CellClick);
            this.dgvListCommodity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCommodity_CellContentClick);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(1062, 266);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(175, 55);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Location = new System.Drawing.Point(879, 266);
            this.btnWarehouse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(175, 55);
            this.btnWarehouse.TabIndex = 9;
            this.btnWarehouse.Text = "Quản lý kho";
            this.btnWarehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnAddSpeciesCommodity
            // 
            this.btnAddSpeciesCommodity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpeciesCommodity.Location = new System.Drawing.Point(22, 266);
            this.btnAddSpeciesCommodity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddSpeciesCommodity.Name = "btnAddSpeciesCommodity";
            this.btnAddSpeciesCommodity.Size = new System.Drawing.Size(175, 55);
            this.btnAddSpeciesCommodity.TabIndex = 5;
            this.btnAddSpeciesCommodity.Text = "Thêm loại hàng";
            this.btnAddSpeciesCommodity.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddSpeciesCommodity.UseVisualStyleBackColor = true;
            this.btnAddSpeciesCommodity.Click += new System.EventHandler(this.btnAddSpeciesCommodity_Click);
            // 
            // btnUpdateSpeciesCommodity
            // 
            this.btnUpdateSpeciesCommodity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSpeciesCommodity.Location = new System.Drawing.Point(205, 266);
            this.btnUpdateSpeciesCommodity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateSpeciesCommodity.Name = "btnUpdateSpeciesCommodity";
            this.btnUpdateSpeciesCommodity.Size = new System.Drawing.Size(175, 55);
            this.btnUpdateSpeciesCommodity.TabIndex = 6;
            this.btnUpdateSpeciesCommodity.Text = "Sửa loại hàng";
            this.btnUpdateSpeciesCommodity.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateSpeciesCommodity.UseVisualStyleBackColor = true;
            this.btnUpdateSpeciesCommodity.Click += new System.EventHandler(this.btnUpdateSpeciesCommodity_Click);
            // 
            // btnDeleteSpeciesCommodity
            // 
            this.btnDeleteSpeciesCommodity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSpeciesCommodity.Location = new System.Drawing.Point(387, 266);
            this.btnDeleteSpeciesCommodity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteSpeciesCommodity.Name = "btnDeleteSpeciesCommodity";
            this.btnDeleteSpeciesCommodity.Size = new System.Drawing.Size(175, 55);
            this.btnDeleteSpeciesCommodity.TabIndex = 7;
            this.btnDeleteSpeciesCommodity.Text = "Xóa loại hàng";
            this.btnDeleteSpeciesCommodity.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteSpeciesCommodity.UseVisualStyleBackColor = true;
            this.btnDeleteSpeciesCommodity.Click += new System.EventHandler(this.btnDeleteSpeciesCommodity_Click);
            // 
            // cbUnit
            // 
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "Bao",
            "Kg",
            "Hộp",
            "Chai",
            "Ống",
            "Vỉ"});
            this.cbUnit.Location = new System.Drawing.Point(261, 81);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(150, 26);
            this.cbUnit.TabIndex = 3;
            // 
            // txtDistributor
            // 
            this.txtDistributor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistributor.Location = new System.Drawing.Point(261, 127);
            this.txtDistributor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDistributor.Name = "txtDistributor";
            this.txtDistributor.Size = new System.Drawing.Size(941, 27);
            this.txtDistributor.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Đơn vị cung cấp:";
            // 
            // txtNameCommodity
            // 
            this.txtNameCommodity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCommodity.Location = new System.Drawing.Point(261, 38);
            this.txtNameCommodity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNameCommodity.Name = "txtNameCommodity";
            this.txtNameCommodity.Size = new System.Drawing.Size(525, 27);
            this.txtNameCommodity.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Đơn vị tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tên hàng hóa:";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(570, 266);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 55);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNameCommodity);
            this.groupBox1.Controls.Add(this.cbUnit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDistributor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1216, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListCommodity);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1216, 351);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hàng hóa";
            // 
            // id
            // 
            this.id.DataPropertyName = "id_hh";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.DefaultCellStyle = dataGridViewCellStyle5;
            this.id.FillWeight = 47.97294F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // namecommodity
            // 
            this.namecommodity.DataPropertyName = "namecommodity";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namecommodity.DefaultCellStyle = dataGridViewCellStyle6;
            this.namecommodity.FillWeight = 81.28346F;
            this.namecommodity.HeaderText = "Tên hàng hóa";
            this.namecommodity.Name = "namecommodity";
            this.namecommodity.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit.DefaultCellStyle = dataGridViewCellStyle7;
            this.unit.FillWeight = 63.17979F;
            this.unit.HeaderText = "Đơn vị tính";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // unitofsupply
            // 
            this.unitofsupply.DataPropertyName = "distributor";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitofsupply.DefaultCellStyle = dataGridViewCellStyle8;
            this.unitofsupply.FillWeight = 208.1833F;
            this.unitofsupply.HeaderText = "Đơn vị cung cấp";
            this.unitofsupply.Name = "unitofsupply";
            this.unitofsupply.ReadOnly = true;
            // 
            // frmListCommodity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 716);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdateSpeciesCommodity);
            this.Controls.Add(this.btnDeleteSpeciesCommodity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddSpeciesCommodity);
            this.Controls.Add(this.btnWarehouse);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lbName1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListCommodity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.frmListCommodity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommodity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.DataGridView dgvListCommodity;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnAddSpeciesCommodity;
        private System.Windows.Forms.Button btnUpdateSpeciesCommodity;
        private System.Windows.Forms.Button btnDeleteSpeciesCommodity;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TextBox txtDistributor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameCommodity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecommodity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitofsupply;
    }
}