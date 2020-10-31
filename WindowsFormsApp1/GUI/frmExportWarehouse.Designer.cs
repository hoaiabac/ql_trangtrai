namespace WindowsFormsApp1
{
    partial class frmExportWarehouse
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
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.cbNameCommodity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.lbErrorNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Location = new System.Drawing.Point(391, 221);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(140, 49);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "Hủy";
            this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Location = new System.Drawing.Point(195, 221);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(140, 49);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Lưu";
            this.btnYes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // cbNameCommodity
            // 
            this.cbNameCommodity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameCommodity.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNameCommodity.FormattingEnabled = true;
            this.cbNameCommodity.Location = new System.Drawing.Point(216, 42);
            this.cbNameCommodity.Name = "cbNameCommodity";
            this.cbNameCommodity.Size = new System.Drawing.Size(227, 31);
            this.cbNameCommodity.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "Tên hàng hóa:";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(216, 93);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(227, 31);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Số lượng:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(95, 9);
            this.lbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 16);
            this.lbName.TabIndex = 36;
            this.lbName.Text = "Bắc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Xin chào,";
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.Location = new System.Drawing.Point(621, 9);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(75, 16);
            this.lbLogout.TabIndex = 6;
            this.lbLogout.TabStop = true;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLogout_LinkClicked);
            // 
            // lbErrorNumber
            // 
            this.lbErrorNumber.AutoSize = true;
            this.lbErrorNumber.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorNumber.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNumber.Location = new System.Drawing.Point(450, 96);
            this.lbErrorNumber.Name = "lbErrorNumber";
            this.lbErrorNumber.Size = new System.Drawing.Size(199, 23);
            this.lbErrorNumber.TabIndex = 41;
            this.lbErrorNumber.Text = "Thông tin bắt buộc!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNameCommodity);
            this.groupBox1.Controls.Add(this.lbErrorNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xuất kho";
            // 
            // frmExportWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 298);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLogout);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExportWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất kho";
            this.Load += new System.EventHandler(this.frmOutWarehouse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.ComboBox cbNameCommodity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.Label lbErrorNumber;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}