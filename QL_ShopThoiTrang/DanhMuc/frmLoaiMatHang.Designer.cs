namespace QL_ShopThoiTrang.DanhMuc
{
    partial class frmLoaiMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiMatHang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTruoc = new System.Windows.Forms.ToolStripButton();
            this.btnSau = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTaoMoi = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxHinh = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataSet_MatHang = new QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHang();
            this.loaiMatHangTableAdapter = new QL_ShopThoiTrang.DataSet_SQL.DataSet_MatHangTableAdapters.LoaiMatHangTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTruoc,
            this.btnSau,
            this.toolStripSeparator2,
            this.btnTaoMoi,
            this.btnXoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(520, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTruoc
            // 
            this.btnTruoc.Image = global::QL_ShopThoiTrang.Properties.Resources.left_arrow;
            this.btnTruoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(86, 22);
            this.btnTruoc.Text = "Trước (F10)";
            // 
            // btnSau
            // 
            this.btnSau.Image = global::QL_ShopThoiTrang.Properties.Resources.right_arrow;
            this.btnSau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(75, 22);
            this.btnSau.Text = "Sau (F11)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Image = global::QL_ShopThoiTrang.Properties.Resources.add;
            this.btnTaoMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(71, 22);
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QL_ShopThoiTrang.Properties.Resources.delete;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên loại mặt hàng:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(130, 41);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(181, 20);
            this.txtTen.TabIndex = 2;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(130, 71);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(181, 20);
            this.txtMa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã loại mặt hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 104);
            this.label3.MaximumSize = new System.Drawing.Size(260, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Ví dụ: Bạn đặt mã AO cho nhóm áo, thì các sản phẩm trong nhóm này sẽ có mã tự si" +
    "nh bắt đầu bằng AO: AO001, AO002,...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ảnh:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(378, 179);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageIndex = 0;
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(300, 179);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(60, 30);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save.png");
            // 
            // pictureBoxHinh
            // 
            this.pictureBoxHinh.Image = global::QL_ShopThoiTrang.Properties.Resources.refresh;
            this.pictureBoxHinh.Location = new System.Drawing.Point(399, 28);
            this.pictureBoxHinh.Name = "pictureBoxHinh";
            this.pictureBoxHinh.Size = new System.Drawing.Size(66, 64);
            this.pictureBoxHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHinh.TabIndex = 12;
            this.pictureBoxHinh.TabStop = false;
            this.pictureBoxHinh.Click += new System.EventHandler(this.pictureBoxHinh_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataSet_MatHang
            // 
            this.dataSet_MatHang.DataSetName = "DataSet_MatHang";
            this.dataSet_MatHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiMatHangTableAdapter
            // 
            this.loaiMatHangTableAdapter.ClearBeforeFill = true;
            // 
            // frmLoaiMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(520, 226);
            this.Controls.Add(this.pictureBoxHinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoaiMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOẠI MẶT HÀNG";
            this.Load += new System.EventHandler(this.frmLoaiMatHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_MatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton btnTruoc;
        private System.Windows.Forms.ToolStripButton btnSau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnTaoMoi;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ImageList imageList1;
        private DataSet_SQL.DataSet_MatHang dataSet_MatHang;
        private DataSet_SQL.DataSet_MatHangTableAdapters.LoaiMatHangTableAdapter loaiMatHangTableAdapter;
        private System.Windows.Forms.PictureBox pictureBoxHinh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}