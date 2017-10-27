namespace QL_ShopThoiTrang.DanhMuc
{
    partial class frmThemMatHang
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
            System.Windows.Forms.Label maLoaiMHLabel;
            System.Windows.Forms.Label tenMHLabel;
            System.Windows.Forms.Label giaVonLabel;
            System.Windows.Forms.Label giaBanSiLabel;
            System.Windows.Forms.Label giaBanLeLabel;
            System.Windows.Forms.Label xuatXuLabel;
            System.Windows.Forms.Label chatLieuLabel;
            System.Windows.Forms.Label danhChoLabel;
            System.Windows.Forms.Label kichThuocLabel;
            System.Windows.Forms.Label moTaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.dataSet_MatHang = new QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHang();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matHangTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHangTableAdapters.MatHangTableAdapter();
            this.tableAdapterManager = new QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHangTableAdapters.TableAdapterManager();
            this.dM_NhanHieuTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHangTableAdapters.DM_NhanHieuTableAdapter();
            this.donViTinhTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHangTableAdapters.DonViTinhTableAdapter();
            this.loaiMatHangTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHangTableAdapters.LoaiMatHangTableAdapter();
            this.tenMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.giaVonSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.giaBanSiSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.giaBanLeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.xuatXuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.chatLieuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.danhChoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.kichThuocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.donViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donViTinhComboBox = new System.Windows.Forms.ComboBox();
            this.dM_NhanHieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_NhanHieuComboBox = new System.Windows.Forms.ComboBox();
            this.loaiMatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiMatHangComboBox = new System.Windows.Forms.ComboBox();
            this.moTaTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.btnLuu = new System.Windows.Forms.Button();
            maLoaiMHLabel = new System.Windows.Forms.Label();
            tenMHLabel = new System.Windows.Forms.Label();
            giaVonLabel = new System.Windows.Forms.Label();
            giaBanSiLabel = new System.Windows.Forms.Label();
            giaBanLeLabel = new System.Windows.Forms.Label();
            xuatXuLabel = new System.Windows.Forms.Label();
            chatLieuLabel = new System.Windows.Forms.Label();
            danhChoLabel = new System.Windows.Forms.Label();
            kichThuocLabel = new System.Windows.Forms.Label();
            moTaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaVonSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaBanSiSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaBanLeSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuatXuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatLieuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhChoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kichThuocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_NhanHieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiMatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moTaTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maLoaiMHLabel
            // 
            maLoaiMHLabel.AutoSize = true;
            maLoaiMHLabel.Location = new System.Drawing.Point(271, 35);
            maLoaiMHLabel.Name = "maLoaiMHLabel";
            maLoaiMHLabel.Size = new System.Drawing.Size(77, 13);
            maLoaiMHLabel.TabIndex = 5;
            maLoaiMHLabel.Text = "Loại mặt hàng:";
            // 
            // tenMHLabel
            // 
            tenMHLabel.AutoSize = true;
            tenMHLabel.Location = new System.Drawing.Point(16, 84);
            tenMHLabel.Name = "tenMHLabel";
            tenMHLabel.Size = new System.Drawing.Size(49, 13);
            tenMHLabel.TabIndex = 11;
            tenMHLabel.Text = "Ten MH:";
            // 
            // giaVonLabel
            // 
            giaVonLabel.AutoSize = true;
            giaVonLabel.Location = new System.Drawing.Point(16, 110);
            giaVonLabel.Name = "giaVonLabel";
            giaVonLabel.Size = new System.Drawing.Size(48, 13);
            giaVonLabel.TabIndex = 13;
            giaVonLabel.Text = "Gia Von:";
            // 
            // giaBanSiLabel
            // 
            giaBanSiLabel.AutoSize = true;
            giaBanSiLabel.Location = new System.Drawing.Point(16, 136);
            giaBanSiLabel.Name = "giaBanSiLabel";
            giaBanSiLabel.Size = new System.Drawing.Size(60, 13);
            giaBanSiLabel.TabIndex = 15;
            giaBanSiLabel.Text = "Gia Ban Si:";
            // 
            // giaBanLeLabel
            // 
            giaBanLeLabel.AutoSize = true;
            giaBanLeLabel.Location = new System.Drawing.Point(16, 162);
            giaBanLeLabel.Name = "giaBanLeLabel";
            giaBanLeLabel.Size = new System.Drawing.Size(63, 13);
            giaBanLeLabel.TabIndex = 17;
            giaBanLeLabel.Text = "Gia Ban Le:";
            // 
            // xuatXuLabel
            // 
            xuatXuLabel.AutoSize = true;
            xuatXuLabel.Location = new System.Drawing.Point(231, 84);
            xuatXuLabel.Name = "xuatXuLabel";
            xuatXuLabel.Size = new System.Drawing.Size(48, 13);
            xuatXuLabel.TabIndex = 21;
            xuatXuLabel.Text = "Xuat Xu:";
            // 
            // chatLieuLabel
            // 
            chatLieuLabel.AutoSize = true;
            chatLieuLabel.Location = new System.Drawing.Point(231, 110);
            chatLieuLabel.Name = "chatLieuLabel";
            chatLieuLabel.Size = new System.Drawing.Size(55, 13);
            chatLieuLabel.TabIndex = 23;
            chatLieuLabel.Text = "Chat Lieu:";
            // 
            // danhChoLabel
            // 
            danhChoLabel.AutoSize = true;
            danhChoLabel.Location = new System.Drawing.Point(231, 136);
            danhChoLabel.Name = "danhChoLabel";
            danhChoLabel.Size = new System.Drawing.Size(58, 13);
            danhChoLabel.TabIndex = 25;
            danhChoLabel.Text = "Danh Cho:";
            // 
            // kichThuocLabel
            // 
            kichThuocLabel.AutoSize = true;
            kichThuocLabel.Location = new System.Drawing.Point(231, 162);
            kichThuocLabel.Name = "kichThuocLabel";
            kichThuocLabel.Size = new System.Drawing.Size(65, 13);
            kichThuocLabel.TabIndex = 27;
            kichThuocLabel.Text = "Kich Thuoc:";
            // 
            // moTaLabel
            // 
            moTaLabel.AutoSize = true;
            moTaLabel.Location = new System.Drawing.Point(467, 84);
            moTaLabel.Name = "moTaLabel";
            moTaLabel.Size = new System.Drawing.Size(41, 13);
            moTaLabel.TabIndex = 33;
            moTaLabel.Text = "Mo Ta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(538, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 13);
            label1.TabIndex = 38;
            label1.Text = "Đơn vị tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 13);
            label2.TabIndex = 40;
            label2.Text = "Nhãn hiệu:";
            // 
            // dataSet_MatHang
            // 
            this.dataSet_MatHang.DataSetName = "DataSet_MatHang";
            this.dataSet_MatHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            this.matHangBindingSource.DataSource = this.dataSet_MatHang;
            // 
            // matHangTableAdapter
            // 
            this.matHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.DM_NhanHieuTableAdapter = this.dM_NhanHieuTableAdapter;
            //this.tableAdapterManager.DonViTinhTableAdapter = this.donViTinhTableAdapter;
            this.tableAdapterManager.LoaiMatHangTableAdapter = this.loaiMatHangTableAdapter;
            this.tableAdapterManager.MatHangTableAdapter = this.matHangTableAdapter;
            this.tableAdapterManager.UpdateOrder = QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHangTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dM_NhanHieuTableAdapter
            // 
            this.dM_NhanHieuTableAdapter.ClearBeforeFill = true;
            // 
            // donViTinhTableAdapter
            // 
            this.donViTinhTableAdapter.ClearBeforeFill = true;
            // 
            // loaiMatHangTableAdapter
            // 
            this.loaiMatHangTableAdapter.ClearBeforeFill = true;
            // 
            // tenMHTextEdit
            // 
            this.tenMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHangBindingSource, "TenMH", true));
            this.tenMHTextEdit.Location = new System.Drawing.Point(90, 81);
            this.tenMHTextEdit.Name = "tenMHTextEdit";
            this.tenMHTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenMHTextEdit.TabIndex = 12;
            // 
            // giaVonSpinEdit
            // 
            this.giaVonSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHangBindingSource, "GiaVon", true));
            this.giaVonSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.giaVonSpinEdit.Location = new System.Drawing.Point(90, 107);
            this.giaVonSpinEdit.Name = "giaVonSpinEdit";
            this.giaVonSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.giaVonSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.giaVonSpinEdit.TabIndex = 14;
            // 
            // giaBanSiSpinEdit
            // 
            this.giaBanSiSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHangBindingSource, "GiaBanSi", true));
            this.giaBanSiSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.giaBanSiSpinEdit.Location = new System.Drawing.Point(90, 133);
            this.giaBanSiSpinEdit.Name = "giaBanSiSpinEdit";
            this.giaBanSiSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.giaBanSiSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.giaBanSiSpinEdit.TabIndex = 16;
            // 
            // giaBanLeSpinEdit
            // 
            this.giaBanLeSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHangBindingSource, "GiaBanLe", true));
            this.giaBanLeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.giaBanLeSpinEdit.Location = new System.Drawing.Point(90, 159);
            this.giaBanLeSpinEdit.Name = "giaBanLeSpinEdit";
            this.giaBanLeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.giaBanLeSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.giaBanLeSpinEdit.TabIndex = 18;
            // 
            // xuatXuTextEdit
            // 
            this.xuatXuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHangBindingSource, "XuatXu", true));
            this.xuatXuTextEdit.Location = new System.Drawing.Point(305, 81);
            this.xuatXuTextEdit.Name = "xuatXuTextEdit";
            this.xuatXuTextEdit.Size = new System.Drawing.Size(100, 20);
            this.xuatXuTextEdit.TabIndex = 22;
            // 
            // chatLieuTextEdit
            // 
            this.chatLieuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHangBindingSource, "ChatLieu", true));
            this.chatLieuTextEdit.Location = new System.Drawing.Point(305, 107);
            this.chatLieuTextEdit.Name = "chatLieuTextEdit";
            this.chatLieuTextEdit.Size = new System.Drawing.Size(100, 20);
            this.chatLieuTextEdit.TabIndex = 24;
            // 
            // danhChoTextEdit
            // 
            this.danhChoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHangBindingSource, "DanhCho", true));
            this.danhChoTextEdit.Location = new System.Drawing.Point(305, 133);
            this.danhChoTextEdit.Name = "danhChoTextEdit";
            this.danhChoTextEdit.Size = new System.Drawing.Size(100, 20);
            this.danhChoTextEdit.TabIndex = 26;
            // 
            // kichThuocTextEdit
            // 
            this.kichThuocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHangBindingSource, "KichThuoc", true));
            this.kichThuocTextEdit.Location = new System.Drawing.Point(305, 159);
            this.kichThuocTextEdit.Name = "kichThuocTextEdit";
            this.kichThuocTextEdit.Size = new System.Drawing.Size(100, 20);
            this.kichThuocTextEdit.TabIndex = 28;
            // 
            // donViTinhBindingSource
            // 
            this.donViTinhBindingSource.DataMember = "DonViTinh";
            this.donViTinhBindingSource.DataSource = this.dataSet_MatHang;
            // 
            // donViTinhComboBox
            // 
            this.donViTinhComboBox.DataSource = this.donViTinhBindingSource;
            this.donViTinhComboBox.DisplayMember = "TenDVT";
            this.donViTinhComboBox.FormattingEnabled = true;
            this.donViTinhComboBox.Location = new System.Drawing.Point(607, 32);
            this.donViTinhComboBox.Name = "donViTinhComboBox";
            this.donViTinhComboBox.Size = new System.Drawing.Size(106, 21);
            this.donViTinhComboBox.TabIndex = 37;
            this.donViTinhComboBox.ValueMember = "MaDVT";
            // 
            // dM_NhanHieuBindingSource
            // 
            this.dM_NhanHieuBindingSource.DataMember = "DM_NhanHieu";
            this.dM_NhanHieuBindingSource.DataSource = this.dataSet_MatHang;
            // 
            // dM_NhanHieuComboBox
            // 
            this.dM_NhanHieuComboBox.DataSource = this.dM_NhanHieuBindingSource;
            this.dM_NhanHieuComboBox.DisplayMember = "TenNH";
            this.dM_NhanHieuComboBox.FormattingEnabled = true;
            this.dM_NhanHieuComboBox.Location = new System.Drawing.Point(76, 32);
            this.dM_NhanHieuComboBox.Name = "dM_NhanHieuComboBox";
            this.dM_NhanHieuComboBox.Size = new System.Drawing.Size(160, 21);
            this.dM_NhanHieuComboBox.TabIndex = 39;
            this.dM_NhanHieuComboBox.ValueMember = "MaNH";
            // 
            // loaiMatHangBindingSource
            // 
            this.loaiMatHangBindingSource.DataMember = "LoaiMatHang";
            this.loaiMatHangBindingSource.DataSource = this.dataSet_MatHang;
            // 
            // loaiMatHangComboBox
            // 
            this.loaiMatHangComboBox.DataSource = this.loaiMatHangBindingSource;
            this.loaiMatHangComboBox.DisplayMember = "TenLoaiMH";
            this.loaiMatHangComboBox.FormattingEnabled = true;
            this.loaiMatHangComboBox.Location = new System.Drawing.Point(354, 32);
            this.loaiMatHangComboBox.Name = "loaiMatHangComboBox";
            this.loaiMatHangComboBox.Size = new System.Drawing.Size(164, 21);
            this.loaiMatHangComboBox.TabIndex = 40;
            this.loaiMatHangComboBox.ValueMember = "MaLoaiMH";
            // 
            // moTaTextEdit
            // 
            this.moTaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.matHangBindingSource, "MoTa", true));
            this.moTaTextEdit.Location = new System.Drawing.Point(514, 81);
            this.moTaTextEdit.Name = "moTaTextEdit";
            this.moTaTextEdit.Size = new System.Drawing.Size(199, 98);
            this.moTaTextEdit.TabIndex = 34;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(638, 213);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 41;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmThemMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 258);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.loaiMatHangComboBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.dM_NhanHieuComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.donViTinhComboBox);
            this.Controls.Add(maLoaiMHLabel);
            this.Controls.Add(tenMHLabel);
            this.Controls.Add(this.tenMHTextEdit);
            this.Controls.Add(giaVonLabel);
            this.Controls.Add(this.giaVonSpinEdit);
            this.Controls.Add(giaBanSiLabel);
            this.Controls.Add(this.giaBanSiSpinEdit);
            this.Controls.Add(giaBanLeLabel);
            this.Controls.Add(this.giaBanLeSpinEdit);
            this.Controls.Add(xuatXuLabel);
            this.Controls.Add(this.xuatXuTextEdit);
            this.Controls.Add(chatLieuLabel);
            this.Controls.Add(this.chatLieuTextEdit);
            this.Controls.Add(danhChoLabel);
            this.Controls.Add(this.danhChoTextEdit);
            this.Controls.Add(kichThuocLabel);
            this.Controls.Add(this.kichThuocTextEdit);
            this.Controls.Add(moTaLabel);
            this.Controls.Add(this.moTaTextEdit);
            this.Name = "frmThemMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM MẶT HÀNG";
            this.Load += new System.EventHandler(this.frmThemMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaVonSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaBanSiSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaBanLeSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuatXuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatLieuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhChoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kichThuocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_NhanHieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiMatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moTaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet_SQL.DataSet_MatHang dataSet_MatHang;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private DataSet_SQL.DataSet_MatHangTableAdapters.MatHangTableAdapter matHangTableAdapter;
        private DataSet_SQL.DataSet_MatHangTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit tenMHTextEdit;
        private DevExpress.XtraEditors.SpinEdit giaVonSpinEdit;
        private DevExpress.XtraEditors.SpinEdit giaBanSiSpinEdit;
        private DevExpress.XtraEditors.SpinEdit giaBanLeSpinEdit;
        private DevExpress.XtraEditors.TextEdit xuatXuTextEdit;
        private DevExpress.XtraEditors.TextEdit chatLieuTextEdit;
        private DevExpress.XtraEditors.TextEdit danhChoTextEdit;
        private DevExpress.XtraEditors.TextEdit kichThuocTextEdit;
        private DataSet_SQL.DataSet_MatHangTableAdapters.DonViTinhTableAdapter donViTinhTableAdapter;
        private System.Windows.Forms.BindingSource donViTinhBindingSource;
        private DataSet_SQL.DataSet_MatHangTableAdapters.DM_NhanHieuTableAdapter dM_NhanHieuTableAdapter;
        private System.Windows.Forms.ComboBox donViTinhComboBox;
        private System.Windows.Forms.BindingSource dM_NhanHieuBindingSource;
        private DataSet_SQL.DataSet_MatHangTableAdapters.LoaiMatHangTableAdapter loaiMatHangTableAdapter;
        private System.Windows.Forms.ComboBox dM_NhanHieuComboBox;
        private System.Windows.Forms.BindingSource loaiMatHangBindingSource;
        private System.Windows.Forms.ComboBox loaiMatHangComboBox;
        private DevExpress.XtraEditors.MemoEdit moTaTextEdit;
        private System.Windows.Forms.Button btnLuu;
    }
}