namespace WindowsFormsApplication1
{
    partial class LopHoc
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tenlop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.magv = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xemlop = new System.Windows.Forms.ComboBox();
            this.btnChuyenlop = new System.Windows.Forms.Button();
            this.lopmoi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tenhs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHocsinhchuaxeplop = new System.Windows.Forms.Button();
            this.btnXemlop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(18, 208);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.Size = new System.Drawing.Size(687, 294);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Lớp:";
            // 
            // tenlop
            // 
            this.tenlop.Location = new System.Drawing.Point(9, 31);
            this.tenlop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tenlop.Name = "tenlop";
            this.tenlop.Size = new System.Drawing.Size(122, 26);
            this.tenlop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giáo viên chủ nhiệm:";
            // 
            // magv
            // 
            this.magv.FormattingEnabled = true;
            this.magv.Location = new System.Drawing.Point(9, 106);
            this.magv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.magv.Name = "magv";
            this.magv.Size = new System.Drawing.Size(236, 28);
            this.magv.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(344, 26);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(344, 82);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 35);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(344, 143);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 35);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.tenlop);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.magv);
            this.panel1.Location = new System.Drawing.Point(18, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 189);
            this.panel1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(726, 546);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(718, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách Lớp Học";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dg);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(718, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết Lớp Học";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(10, 223);
            this.dg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 62;
            this.dg.Size = new System.Drawing.Size(694, 283);
            this.dg.TabIndex = 1;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xemlop);
            this.panel2.Controls.Add(this.btnChuyenlop);
            this.panel2.Controls.Add(this.lopmoi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tenhs);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnHocsinhchuaxeplop);
            this.panel2.Controls.Add(this.btnXemlop);
            this.panel2.Location = new System.Drawing.Point(10, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 202);
            this.panel2.TabIndex = 0;
            // 
            // xemlop
            // 
            this.xemlop.FormattingEnabled = true;
            this.xemlop.Location = new System.Drawing.Point(6, 6);
            this.xemlop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xemlop.Name = "xemlop";
            this.xemlop.Size = new System.Drawing.Size(128, 28);
            this.xemlop.TabIndex = 8;
            // 
            // btnChuyenlop
            // 
            this.btnChuyenlop.Location = new System.Drawing.Point(381, 149);
            this.btnChuyenlop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChuyenlop.Name = "btnChuyenlop";
            this.btnChuyenlop.Size = new System.Drawing.Size(112, 35);
            this.btnChuyenlop.TabIndex = 7;
            this.btnChuyenlop.Text = "Chuyển lớp";
            this.btnChuyenlop.UseVisualStyleBackColor = true;
            this.btnChuyenlop.Click += new System.EventHandler(this.btnChuyenlop_Click);
            // 
            // lopmoi
            // 
            this.lopmoi.FormattingEnabled = true;
            this.lopmoi.Location = new System.Drawing.Point(381, 92);
            this.lopmoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lopmoi.Name = "lopmoi";
            this.lopmoi.Size = new System.Drawing.Size(109, 28);
            this.lopmoi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chọn lớp:";
            // 
            // tenhs
            // 
            this.tenhs.Enabled = false;
            this.tenhs.Location = new System.Drawing.Point(381, 32);
            this.tenhs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tenhs.Name = "tenhs";
            this.tenhs.Size = new System.Drawing.Size(260, 26);
            this.tenhs.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên học sinh:";
            // 
            // btnHocsinhchuaxeplop
            // 
            this.btnHocsinhchuaxeplop.Location = new System.Drawing.Point(6, 137);
            this.btnHocsinhchuaxeplop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHocsinhchuaxeplop.Name = "btnHocsinhchuaxeplop";
            this.btnHocsinhchuaxeplop.Size = new System.Drawing.Size(130, 60);
            this.btnHocsinhchuaxeplop.TabIndex = 2;
            this.btnHocsinhchuaxeplop.Text = "Học sinh chưa xếp lớp";
            this.btnHocsinhchuaxeplop.UseVisualStyleBackColor = true;
            this.btnHocsinhchuaxeplop.Click += new System.EventHandler(this.btnHocsinhchuaxeplop_Click);
            // 
            // btnXemlop
            // 
            this.btnXemlop.Location = new System.Drawing.Point(6, 48);
            this.btnXemlop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemlop.Name = "btnXemlop";
            this.btnXemlop.Size = new System.Drawing.Size(112, 35);
            this.btnXemlop.TabIndex = 1;
            this.btnXemlop.Text = "Xem Lớp";
            this.btnXemlop.UseVisualStyleBackColor = true;
            this.btnXemlop.Click += new System.EventHandler(this.btnXemlop_Click);
            // 
            // LopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 575);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LopHoc";
            this.Text = "Quản lý Lớp Học";
            this.Load += new System.EventHandler(this.LopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenlop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox magv;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChuyenlop;
        private System.Windows.Forms.ComboBox lopmoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tenhs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHocsinhchuaxeplop;
        private System.Windows.Forms.Button btnXemlop;
        private System.Windows.Forms.ComboBox xemlop;
    }
}