namespace QL_ShopThoiTrang.Account
{
    partial class frmPhanQuyen
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
            this.qL_NhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_QL_NguoiDung = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDung();
            this.btnLuu = new System.Windows.Forms.Button();
            this.phanQuyen_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhomNguoiDungTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.tableAdapterManager = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.TableAdapterManager();
            this.phanQuyen_DKTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.PhanQuyen_DKTableAdapter();
            this.qL_PhanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_PhanQuyenTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.QL_PhanQuyenTableAdapter();
            this.phanQuyen_DKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_QL_NguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen_DKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen_DKDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // qL_NhomNguoiDungDataGridView
            // 
            this.qL_NhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.qL_NhomNguoiDungDataGridView.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungDataGridView.Location = new System.Drawing.Point(17, 31);
            this.qL_NhomNguoiDungDataGridView.Name = "qL_NhomNguoiDungDataGridView";
            this.qL_NhomNguoiDungDataGridView.Size = new System.Drawing.Size(331, 239);
            this.qL_NhomNguoiDungDataGridView.TabIndex = 1;
            this.qL_NhomNguoiDungDataGridView.SelectionChanged += new System.EventHandler(this.qL_NhomNguoiDungDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNhom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenNhom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // qL_NhomNguoiDungBindingSource
            // 
            this.qL_NhomNguoiDungBindingSource.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource.DataSource = this.dataSet_QL_NguoiDung;
            // 
            // dataSet_QL_NguoiDung
            // 
            this.dataSet_QL_NguoiDung.DataSetName = "DataSet_QL_NguoiDung";
            this.dataSet_QL_NguoiDung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(370, 126);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // phanQuyen_DKBindingSource
            // 
            this.phanQuyen_DKBindingSource.DataMember = "PhanQuyen_DK";
            this.phanQuyen_DKBindingSource.DataSource = this.dataSet_QL_NguoiDung;
            // 
            // qL_NhomNguoiDungTableAdapter
            // 
            this.qL_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = this.qL_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_NV_NhomNguoiDungDKTableAdapter = null;
            this.tableAdapterManager.QL_NV_NhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_ShopThoiTrang.DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // phanQuyen_DKTableAdapter
            // 
            this.phanQuyen_DKTableAdapter.ClearBeforeFill = true;
            // 
            // qL_PhanQuyenBindingSource
            // 
            this.qL_PhanQuyenBindingSource.DataMember = "QL_PhanQuyen";
            this.qL_PhanQuyenBindingSource.DataSource = this.dataSet_QL_NguoiDung;
            // 
            // qL_PhanQuyenTableAdapter
            // 
            this.qL_PhanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // phanQuyen_DKDataGridView
            // 
            this.phanQuyen_DKDataGridView.AllowUserToAddRows = false;
            this.phanQuyen_DKDataGridView.AutoGenerateColumns = false;
            this.phanQuyen_DKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phanQuyen_DKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.phanQuyen_DKDataGridView.DataSource = this.phanQuyen_DKBindingSource;
            this.phanQuyen_DKDataGridView.Location = new System.Drawing.Point(467, 31);
            this.phanQuyen_DKDataGridView.Name = "phanQuyen_DKDataGridView";
            this.phanQuyen_DKDataGridView.Size = new System.Drawing.Size(338, 239);
            this.phanQuyen_DKDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaManHinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "TenManHinh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.HeaderText = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 320);
            this.Controls.Add(this.phanQuyen_DKDataGridView);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.qL_NhomNguoiDungDataGridView);
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_QL_NguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen_DKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyen_DKDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet_SQL.DataSet_QL_NguoiDung dataSet_QL_NguoiDung;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView qL_NhomNguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.BindingSource phanQuyen_DKBindingSource;
        private DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.PhanQuyen_DKTableAdapter phanQuyen_DKTableAdapter;
        private System.Windows.Forms.BindingSource qL_PhanQuyenBindingSource;
        private DataSet_SQL.DataSet_QL_NguoiDungTableAdapters.QL_PhanQuyenTableAdapter qL_PhanQuyenTableAdapter;
        private System.Windows.Forms.DataGridView phanQuyen_DKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}