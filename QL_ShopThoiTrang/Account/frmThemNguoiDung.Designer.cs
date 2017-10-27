namespace QL_ShopThoiTrang.Account
{
    partial class frmThemNguoiDung
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label tenNVLabel;
            System.Windows.Forms.Label dienThoaiLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label ngayVaoLamLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label queQuanLabel;
            System.Windows.Forms.Label soCMNDLabel;
            System.Windows.Forms.Label isDelLabel;
            this.Lưu = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.tenNVTextBox = new System.Windows.Forms.TextBox();
            this.dienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.ngayVaoLamDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.queQuanTextBox = new System.Windows.Forms.TextBox();
            this.soCMNDTextBox = new System.Windows.Forms.TextBox();
            this.isDelCheckBox = new System.Windows.Forms.CheckBox();
            this.dataSet_QL_NguoiDung = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDung();
            this.nhanVienTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.TableAdapterManager();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            tenNVLabel = new System.Windows.Forms.Label();
            dienThoaiLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            ngayVaoLamLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            queQuanLabel = new System.Windows.Forms.Label();
            soCMNDLabel = new System.Windows.Forms.Label();
            isDelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_QL_NguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(11, 35);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(11, 61);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // tenNVLabel
            // 
            tenNVLabel.AutoSize = true;
            tenNVLabel.Location = new System.Drawing.Point(11, 87);
            tenNVLabel.Name = "tenNVLabel";
            tenNVLabel.Size = new System.Drawing.Size(47, 13);
            tenNVLabel.TabIndex = 7;
            tenNVLabel.Text = "Ten NV:";
            // 
            // dienThoaiLabel
            // 
            dienThoaiLabel.AutoSize = true;
            dienThoaiLabel.Location = new System.Drawing.Point(11, 113);
            dienThoaiLabel.Name = "dienThoaiLabel";
            dienThoaiLabel.Size = new System.Drawing.Size(62, 13);
            dienThoaiLabel.TabIndex = 9;
            dienThoaiLabel.Text = "Dien Thoai:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(11, 139);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(44, 13);
            diaChiLabel.TabIndex = 11;
            diaChiLabel.Text = "Dia Chi:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(313, 35);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(52, 13);
            gioiTinhLabel.TabIndex = 13;
            gioiTinhLabel.Text = "Gioi Tinh:";
            // 
            // ngayVaoLamLabel
            // 
            ngayVaoLamLabel.AutoSize = true;
            ngayVaoLamLabel.Location = new System.Drawing.Point(313, 62);
            ngayVaoLamLabel.Name = "ngayVaoLamLabel";
            ngayVaoLamLabel.Size = new System.Drawing.Size(80, 13);
            ngayVaoLamLabel.TabIndex = 15;
            ngayVaoLamLabel.Text = "Ngay Vao Lam:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(313, 88);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(59, 13);
            ngaySinhLabel.TabIndex = 17;
            ngaySinhLabel.Text = "Ngay Sinh:";
            // 
            // queQuanLabel
            // 
            queQuanLabel.AutoSize = true;
            queQuanLabel.Location = new System.Drawing.Point(313, 113);
            queQuanLabel.Name = "queQuanLabel";
            queQuanLabel.Size = new System.Drawing.Size(59, 13);
            queQuanLabel.TabIndex = 19;
            queQuanLabel.Text = "Que Quan:";
            // 
            // soCMNDLabel
            // 
            soCMNDLabel.AutoSize = true;
            soCMNDLabel.Location = new System.Drawing.Point(313, 139);
            soCMNDLabel.Name = "soCMNDLabel";
            soCMNDLabel.Size = new System.Drawing.Size(58, 13);
            soCMNDLabel.TabIndex = 21;
            soCMNDLabel.Text = "So CMND:";
            // 
            // isDelLabel
            // 
            isDelLabel.AutoSize = true;
            isDelLabel.Location = new System.Drawing.Point(639, 37);
            isDelLabel.Name = "isDelLabel";
            isDelLabel.Size = new System.Drawing.Size(37, 13);
            isDelLabel.TabIndex = 23;
            isDelLabel.Text = "Is Del:";
            // 
            // Lưu
            // 
            this.Lưu.Location = new System.Drawing.Point(638, 77);
            this.Lưu.Name = "Lưu";
            this.Lưu.Size = new System.Drawing.Size(75, 23);
            this.Lưu.TabIndex = 0;
            this.Lưu.Text = "Lưu";
            this.Lưu.UseVisualStyleBackColor = true;
            this.Lưu.Click += new System.EventHandler(this.Lưu_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(97, 32);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 20);
            this.usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(97, 58);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // tenNVTextBox
            // 
            this.tenNVTextBox.Location = new System.Drawing.Point(97, 84);
            this.tenNVTextBox.Name = "tenNVTextBox";
            this.tenNVTextBox.Size = new System.Drawing.Size(200, 20);
            this.tenNVTextBox.TabIndex = 8;
            // 
            // dienThoaiTextBox
            // 
            this.dienThoaiTextBox.Location = new System.Drawing.Point(97, 110);
            this.dienThoaiTextBox.Name = "dienThoaiTextBox";
            this.dienThoaiTextBox.Size = new System.Drawing.Size(200, 20);
            this.dienThoaiTextBox.TabIndex = 10;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.Location = new System.Drawing.Point(97, 136);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(200, 20);
            this.diaChiTextBox.TabIndex = 12;
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.Location = new System.Drawing.Point(399, 32);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(200, 20);
            this.gioiTinhTextBox.TabIndex = 14;
            // 
            // ngayVaoLamDateTimePicker
            // 
            this.ngayVaoLamDateTimePicker.Location = new System.Drawing.Point(399, 58);
            this.ngayVaoLamDateTimePicker.Name = "ngayVaoLamDateTimePicker";
            this.ngayVaoLamDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngayVaoLamDateTimePicker.TabIndex = 16;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(399, 84);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ngaySinhDateTimePicker.TabIndex = 18;
            // 
            // queQuanTextBox
            // 
            this.queQuanTextBox.Location = new System.Drawing.Point(399, 110);
            this.queQuanTextBox.Name = "queQuanTextBox";
            this.queQuanTextBox.Size = new System.Drawing.Size(200, 20);
            this.queQuanTextBox.TabIndex = 20;
            // 
            // soCMNDTextBox
            // 
            this.soCMNDTextBox.Location = new System.Drawing.Point(399, 136);
            this.soCMNDTextBox.Name = "soCMNDTextBox";
            this.soCMNDTextBox.Size = new System.Drawing.Size(200, 20);
            this.soCMNDTextBox.TabIndex = 22;
            // 
            // isDelCheckBox
            // 
            this.isDelCheckBox.Location = new System.Drawing.Point(682, 32);
            this.isDelCheckBox.Name = "isDelCheckBox";
            this.isDelCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDelCheckBox.TabIndex = 24;
            this.isDelCheckBox.Text = "checkBox1";
            this.isDelCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataSet_QL_NguoiDung
            // 
            this.dataSet_QL_NguoiDung.DataSetName = "DataSet_QL_NguoiDung";
            this.dataSet_QL_NguoiDung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_NV_NhomNguoiDungDKTableAdapter = null;
            this.tableAdapterManager.QL_NV_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 365);
            this.Controls.Add(isDelLabel);
            this.Controls.Add(this.isDelCheckBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(tenNVLabel);
            this.Controls.Add(this.tenNVTextBox);
            this.Controls.Add(dienThoaiLabel);
            this.Controls.Add(this.dienThoaiTextBox);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(gioiTinhLabel);
            this.Controls.Add(this.gioiTinhTextBox);
            this.Controls.Add(ngayVaoLamLabel);
            this.Controls.Add(this.ngayVaoLamDateTimePicker);
            this.Controls.Add(ngaySinhLabel);
            this.Controls.Add(this.ngaySinhDateTimePicker);
            this.Controls.Add(queQuanLabel);
            this.Controls.Add(this.queQuanTextBox);
            this.Controls.Add(soCMNDLabel);
            this.Controls.Add(this.soCMNDTextBox);
            this.Controls.Add(this.Lưu);
            this.Name = "frmThemNguoiDung";
            this.Text = "frmThemNguoiDung";
            this.Load += new System.EventHandler(this.frmThemNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_QL_NguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lưu;
        private DataSet_SQL.DataSet_QL_NguoiDung dataSet_QL_NguoiDung;
        private DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox tenNVTextBox;
        private System.Windows.Forms.TextBox dienThoaiTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox gioiTinhTextBox;
        private System.Windows.Forms.DateTimePicker ngayVaoLamDateTimePicker;
        private System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        private System.Windows.Forms.TextBox queQuanTextBox;
        private System.Windows.Forms.TextBox soCMNDTextBox;
        private System.Windows.Forms.CheckBox isDelCheckBox;
    }
}