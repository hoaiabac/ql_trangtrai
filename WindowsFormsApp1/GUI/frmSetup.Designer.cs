namespace WindowsFormsApp1.GUI
{
    partial class frmSetup
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
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbErrorPassRetype = new System.Windows.Forms.Label();
            this.lbErrorPassNew = new System.Windows.Forms.Label();
            this.lbErrorPassOld = new System.Windows.Forms.Label();
            this.lbErrorName = new System.Windows.Forms.Label();
            this.txtPassOld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassRetype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Location = new System.Drawing.Point(215, 306);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(164, 49);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Đổi mật khẩu";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(476, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 49);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbErrorPassRetype);
            this.groupBox1.Controls.Add(this.lbErrorPassNew);
            this.groupBox1.Controls.Add(this.lbErrorPassOld);
            this.groupBox1.Controls.Add(this.lbErrorName);
            this.groupBox1.Controls.Add(this.txtPassOld);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassRetype);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassNew);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbErrorPassRetype
            // 
            this.lbErrorPassRetype.AutoSize = true;
            this.lbErrorPassRetype.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorPassRetype.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPassRetype.Location = new System.Drawing.Point(513, 212);
            this.lbErrorPassRetype.Name = "lbErrorPassRetype";
            this.lbErrorPassRetype.Size = new System.Drawing.Size(58, 23);
            this.lbErrorPassRetype.TabIndex = 2;
            this.lbErrorPassRetype.Text = "Error";
            // 
            // lbErrorPassNew
            // 
            this.lbErrorPassNew.AutoSize = true;
            this.lbErrorPassNew.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorPassNew.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPassNew.Location = new System.Drawing.Point(513, 165);
            this.lbErrorPassNew.Name = "lbErrorPassNew";
            this.lbErrorPassNew.Size = new System.Drawing.Size(58, 23);
            this.lbErrorPassNew.TabIndex = 2;
            this.lbErrorPassNew.Text = "Error";
            // 
            // lbErrorPassOld
            // 
            this.lbErrorPassOld.AutoSize = true;
            this.lbErrorPassOld.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorPassOld.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPassOld.Location = new System.Drawing.Point(513, 110);
            this.lbErrorPassOld.Name = "lbErrorPassOld";
            this.lbErrorPassOld.Size = new System.Drawing.Size(58, 23);
            this.lbErrorPassOld.TabIndex = 2;
            this.lbErrorPassOld.Text = "Error";
            // 
            // lbErrorName
            // 
            this.lbErrorName.AutoSize = true;
            this.lbErrorName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorName.ForeColor = System.Drawing.Color.Red;
            this.lbErrorName.Location = new System.Drawing.Point(513, 63);
            this.lbErrorName.Name = "lbErrorName";
            this.lbErrorName.Size = new System.Drawing.Size(58, 23);
            this.lbErrorName.TabIndex = 2;
            this.lbErrorName.Text = "Error";
            // 
            // txtPassOld
            // 
            this.txtPassOld.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassOld.Location = new System.Drawing.Point(274, 110);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Size = new System.Drawing.Size(223, 31);
            this.txtPassOld.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu cũ:";
            // 
            // txtPassRetype
            // 
            this.txtPassRetype.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassRetype.Location = new System.Drawing.Point(274, 209);
            this.txtPassRetype.Name = "txtPassRetype";
            this.txtPassRetype.Size = new System.Drawing.Size(223, 31);
            this.txtPassRetype.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtPassNew
            // 
            this.txtPassNew.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNew.Location = new System.Drawing.Point(274, 157);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(223, 31);
            this.txtPassNew.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(274, 60);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(223, 31);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(304, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Là thông tin bắt buộc.";
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 418);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmSetup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassOld;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassRetype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbErrorPassRetype;
        private System.Windows.Forms.Label lbErrorPassNew;
        private System.Windows.Forms.Label lbErrorPassOld;
        private System.Windows.Forms.Label lbErrorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}