namespace QL_ShopThoiTrang
{
    partial class frm_Config
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
            this.btn_Connect = new System.Windows.Forms.Button();
            this.chk_rememberPass = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_DbName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Auth = new System.Windows.Forms.ComboBox();
            this.cbo_ServerName = new System.Windows.Forms.ComboBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(289, 248);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 34);
            this.btn_Connect.TabIndex = 25;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // chk_rememberPass
            // 
            this.chk_rememberPass.AutoSize = true;
            this.chk_rememberPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_rememberPass.Location = new System.Drawing.Point(156, 161);
            this.chk_rememberPass.Name = "chk_rememberPass";
            this.chk_rememberPass.Size = new System.Drawing.Size(157, 23);
            this.chk_rememberPass.TabIndex = 24;
            this.chk_rememberPass.Text = "Remember password";
            this.chk_rememberPass.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Authentication:";
            // 
            // cbo_DbName
            // 
            this.cbo_DbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_DbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbo_DbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_DbName.FormattingEnabled = true;
            this.cbo_DbName.Location = new System.Drawing.Point(156, 193);
            this.cbo_DbName.Name = "cbo_DbName";
            this.cbo_DbName.Size = new System.Drawing.Size(208, 27);
            this.cbo_DbName.TabIndex = 22;
            this.cbo_DbName.DropDown += new System.EventHandler(this.cbo_DbName_DropDown);
            this.cbo_DbName.SelectedIndexChanged += new System.EventHandler(this.cbo_DbName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Database name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Server name:";
            // 
            // cbo_Auth
            // 
            this.cbo_Auth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Auth.FormattingEnabled = true;
            this.cbo_Auth.Location = new System.Drawing.Point(156, 56);
            this.cbo_Auth.Name = "cbo_Auth";
            this.cbo_Auth.Size = new System.Drawing.Size(208, 27);
            this.cbo_Auth.TabIndex = 17;
            this.cbo_Auth.SelectedIndexChanged += new System.EventHandler(this.cbo_Auth_SelectedIndexChanged);
            // 
            // cbo_ServerName
            // 
            this.cbo_ServerName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ServerName.FormattingEnabled = true;
            this.cbo_ServerName.Location = new System.Drawing.Point(156, 21);
            this.cbo_ServerName.Name = "cbo_ServerName";
            this.cbo_ServerName.Size = new System.Drawing.Size(208, 27);
            this.cbo_ServerName.TabIndex = 16;
            this.cbo_ServerName.DropDown += new System.EventHandler(this.cbo_ServerName_DropDown);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(156, 129);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(208, 26);
            this.txt_Pass.TabIndex = 15;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(156, 97);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(208, 26);
            this.txt_User.TabIndex = 14;
            // 
            // frm_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 294);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.chk_rememberPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_DbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Auth);
            this.Controls.Add(this.cbo_ServerName);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Name = "frm_Config";
            this.Text = "Config Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Config_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Config_FormClosed);
            this.Load += new System.EventHandler(this.frm_Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.CheckBox chk_rememberPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_DbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Auth;
        private System.Windows.Forms.ComboBox cbo_ServerName;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_User;
    }
}