namespace WindowsFormsApplication1
{
    partial class DangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.lbTB = new System.Windows.Forms.Label();
            this.btnDangky = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbShow);
            this.panel1.Controls.Add(this.lbTB);
            this.panel1.Controls.Add(this.btnDangky);
            this.panel1.Controls.Add(this.btnDangnhap);
            this.panel1.Controls.Add(this.tbMK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbTK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(129, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 288);
            this.panel1.TabIndex = 0;
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Location = new System.Drawing.Point(368, 145);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(68, 24);
            this.cbShow.TabIndex = 7;
            this.cbShow.Text = "Hiện";
            this.cbShow.UseVisualStyleBackColor = true;
            this.cbShow.CheckedChanged += new System.EventHandler(this.cbShow_CheckedChanged);
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.ForeColor = System.Drawing.Color.Red;
            this.lbTB.Location = new System.Drawing.Point(81, 178);
            this.lbTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(0, 20);
            this.lbTB.TabIndex = 6;
            // 
            // btnDangky
            // 
            this.btnDangky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.Location = new System.Drawing.Point(243, 226);
            this.btnDangky.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(120, 57);
            this.btnDangky.TabIndex = 5;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(81, 226);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(138, 57);
            this.btnDangnhap.TabIndex = 4;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(81, 143);
            this.tbMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(280, 26);
            this.tbMK.TabIndex = 3;
            this.tbMK.Text = "admin";
            this.tbMK.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(81, 58);
            this.tbTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(280, 26);
            this.tbTK.TabIndex = 1;
            this.tbTK.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(182, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "SỔ LIÊN LẠC ĐIỆN TỬ";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbShow;
    }
}