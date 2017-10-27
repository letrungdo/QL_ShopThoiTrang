namespace QL_ShopThoiTrang.DanhMuc
{
    partial class frmDonViTinh
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_ghiChu = new System.Windows.Forms.RichTextBox();
            this.txtTenDVT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBoxHinh = new System.Windows.Forms.PictureBox();
            this.dataSet_MatHang = new QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHang();
            this.donViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donViTinhTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHangTableAdapters.DonViTinhTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(214, 225);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đơn vị tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ghi chú:";
            // 
            // richTextBox_ghiChu
            // 
            this.richTextBox_ghiChu.Location = new System.Drawing.Point(93, 80);
            this.richTextBox_ghiChu.Name = "richTextBox_ghiChu";
            this.richTextBox_ghiChu.Size = new System.Drawing.Size(285, 123);
            this.richTextBox_ghiChu.TabIndex = 3;
            this.richTextBox_ghiChu.Text = "";
            // 
            // txtTenDVT
            // 
            this.txtTenDVT.Location = new System.Drawing.Point(129, 30);
            this.txtTenDVT.Name = "txtTenDVT";
            this.txtTenDVT.Size = new System.Drawing.Size(118, 20);
            this.txtTenDVT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ảnh:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(303, 225);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBoxHinh
            // 
            this.pictureBoxHinh.Image = global::QL_ShopThoiTrang.Properties.Resources.add;
            this.pictureBoxHinh.Location = new System.Drawing.Point(327, 12);
            this.pictureBoxHinh.Name = "pictureBoxHinh";
            this.pictureBoxHinh.Size = new System.Drawing.Size(51, 50);
            this.pictureBoxHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHinh.TabIndex = 8;
            this.pictureBoxHinh.TabStop = false;
            this.pictureBoxHinh.Click += new System.EventHandler(this.pictureBoxHinh_Click);
            // 
            // dataSet_MatHang
            // 
            this.dataSet_MatHang.DataSetName = "DataSet_MatHang";
            this.dataSet_MatHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donViTinhBindingSource
            // 
            this.donViTinhBindingSource.DataMember = "DonViTinh";
            this.donViTinhBindingSource.DataSource = this.dataSet_MatHang;
            // 
            // donViTinhTableAdapter
            // 
            this.donViTinhTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 268);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxHinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDVT);
            this.Controls.Add(this.richTextBox_ghiChu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDonViTinh";
            this.Text = "Đơn vị tính";
            this.Load += new System.EventHandler(this.frmDonViTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_ghiChu;
        private System.Windows.Forms.TextBox txtTenDVT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBoxHinh;
        private DataSet_SQL.DataSet_MatHang dataSet_MatHang;
        private System.Windows.Forms.BindingSource donViTinhBindingSource;
        private DataSet_SQL.DataSet_MatHangTableAdapters.DonViTinhTableAdapter donViTinhTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}