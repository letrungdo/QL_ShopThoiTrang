namespace QL_ShopThoiTrang.Account
{
    partial class frmDoiMatKhau
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
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.txtXacNhanMKM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.txtMKC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.BackColor = System.Drawing.Color.Teal;
            this.btn_capNhat.ForeColor = System.Drawing.Color.MintCream;
            this.btn_capNhat.Location = new System.Drawing.Point(253, 134);
            this.btn_capNhat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(100, 37);
            this.btn_capNhat.TabIndex = 10;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.UseVisualStyleBackColor = false;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // txtXacNhanMKM
            // 
            this.txtXacNhanMKM.Location = new System.Drawing.Point(151, 93);
            this.txtXacNhanMKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtXacNhanMKM.Name = "txtXacNhanMKM";
            this.txtXacNhanMKM.PasswordChar = '●';
            this.txtXacNhanMKM.Size = new System.Drawing.Size(202, 20);
            this.txtXacNhanMKM.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(151, 56);
            this.txtMKM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '●';
            this.txtMKM.Size = new System.Drawing.Size(202, 20);
            this.txtMKM.TabIndex = 8;
            // 
            // txtMKC
            // 
            this.txtMKC.Location = new System.Drawing.Point(151, 20);
            this.txtMKC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.PasswordChar = '●';
            this.txtMKC.Size = new System.Drawing.Size(202, 20);
            this.txtMKC.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 187);
            this.Controls.Add(this.btn_capNhat);
            this.Controls.Add(this.txtXacNhanMKM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.txtMKC);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.TextBox txtXacNhanMKM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.TextBox txtMKC;
        private System.Windows.Forms.Label label2;
    }
}