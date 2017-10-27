namespace QL_ShopThoiTrang.DanhMuc
{
    partial class frmNhanHieu
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNH = new System.Windows.Forms.TextBox();
            this.richTextBox_ghiChu = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pictureBoxHinh = new System.Windows.Forms.PictureBox();
            this.dataSet_MatHang = new QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHang();
            this.dM_NhanHieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_NhanHieuTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHangTableAdapters.DM_NhanHieuTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_NhanHieuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(295, 213);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ảnh:";
            // 
            // txtTenNH
            // 
            this.txtTenNH.Location = new System.Drawing.Point(121, 18);
            this.txtTenNH.Name = "txtTenNH";
            this.txtTenNH.Size = new System.Drawing.Size(118, 20);
            this.txtTenNH.TabIndex = 12;
            // 
            // richTextBox_ghiChu
            // 
            this.richTextBox_ghiChu.Location = new System.Drawing.Point(85, 68);
            this.richTextBox_ghiChu.Name = "richTextBox_ghiChu";
            this.richTextBox_ghiChu.Size = new System.Drawing.Size(285, 123);
            this.richTextBox_ghiChu.TabIndex = 11;
            this.richTextBox_ghiChu.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ghi chú:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên nhãn hiệu:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(206, 213);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pictureBoxHinh
            // 
            this.pictureBoxHinh.Image = global::QL_ShopThoiTrang.Properties.Resources.add;
            this.pictureBoxHinh.Location = new System.Drawing.Point(304, 12);
            this.pictureBoxHinh.Name = "pictureBoxHinh";
            this.pictureBoxHinh.Size = new System.Drawing.Size(54, 50);
            this.pictureBoxHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHinh.TabIndex = 16;
            this.pictureBoxHinh.TabStop = false;
            this.pictureBoxHinh.Click += new System.EventHandler(this.pictureBoxHinh_Click);
            // 
            // dataSet_MatHang
            // 
            this.dataSet_MatHang.DataSetName = "DataSet_MatHang";
            this.dataSet_MatHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dM_NhanHieuBindingSource
            // 
            this.dM_NhanHieuBindingSource.DataMember = "DM_NhanHieu";
            this.dM_NhanHieuBindingSource.DataSource = this.dataSet_MatHang;
            // 
            // dM_NhanHieuTableAdapter
            // 
            this.dM_NhanHieuTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNhanHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 261);
            this.Controls.Add(this.pictureBoxHinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNH);
            this.Controls.Add(this.richTextBox_ghiChu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhanHieu";
            this.Text = "Nhãn hiệu";
            this.Load += new System.EventHandler(this.frmNhanHieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dM_NhanHieuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNH;
        private System.Windows.Forms.RichTextBox richTextBox_ghiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.PictureBox pictureBoxHinh;
        private DataSet_SQL.DataSet_MatHang dataSet_MatHang;
        private System.Windows.Forms.BindingSource dM_NhanHieuBindingSource;
        private DataSet_SQL.DataSet_MatHangTableAdapters.DM_NhanHieuTableAdapter dM_NhanHieuTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}