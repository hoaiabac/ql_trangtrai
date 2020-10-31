namespace WindowsFormsApp1.GUI
{
    partial class frmSalary2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.btnSalaryClosing = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryperday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberpayday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNumberPayDay = new System.Windows.Forms.NumericUpDown();
            this.cbSalaryPerDay = new System.Windows.Forms.ComboBox();
            this.LbNameEmployee = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberPayDay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStatistical
            // 
            this.btnStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistical.Location = new System.Drawing.Point(375, 255);
            this.btnStatistical.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(170, 46);
            this.btnStatistical.TabIndex = 6;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // btnSalaryClosing
            // 
            this.btnSalaryClosing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryClosing.Location = new System.Drawing.Point(20, 255);
            this.btnSalaryClosing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalaryClosing.Name = "btnSalaryClosing";
            this.btnSalaryClosing.Size = new System.Drawing.Size(170, 46);
            this.btnSalaryClosing.TabIndex = 4;
            this.btnSalaryClosing.Text = "Chốt lương";
            this.btnSalaryClosing.UseVisualStyleBackColor = true;
            this.btnSalaryClosing.Click += new System.EventHandler(this.btnSalaryClosing_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(114, 8);
            this.lbName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 18);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "Bắc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Xin chào,";
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Location = new System.Drawing.Point(790, 10);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(92, 18);
            this.lbLogout.TabIndex = 10;
            this.lbLogout.TabStop = true;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLogout_LinkClicked);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(947, 255);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(142, 46);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvSalary
            // 
            this.dgvSalary.AllowUserToAddRows = false;
            this.dgvSalary.AllowUserToDeleteRows = false;
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.salaryperday,
            this.numberpayday,
            this.totalsalary});
            this.dgvSalary.Location = new System.Drawing.Point(8, 34);
            this.dgvSalary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalary.Size = new System.Drawing.Size(1051, 269);
            this.dgvSalary.TabIndex = 9;
            this.dgvSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalary_CellClick);
            this.dgvSalary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalary_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id_nv";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.FillWeight = 50.76142F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.DefaultCellStyle = dataGridViewCellStyle2;
            this.name.FillWeight = 112.3096F;
            this.name.HeaderText = "Họ Tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // salaryperday
            // 
            this.salaryperday.DataPropertyName = "salaryperday";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryperday.DefaultCellStyle = dataGridViewCellStyle3;
            this.salaryperday.FillWeight = 112.3096F;
            this.salaryperday.HeaderText = "Ngày Lương";
            this.salaryperday.Name = "salaryperday";
            this.salaryperday.ReadOnly = true;
            // 
            // numberpayday
            // 
            this.numberpayday.DataPropertyName = "numberpayday";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberpayday.DefaultCellStyle = dataGridViewCellStyle4;
            this.numberpayday.FillWeight = 112.3096F;
            this.numberpayday.HeaderText = "Số ngày công";
            this.numberpayday.Name = "numberpayday";
            this.numberpayday.ReadOnly = true;
            // 
            // totalsalary
            // 
            this.totalsalary.DataPropertyName = "totalsalary";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsalary.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalsalary.FillWeight = 112.3096F;
            this.totalsalary.HeaderText = "Tổng lương";
            this.totalsalary.Name = "totalsalary";
            this.totalsalary.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày lương:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số ngày công:";
            // 
            // nudNumberPayDay
            // 
            this.nudNumberPayDay.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberPayDay.Location = new System.Drawing.Point(244, 134);
            this.nudNumberPayDay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudNumberPayDay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudNumberPayDay.Name = "nudNumberPayDay";
            this.nudNumberPayDay.Size = new System.Drawing.Size(111, 31);
            this.nudNumberPayDay.TabIndex = 3;
            this.nudNumberPayDay.ThousandsSeparator = true;
            // 
            // cbSalaryPerDay
            // 
            this.cbSalaryPerDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalaryPerDay.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalaryPerDay.FormattingEnabled = true;
            this.cbSalaryPerDay.Items.AddRange(new object[] {
            "200000",
            "300000"});
            this.cbSalaryPerDay.Location = new System.Drawing.Point(244, 86);
            this.cbSalaryPerDay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSalaryPerDay.Name = "cbSalaryPerDay";
            this.cbSalaryPerDay.Size = new System.Drawing.Size(223, 31);
            this.cbSalaryPerDay.TabIndex = 2;
            // 
            // LbNameEmployee
            // 
            this.LbNameEmployee.AutoSize = true;
            this.LbNameEmployee.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNameEmployee.Location = new System.Drawing.Point(239, 45);
            this.LbNameEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNameEmployee.Name = "LbNameEmployee";
            this.LbNameEmployee.Size = new System.Drawing.Size(0, 23);
            this.LbNameEmployee.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(198, 255);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 46);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LbNameEmployee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSalaryPerDay);
            this.groupBox1.Controls.Add(this.nudNumberPayDay);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1069, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Lương:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSalary);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 320);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1076, 313);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lương";
            // 
            // frmSalary2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 647);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStatistical);
            this.Controls.Add(this.btnSalaryClosing);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLogout);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalary2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lương";
            this.Load += new System.EventHandler(this.frmSalary2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberPayDay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.Button btnSalaryClosing;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNumberPayDay;
        private System.Windows.Forms.ComboBox cbSalaryPerDay;
        private System.Windows.Forms.Label LbNameEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryperday;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberpayday;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalsalary;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}