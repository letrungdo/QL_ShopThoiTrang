namespace QL_ShopThoiTrang.Account
{
    partial class frmThemNguoiDungVaoNhom
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
            this.qL_NV_NhomNguoiDungDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_QL_NguoiDung = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDung();
            this.qL_NhomNguoiDungComboBox = new System.Windows.Forms.ComboBox();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVien_Nhom_DKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVien_Nhom_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuu = new System.Windows.Forms.Button();
            this.qL_NV_NhomNguoiDungDKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.qL_NV_NhomNguoiDungDKTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.QL_NV_NhomNguoiDungDKTableAdapter();
            this.tableAdapterManager = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.TableAdapterManager();
            this.qL_NhomNguoiDungTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.nhanVien_Nhom_DKTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.NhanVien_Nhom_DKTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NV_NhomNguoiDungDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_QL_NguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVien_Nhom_DKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVien_Nhom_DKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NV_NhomNguoiDungDKDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // qL_NV_NhomNguoiDungDKBindingSource
            // 
            this.qL_NV_NhomNguoiDungDKBindingSource.DataMember = "QL_NV_NhomNguoiDungDK";
            this.qL_NV_NhomNguoiDungDKBindingSource.DataSource = this.dataSet_QL_NguoiDung;
            // 
            // dataSet_QL_NguoiDung
            // 
            this.dataSet_QL_NguoiDung.DataSetName = "DataSet_QL_NguoiDung";
            this.dataSet_QL_NguoiDung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NhomNguoiDungComboBox
            // 
            this.qL_NhomNguoiDungComboBox.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungComboBox.DisplayMember = "MaNhom";
            this.qL_NhomNguoiDungComboBox.FormattingEnabled = true;
            this.qL_NhomNguoiDungComboBox.Location = new System.Drawing.Point(295, 48);
            this.qL_NhomNguoiDungComboBox.Name = "qL_NhomNguoiDungComboBox";
            this.qL_NhomNguoiDungComboBox.Size = new System.Drawing.Size(244, 21);
            this.qL_NhomNguoiDungComboBox.TabIndex = 3;
            this.qL_NhomNguoiDungComboBox.ValueMember = "MaNhom";
            this.qL_NhomNguoiDungComboBox.SelectedIndexChanged += new System.EventHandler(this.qL_NhomNguoiDungComboBox_SelectedIndexChanged);
            // 
            // qL_NhomNguoiDungBindingSource
            // 
            this.qL_NhomNguoiDungBindingSource.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource.DataSource = this.dataSet_QL_NguoiDung;
            // 
            // nhanVien_Nhom_DKDataGridView
            // 
            this.nhanVien_Nhom_DKDataGridView.AutoGenerateColumns = false;
            this.nhanVien_Nhom_DKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVien_Nhom_DKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn15});
            this.nhanVien_Nhom_DKDataGridView.DataSource = this.nhanVien_Nhom_DKBindingSource;
            this.nhanVien_Nhom_DKDataGridView.Location = new System.Drawing.Point(41, 107);
            this.nhanVien_Nhom_DKDataGridView.Name = "nhanVien_Nhom_DKDataGridView";
            this.nhanVien_Nhom_DKDataGridView.Size = new System.Drawing.Size(329, 220);
            this.nhanVien_Nhom_DKDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn4.HeaderText = "Username";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn5.HeaderText = "Password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn15.HeaderText = "MaNhom";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // nhanVien_Nhom_DKBindingSource
            // 
            this.nhanVien_Nhom_DKBindingSource.DataMember = "NhanVien_Nhom_DK";
            this.nhanVien_Nhom_DKBindingSource.DataSource = this.dataSet_QL_NguoiDung;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(407, 161);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = ">>";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // qL_NV_NhomNguoiDungDKDataGridView
            // 
            this.qL_NV_NhomNguoiDungDKDataGridView.AutoGenerateColumns = false;
            this.qL_NV_NhomNguoiDungDKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NV_NhomNguoiDungDKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.qL_NV_NhomNguoiDungDKDataGridView.DataSource = this.qL_NV_NhomNguoiDungDKBindingSource;
            this.qL_NV_NhomNguoiDungDKDataGridView.Location = new System.Drawing.Point(519, 107);
            this.qL_NV_NhomNguoiDungDKDataGridView.Name = "qL_NV_NhomNguoiDungDKDataGridView";
            this.qL_NV_NhomNguoiDungDKDataGridView.Size = new System.Drawing.Size(339, 220);
            this.qL_NV_NhomNguoiDungDKDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn1.HeaderText = "Username";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaNhom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(407, 218);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // qL_NV_NhomNguoiDungDKTableAdapter
            // 
            this.qL_NV_NhomNguoiDungDKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = this.qL_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_NV_NhomNguoiDungDKTableAdapter = this.qL_NV_NhomNguoiDungDKTableAdapter;
            this.tableAdapterManager.QL_NV_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NhomNguoiDungTableAdapter
            // 
            this.qL_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVien_Nhom_DKTableAdapter
            // 
            this.nhanVien_Nhom_DKTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn nhóm:";
            // 
            // frmThemNguoiDungVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.qL_NV_NhomNguoiDungDKDataGridView);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.nhanVien_Nhom_DKDataGridView);
            this.Controls.Add(this.qL_NhomNguoiDungComboBox);
            this.Name = "frmThemNguoiDungVaoNhom";
            this.Text = "frmThemNguoiDungVaoNhom";
            this.Load += new System.EventHandler(this.frmThemNguoiDungVaoNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NV_NhomNguoiDungDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_QL_NguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVien_Nhom_DKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVien_Nhom_DKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NV_NhomNguoiDungDKDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet_SQL.DataSet_QL_NguoiDung dataSet_QL_NguoiDung;
        private System.Windows.Forms.BindingSource qL_NV_NhomNguoiDungDKBindingSource;
        private DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.QL_NV_NhomNguoiDungDKTableAdapter qL_NV_NhomNguoiDungDKTableAdapter;
        private DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox qL_NhomNguoiDungComboBox;
        private System.Windows.Forms.BindingSource nhanVien_Nhom_DKBindingSource;
        private DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.NhanVien_Nhom_DKTableAdapter nhanVien_Nhom_DKTableAdapter;
        
        private System.Windows.Forms.DataGridView nhanVien_Nhom_DKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView qL_NV_NhomNguoiDungDKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}