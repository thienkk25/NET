using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            if (session.loaitk == 0)
            {
                panelQuanlytaikhoan.Visible = false;
                panelGiaovien.Visible = false;
            }
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            label1.Text = "Xin chào! " + session.user;

        }

        private void pbHocsinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            HocSinh fhs = new HocSinh();
            fhs.ShowDialog();
            this.Show();
        }

        private void pbThoikhoabieu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThoiKhoaBieu fhs = new ThoiKhoaBieu();
            fhs.ShowDialog();
            this.Show();
        }

        private void pbLophoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            LopHoc fhs = new LopHoc();
            fhs.ShowDialog();
            this.Show();
        }

        private void pbGiaovien_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoVien fhs = new GiaoVien();
            fhs.ShowDialog();
            this.Show();
        }

        private void pbBangdiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BangDiem fhs = new BangDiem();
            fhs.ShowDialog();
            this.Show();
        }

        private void pbMonhoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonHoc fhs = new MonHoc();
            fhs.ShowDialog();
            this.Show();
        }

        private void pbDiemdanh_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiemDanh fhs = new DiemDanh();
            fhs.ShowDialog();
            this.Show();
        }

        private void pbQuanlytaikhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyTaiKhoan fhs = new QuanLyTaiKhoan();
            fhs.ShowDialog();
            this.Show();
        }

        private void lbGiaodienkhac_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChuMoi trangChuMoi = new TrangChuMoi();
            trangChuMoi.ShowDialog();
            this.Close();
        }
    }
}
