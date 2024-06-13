namespace WindowsFormsApplication1
{
    partial class TrangChuMoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuMoi));
            this.panelTaskbar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lbTrangchu = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuanlytaikhoan = new System.Windows.Forms.Button();
            this.btnGiaovien = new System.Windows.Forms.Button();
            this.btnMonhoc = new System.Windows.Forms.Button();
            this.btnLophoc = new System.Windows.Forms.Button();
            this.btnDiemdanh = new System.Windows.Forms.Button();
            this.btnBangdiem = new System.Windows.Forms.Button();
            this.btnThoikhoabieu = new System.Windows.Forms.Button();
            this.btnHocsinh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelParent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTaskbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTaskbar
            // 
            this.panelTaskbar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.home_tabbar;
            this.panelTaskbar.Controls.Add(this.labelTitle);
            this.panelTaskbar.Controls.Add(this.lbTrangchu);
            this.panelTaskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTaskbar.Location = new System.Drawing.Point(253, 0);
            this.panelTaskbar.Name = "panelTaskbar";
            this.panelTaskbar.Size = new System.Drawing.Size(1089, 54);
            this.panelTaskbar.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Navy;
            this.labelTitle.Location = new System.Drawing.Point(485, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(123, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Trang chủ";
            // 
            // lbTrangchu
            // 
            this.lbTrangchu.AutoSize = true;
            this.lbTrangchu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbTrangchu.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangchu.ForeColor = System.Drawing.Color.Navy;
            this.lbTrangchu.Location = new System.Drawing.Point(3, 9);
            this.lbTrangchu.Name = "lbTrangchu";
            this.lbTrangchu.Size = new System.Drawing.Size(121, 32);
            this.lbTrangchu.TabIndex = 0;
            this.lbTrangchu.Text = "Xin chào";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnQuanlytaikhoan);
            this.panel1.Controls.Add(this.btnGiaovien);
            this.panel1.Controls.Add(this.btnMonhoc);
            this.panel1.Controls.Add(this.btnLophoc);
            this.panel1.Controls.Add(this.btnDiemdanh);
            this.panel1.Controls.Add(this.btnBangdiem);
            this.panel1.Controls.Add(this.btnThoikhoabieu);
            this.panel1.Controls.Add(this.btnHocsinh);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 705);
            this.panel1.TabIndex = 0;
            // 
            // btnQuanlytaikhoan
            // 
            this.btnQuanlytaikhoan.BackColor = System.Drawing.Color.White;
            this.btnQuanlytaikhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuanlytaikhoan.BackgroundImage")));
            this.btnQuanlytaikhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanlytaikhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanlytaikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanlytaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanlytaikhoan.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanlytaikhoan.ForeColor = System.Drawing.Color.Navy;
            this.btnQuanlytaikhoan.Location = new System.Drawing.Point(0, 632);
            this.btnQuanlytaikhoan.Name = "btnQuanlytaikhoan";
            this.btnQuanlytaikhoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnQuanlytaikhoan.Size = new System.Drawing.Size(227, 79);
            this.btnQuanlytaikhoan.TabIndex = 15;
            this.btnQuanlytaikhoan.Text = "Quản lý tài khoản";
            this.btnQuanlytaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanlytaikhoan.UseVisualStyleBackColor = false;
            this.btnQuanlytaikhoan.Click += new System.EventHandler(this.btnQuanlytaikhoan_Click);
            // 
            // btnGiaovien
            // 
            this.btnGiaovien.BackColor = System.Drawing.Color.White;
            this.btnGiaovien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiaovien.BackgroundImage")));
            this.btnGiaovien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiaovien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaovien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiaovien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaovien.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaovien.ForeColor = System.Drawing.Color.Navy;
            this.btnGiaovien.Location = new System.Drawing.Point(0, 553);
            this.btnGiaovien.Name = "btnGiaovien";
            this.btnGiaovien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGiaovien.Size = new System.Drawing.Size(227, 79);
            this.btnGiaovien.TabIndex = 16;
            this.btnGiaovien.Text = "Giáo viên";
            this.btnGiaovien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaovien.UseVisualStyleBackColor = false;
            this.btnGiaovien.Click += new System.EventHandler(this.btnGiaovien_Click);
            // 
            // btnMonhoc
            // 
            this.btnMonhoc.BackColor = System.Drawing.Color.White;
            this.btnMonhoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMonhoc.BackgroundImage")));
            this.btnMonhoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonhoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonhoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonhoc.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonhoc.ForeColor = System.Drawing.Color.Navy;
            this.btnMonhoc.Location = new System.Drawing.Point(0, 474);
            this.btnMonhoc.Name = "btnMonhoc";
            this.btnMonhoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMonhoc.Size = new System.Drawing.Size(227, 79);
            this.btnMonhoc.TabIndex = 14;
            this.btnMonhoc.Text = "Môn học";
            this.btnMonhoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonhoc.UseVisualStyleBackColor = false;
            this.btnMonhoc.Click += new System.EventHandler(this.btnMonhoc_Click);
            // 
            // btnLophoc
            // 
            this.btnLophoc.BackColor = System.Drawing.Color.White;
            this.btnLophoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLophoc.BackgroundImage")));
            this.btnLophoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLophoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLophoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLophoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLophoc.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLophoc.ForeColor = System.Drawing.Color.Navy;
            this.btnLophoc.Location = new System.Drawing.Point(0, 395);
            this.btnLophoc.Name = "btnLophoc";
            this.btnLophoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLophoc.Size = new System.Drawing.Size(227, 79);
            this.btnLophoc.TabIndex = 13;
            this.btnLophoc.Text = "Lớp học";
            this.btnLophoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLophoc.UseVisualStyleBackColor = false;
            this.btnLophoc.Click += new System.EventHandler(this.btnLophoc_Click);
            // 
            // btnDiemdanh
            // 
            this.btnDiemdanh.BackColor = System.Drawing.Color.White;
            this.btnDiemdanh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiemdanh.BackgroundImage")));
            this.btnDiemdanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiemdanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiemdanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemdanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemdanh.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemdanh.ForeColor = System.Drawing.Color.Navy;
            this.btnDiemdanh.Location = new System.Drawing.Point(0, 316);
            this.btnDiemdanh.Name = "btnDiemdanh";
            this.btnDiemdanh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDiemdanh.Size = new System.Drawing.Size(227, 79);
            this.btnDiemdanh.TabIndex = 12;
            this.btnDiemdanh.Text = "Điểm danh";
            this.btnDiemdanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemdanh.UseVisualStyleBackColor = false;
            this.btnDiemdanh.Click += new System.EventHandler(this.btnDiemdanh_Click);
            // 
            // btnBangdiem
            // 
            this.btnBangdiem.BackColor = System.Drawing.Color.White;
            this.btnBangdiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBangdiem.BackgroundImage")));
            this.btnBangdiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBangdiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBangdiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBangdiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBangdiem.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangdiem.ForeColor = System.Drawing.Color.Navy;
            this.btnBangdiem.Location = new System.Drawing.Point(0, 237);
            this.btnBangdiem.Name = "btnBangdiem";
            this.btnBangdiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBangdiem.Size = new System.Drawing.Size(227, 79);
            this.btnBangdiem.TabIndex = 11;
            this.btnBangdiem.Text = "Bảng điểm";
            this.btnBangdiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBangdiem.UseVisualStyleBackColor = false;
            this.btnBangdiem.Click += new System.EventHandler(this.btnBangdiem_Click);
            // 
            // btnThoikhoabieu
            // 
            this.btnThoikhoabieu.BackColor = System.Drawing.Color.White;
            this.btnThoikhoabieu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoikhoabieu.BackgroundImage")));
            this.btnThoikhoabieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoikhoabieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoikhoabieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThoikhoabieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoikhoabieu.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoikhoabieu.ForeColor = System.Drawing.Color.Navy;
            this.btnThoikhoabieu.Location = new System.Drawing.Point(0, 158);
            this.btnThoikhoabieu.Name = "btnThoikhoabieu";
            this.btnThoikhoabieu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThoikhoabieu.Size = new System.Drawing.Size(227, 79);
            this.btnThoikhoabieu.TabIndex = 10;
            this.btnThoikhoabieu.Text = "Thời khóa biểu";
            this.btnThoikhoabieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoikhoabieu.UseVisualStyleBackColor = false;
            this.btnThoikhoabieu.Click += new System.EventHandler(this.btnThoikhoabieu_Click);
            // 
            // btnHocsinh
            // 
            this.btnHocsinh.BackColor = System.Drawing.Color.White;
            this.btnHocsinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHocsinh.BackgroundImage")));
            this.btnHocsinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHocsinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHocsinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHocsinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocsinh.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocsinh.ForeColor = System.Drawing.Color.Navy;
            this.btnHocsinh.Location = new System.Drawing.Point(0, 79);
            this.btnHocsinh.Name = "btnHocsinh";
            this.btnHocsinh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHocsinh.Size = new System.Drawing.Size(227, 79);
            this.btnHocsinh.TabIndex = 8;
            this.btnHocsinh.Text = "Học Sinh";
            this.btnHocsinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocsinh.UseVisualStyleBackColor = false;
            this.btnHocsinh.Click += new System.EventHandler(this.btnHocsinh_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.background;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Navy;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(227, 79);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelParent
            // 
            this.panelParent.Controls.Add(this.pictureBox1);
            this.panelParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParent.Location = new System.Drawing.Point(253, 54);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(1089, 651);
            this.panelParent.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.background_home;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1089, 651);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TrangChuMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 705);
            this.Controls.Add(this.panelParent);
            this.Controls.Add(this.panelTaskbar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TrangChuMoi";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.TrangChuMoi_Load);
            this.panelTaskbar.ResumeLayout(false);
            this.panelTaskbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelTaskbar;
        private System.Windows.Forms.Button btnQuanlytaikhoan;
        private System.Windows.Forms.Button btnGiaovien;
        private System.Windows.Forms.Button btnMonhoc;
        private System.Windows.Forms.Button btnLophoc;
        private System.Windows.Forms.Button btnDiemdanh;
        private System.Windows.Forms.Button btnBangdiem;
        private System.Windows.Forms.Button btnThoikhoabieu;
        private System.Windows.Forms.Button btnHocsinh;
        private System.Windows.Forms.Label lbTrangchu;
        private System.Windows.Forms.Panel panelParent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
    }
}