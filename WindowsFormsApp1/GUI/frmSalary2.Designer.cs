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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalaryClosing = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalaryPerDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNumberPayDay = new System.Windows.Forms.NumericUpDown();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryperday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberpayday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberPayDay)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(384, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalaryClosing
            // 
            this.btnSalaryClosing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryClosing.Location = new System.Drawing.Point(526, 210);
            this.btnSalaryClosing.Name = "btnSalaryClosing";
            this.btnSalaryClosing.Size = new System.Drawing.Size(136, 41);
            this.btnSalaryClosing.TabIndex = 11;
            this.btnSalaryClosing.Text = "Chốt lương";
            this.btnSalaryClosing.UseVisualStyleBackColor = true;
            this.btnSalaryClosing.Click += new System.EventHandler(this.btnSalaryClosing_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Danh sách lương";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(98, 19);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 18);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "Bắc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Xin chào,";
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Location = new System.Drawing.Point(606, 21);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(75, 16);
            this.lbLogout.TabIndex = 12;
            this.lbLogout.TabStop = true;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLogout_LinkClicked);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(287, 532);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(114, 41);
            this.btnHome.TabIndex = 16;
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
            this.dgvSalary.Location = new System.Drawing.Point(23, 267);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalary.Size = new System.Drawing.Size(639, 239);
            this.dgvSalary.TabIndex = 17;
            this.dgvSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalary_CellClick);
            this.dgvSalary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalary_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Họ tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 23);
            this.txtName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày lương:";
            // 
            // txtSalaryPerDay
            // 
            this.txtSalaryPerDay.Location = new System.Drawing.Point(190, 99);
            this.txtSalaryPerDay.Name = "txtSalaryPerDay";
            this.txtSalaryPerDay.Size = new System.Drawing.Size(179, 23);
            this.txtSalaryPerDay.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số ngày công:";
            // 
            // nudNumberPayDay
            // 
            this.nudNumberPayDay.Location = new System.Drawing.Point(190, 141);
            this.nudNumberPayDay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudNumberPayDay.Name = "nudNumberPayDay";
            this.nudNumberPayDay.Size = new System.Drawing.Size(89, 23);
            this.nudNumberPayDay.TabIndex = 20;
            this.nudNumberPayDay.ThousandsSeparator = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 50.76142F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 112.3096F;
            this.name.HeaderText = "Họ Tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // salaryperday
            // 
            this.salaryperday.DataPropertyName = "salaryperday";
            this.salaryperday.FillWeight = 112.3096F;
            this.salaryperday.HeaderText = "Ngày Lương";
            this.salaryperday.Name = "salaryperday";
            this.salaryperday.ReadOnly = true;
            // 
            // numberpayday
            // 
            this.numberpayday.DataPropertyName = "numberpayday";
            this.numberpayday.FillWeight = 112.3096F;
            this.numberpayday.HeaderText = "Số ngày công";
            this.numberpayday.Name = "numberpayday";
            this.numberpayday.ReadOnly = true;
            // 
            // totalsalary
            // 
            this.totalsalary.DataPropertyName = "totalsalary";
            this.totalsalary.FillWeight = 112.3096F;
            this.totalsalary.HeaderText = "Tổng lương";
            this.totalsalary.Name = "totalsalary";
            this.totalsalary.ReadOnly = true;
            // 
            // frmSalary2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 583);
            this.Controls.Add(this.nudNumberPayDay);
            this.Controls.Add(this.txtSalaryPerDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSalary);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalaryClosing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLogout);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalary2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalary2";
            this.Load += new System.EventHandler(this.frmSalary2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberPayDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalaryClosing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalaryPerDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNumberPayDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryperday;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberpayday;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalsalary;
    }
}