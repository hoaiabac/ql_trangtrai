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
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecommodity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totallprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeimport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSpeciesCommodity = new System.Windows.Forms.Button();
            this.btnImportWarehouse = new System.Windows.Forms.Button();
            this.btnOutWarehouse = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnListCommodity = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(146, 28);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 18);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Bắc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xin chào,";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.namecommodity,
            this.number,
            this.unitprice,
            this.totallprice,
            this.timeimport});
            this.dataGridView1.Location = new System.Drawing.Point(16, 194);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(683, 274);
            this.dataGridView1.TabIndex = 5;
            // 
            // id
            // 
            this.id.FillWeight = 61.38797F;
            this.id.HeaderText = "STT";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // namecommodity
            // 
            this.namecommodity.FillWeight = 118.696F;
            this.namecommodity.HeaderText = "Tên hàng hóa";
            this.namecommodity.Name = "namecommodity";
            this.namecommodity.ReadOnly = true;
            // 
            // number
            // 
            this.number.FillWeight = 90.97327F;
            this.number.HeaderText = "Số lượng";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // unitprice
            // 
            this.unitprice.FillWeight = 131.5032F;
            this.unitprice.HeaderText = "Đơn giá";
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            // 
            // totallprice
            // 
            this.totallprice.FillWeight = 126.6717F;
            this.totallprice.HeaderText = "Tổng giá";
            this.totallprice.Name = "totallprice";
            this.totallprice.ReadOnly = true;
            // 
            // timeimport
            // 
            this.timeimport.FillWeight = 94.62584F;
            this.timeimport.HeaderText = "Thời gian";
            this.timeimport.Name = "timeimport";
            this.timeimport.ReadOnly = true;
            // 
            // btnAddSpeciesCommodity
            // 
            this.btnAddSpeciesCommodity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpeciesCommodity.Location = new System.Drawing.Point(16, 60);
            this.btnAddSpeciesCommodity.Name = "btnAddSpeciesCommodity";
            this.btnAddSpeciesCommodity.Size = new System.Drawing.Size(140, 49);
            this.btnAddSpeciesCommodity.TabIndex = 1;
            this.btnAddSpeciesCommodity.Text = "Thêm loại hàng";
            this.btnAddSpeciesCommodity.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddSpeciesCommodity.UseVisualStyleBackColor = true;
            this.btnAddSpeciesCommodity.Click += new System.EventHandler(this.btnAddSpeciesCommodity_Click);
            // 
            // btnImportWarehouse
            // 
            this.btnImportWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportWarehouse.Location = new System.Drawing.Point(270, 487);
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
            this.btnOutWarehouse.Location = new System.Drawing.Point(909, 487);
            this.btnOutWarehouse.Name = "btnOutWarehouse";
            this.btnOutWarehouse.Size = new System.Drawing.Size(140, 49);
            this.btnOutWarehouse.TabIndex = 8;
            this.btnOutWarehouse.Text = "Xuất kho";
            this.btnOutWarehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOutWarehouse.UseVisualStyleBackColor = true;
            this.btnOutWarehouse.Click += new System.EventHandler(this.btnOutWarehouse_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.timeout});
            this.dataGridView2.Location = new System.Drawing.Point(743, 194);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(470, 274);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 61.26492F;
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 139.3612F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên hàng hóa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 91.7928F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // timeout
            // 
            this.timeout.FillWeight = 86.57138F;
            this.timeout.HeaderText = "Thời gian";
            this.timeout.Name = "timeout";
            this.timeout.ReadOnly = true;
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
            this.button4.Location = new System.Drawing.Point(173, 60);
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
            this.btnListCommodity.Location = new System.Drawing.Point(334, 60);
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
            this.btnHome.Location = new System.Drawing.Point(494, 60);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 49);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImportWarehouse);
            this.Controls.Add(this.btnOutWarehouse);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnListCommodity);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAddSpeciesCommodity);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddSpeciesCommodity;
        private System.Windows.Forms.Button btnImportWarehouse;
        private System.Windows.Forms.Button btnOutWarehouse;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnListCommodity;
        private System.Windows.Forms.Button btnHome;
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