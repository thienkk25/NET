namespace WindowsFormsApplication1
{
    partial class BangDiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.ttkt = new System.Windows.Forms.ComboBox();
            this.ttk = new System.Windows.Forms.TextBox();
            this.ghs = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.tdiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tmh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbd = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tmhs = new System.Windows.Forms.Label();
            this.tths = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gdg = new System.Windows.Forms.DataGridView();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnCapnhat1 = new System.Windows.Forms.Button();
            this.tnx = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.thk = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ghs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbd)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.ttkt);
            this.groupBox1.Controls.Add(this.ttk);
            this.groupBox1.Controls.Add(this.ghs);
            this.groupBox1.Location = new System.Drawing.Point(18, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(506, 678);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Học Sinh";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(170, 91);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(112, 35);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // ttkt
            // 
            this.ttkt.FormattingEnabled = true;
            this.ttkt.Items.AddRange(new object[] {
            "Tên Lớp",
            "Tên Học Sinh",
            "Mã Học Sinh"});
            this.ttkt.Location = new System.Drawing.Point(10, 91);
            this.ttkt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ttkt.Name = "ttkt";
            this.ttkt.Size = new System.Drawing.Size(146, 28);
            this.ttkt.TabIndex = 2;
            // 
            // ttk
            // 
            this.ttk.Location = new System.Drawing.Point(10, 49);
            this.ttk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ttk.Name = "ttk";
            this.ttk.Size = new System.Drawing.Size(270, 26);
            this.ttk.TabIndex = 1;
            // 
            // ghs
            // 
            this.ghs.AllowUserToAddRows = false;
            this.ghs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ghs.Location = new System.Drawing.Point(9, 180);
            this.ghs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ghs.Name = "ghs";
            this.ghs.RowHeadersWidth = 62;
            this.ghs.Size = new System.Drawing.Size(489, 486);
            this.ghs.TabIndex = 0;
            this.ghs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ghs_CellContentClick);
            this.ghs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ghs_CellContentClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(500, 242);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 35);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(378, 242);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(112, 35);
            this.btnCapnhat.TabIndex = 7;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // tdiem
            // 
            this.tdiem.Location = new System.Drawing.Point(378, 169);
            this.tdiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tdiem.Name = "tdiem";
            this.tdiem.Size = new System.Drawing.Size(110, 26);
            this.tdiem.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập điểm:";
            // 
            // tmh
            // 
            this.tmh.FormattingEnabled = true;
            this.tmh.Location = new System.Drawing.Point(378, 91);
            this.tmh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tmh.Name = "tmh";
            this.tmh.Size = new System.Drawing.Size(184, 28);
            this.tmh.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Môn học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã học sinh:";
            // 
            // gbd
            // 
            this.gbd.AllowUserToAddRows = false;
            this.gbd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gbd.Location = new System.Drawing.Point(9, 66);
            this.gbd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbd.Name = "gbd";
            this.gbd.RowHeadersWidth = 62;
            this.gbd.Size = new System.Drawing.Size(339, 320);
            this.gbd.TabIndex = 0;
            this.gbd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gbd_CellContentClick);
            this.gbd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gbd_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên học sinh:";
            // 
            // tmhs
            // 
            this.tmhs.AutoSize = true;
            this.tmhs.Location = new System.Drawing.Point(122, 14);
            this.tmhs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tmhs.Name = "tmhs";
            this.tmhs.Size = new System.Drawing.Size(21, 20);
            this.tmhs.TabIndex = 10;
            this.tmhs.Text = "...";
            // 
            // tths
            // 
            this.tths.AutoSize = true;
            this.tths.Location = new System.Drawing.Point(122, 43);
            this.tths.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tths.Name = "tths";
            this.tths.Size = new System.Drawing.Size(21, 20);
            this.tths.TabIndex = 11;
            this.tths.Text = "...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(579, 180);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 477);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tdiem);
            this.tabPage1.Controls.Add(this.tmh);
            this.tabPage1.Controls.Add(this.btnCapnhat);
            this.tabPage1.Controls.Add(this.gbd);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(618, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bảng Điểm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gdg);
            this.tabPage2.Controls.Add(this.btnXoa1);
            this.tabPage2.Controls.Add(this.btnCapnhat1);
            this.tabPage2.Controls.Add(this.tnx);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txl);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.thk);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(618, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đánh Giá";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gdg
            // 
            this.gdg.AllowUserToAddRows = false;
            this.gdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdg.Location = new System.Drawing.Point(14, 249);
            this.gdg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdg.Name = "gdg";
            this.gdg.RowHeadersWidth = 62;
            this.gdg.Size = new System.Drawing.Size(586, 115);
            this.gdg.TabIndex = 8;
            // 
            // btnXoa1
            // 
            this.btnXoa1.Location = new System.Drawing.Point(414, 194);
            this.btnXoa1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(90, 35);
            this.btnXoa1.TabIndex = 7;
            this.btnXoa1.Text = "Xóa";
            this.btnXoa1.UseVisualStyleBackColor = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnCapnhat1
            // 
            this.btnCapnhat1.Location = new System.Drawing.Point(219, 194);
            this.btnCapnhat1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapnhat1.Name = "btnCapnhat1";
            this.btnCapnhat1.Size = new System.Drawing.Size(112, 35);
            this.btnCapnhat1.TabIndex = 6;
            this.btnCapnhat1.Text = "Cập nhật";
            this.btnCapnhat1.UseVisualStyleBackColor = true;
            this.btnCapnhat1.Click += new System.EventHandler(this.btnCapnhat1_Click);
            // 
            // tnx
            // 
            this.tnx.Location = new System.Drawing.Point(219, 80);
            this.tnx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tnx.Name = "tnx";
            this.tnx.Size = new System.Drawing.Size(379, 78);
            this.tnx.TabIndex = 5;
            this.tnx.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nhận xét của giáo viên:";
            // 
            // txl
            // 
            this.txl.FormattingEnabled = true;
            this.txl.Items.AddRange(new object[] {
            "Giỏi",
            "Khá",
            "Trung Bình",
            "Yếu"});
            this.txl.Location = new System.Drawing.Point(14, 128);
            this.txl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txl.Name = "txl";
            this.txl.Size = new System.Drawing.Size(130, 28);
            this.txl.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Xếp loại:";
            // 
            // thk
            // 
            this.thk.FormattingEnabled = true;
            this.thk.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "Trung Bình",
            "Yếu"});
            this.thk.Location = new System.Drawing.Point(14, 51);
            this.thk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thk.Name = "thk";
            this.thk.Size = new System.Drawing.Size(130, 28);
            this.thk.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hạnh kiểm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tmhs);
            this.panel1.Controls.Add(this.tths);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(670, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 74);
            this.panel1.TabIndex = 13;
            // 
            // BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 725);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BangDiem";
            this.Text = "Bảng Điểm";
            this.Load += new System.EventHandler(this.BangDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ghs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbd)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ghs;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox ttkt;
        private System.Windows.Forms.TextBox ttk;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.TextBox tdiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tmh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gbd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tmhs;
        private System.Windows.Forms.Label tths;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gdg;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Button btnCapnhat1;
        private System.Windows.Forms.RichTextBox tnx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox thk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}
