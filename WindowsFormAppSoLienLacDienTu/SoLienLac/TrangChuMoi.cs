using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TrangChuMoi : Form
    {
        public TrangChuMoi()
        {
            InitializeComponent();
        }

        private void TrangChuMoi_Load(object sender, EventArgs e)
        {
            lbTrangchu.Text = "Xin chào, " + session.user;
        }
        public void RemovePanel()
        {
            //Tạo một biến kiểu Control có tên là control và gán giá trị là control đầu tiên trong danh sách các controls của panelParent.
            Control control = panelParent.Controls[0];
            //Loại bỏ control được lấy ra khỏi danh sách controls của panelParent.
            panelParent.Controls.Remove(control);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            RemovePanel(); //Gọi phương thức RemovePanel để loại bỏ panel hiện tại khỏi panelParent.
            labelTitle.Text= "Trang chủ"; //Thay đổi văn bản của labelTitle thành "Trang chủ".
            PictureBox pictureBox = new PictureBox(); //Tạo một đối tượng PictureBox mới.
            pictureBox.BackgroundImage = Properties.Resources.background_home; //Gán hình nền cho pictureBox là hình ảnh được lấy từ Resources.
            pictureBox.Dock = DockStyle.Fill; //hiết lập thuộc tính Dock của pictureBox là DockStyle.Fill để nó lấp đầy không gian của panelParent.
            pictureBox.BackgroundImageLayout= ImageLayout.Stretch; //Thiết lập cách hiển thị hình nền của pictureBox là ImageLayout.Stretch để nó được kéo dãn để phù hợp với kích thước của pictureBox.
            panelParent.Controls.Add(pictureBox); //Thêm pictureBox vào danh sách controls của panelParent.
        }
        private void btnHocsinh_Click(object sender, EventArgs e)
        {
            RemovePanel();
            labelTitle.Text = "Học sinh";
            HocSinh hocSinh = new HocSinh();
            hocSinh.TopLevel = false;
            hocSinh.FormBorderStyle = FormBorderStyle.None;
            hocSinh.Dock = DockStyle.Fill;
            panelParent.Controls.Add(hocSinh);
            hocSinh.Show();
        }

        private void btnThoikhoabieu_Click(object sender, EventArgs e)
        {
            RemovePanel();
            labelTitle.Text = "Thời khóa biểu";
            ThoiKhoaBieu thoiKhoaBieu = new ThoiKhoaBieu();
            thoiKhoaBieu.TopLevel = false;
            thoiKhoaBieu.FormBorderStyle = FormBorderStyle.None;
            thoiKhoaBieu.Dock = DockStyle.Fill;
            panelParent.Controls.Add(thoiKhoaBieu);
            thoiKhoaBieu.Show();
        }

        private void btnBangdiem_Click(object sender, EventArgs e)
        {
            RemovePanel();
            labelTitle.Text = "Bảng điểm";
            BangDiem bangDiem = new BangDiem();
            bangDiem.TopLevel = false;
            bangDiem.FormBorderStyle = FormBorderStyle.None;
            bangDiem.Dock = DockStyle.Fill;
            panelParent.Controls.Add(bangDiem);
            bangDiem.Show();
        }

        private void btnDiemdanh_Click(object sender, EventArgs e)
        {
            RemovePanel();
            labelTitle.Text = "Điểm danh";
            DiemDanh diemDanh = new DiemDanh();
            diemDanh.TopLevel = false;
            diemDanh.FormBorderStyle = FormBorderStyle.None;
            diemDanh.Dock = DockStyle.Fill;
            panelParent.Controls.Add(diemDanh);
            diemDanh.Show();
        }

        private void btnLophoc_Click(object sender, EventArgs e)
        {
            RemovePanel();
            labelTitle.Text = "Lớp học";
            LopHoc lopHoc = new LopHoc();
            lopHoc.TopLevel = false;
            lopHoc.FormBorderStyle = FormBorderStyle.None;
            lopHoc.Dock = DockStyle.Fill;
            panelParent.Controls.Add(lopHoc);
            lopHoc.Show();
        }

        private void btnMonhoc_Click(object sender, EventArgs e)
        {
            RemovePanel();
            labelTitle.Text = "Môn học";
            MonHoc monHoc = new MonHoc();
            monHoc.TopLevel = false;
            monHoc.FormBorderStyle = FormBorderStyle.None;
            monHoc.Dock = DockStyle.Fill;
            panelParent.Controls.Add(monHoc);
            monHoc.Show();
        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            RemovePanel();
            labelTitle.Text = "Giáo viên";
            GiaoVien giaoVien = new GiaoVien();
            giaoVien.TopLevel = false;
            giaoVien.FormBorderStyle = FormBorderStyle.None;
            giaoVien.Dock = DockStyle.Fill;
            panelParent.Controls.Add(giaoVien);
            giaoVien.Show();
        }

        private void btnQuanlytaikhoan_Click(object sender, EventArgs e)
        {
            RemovePanel();
            labelTitle.Text = "Quản lý tài khoản";
            QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
            quanLyTaiKhoan.TopLevel = false;
            quanLyTaiKhoan.FormBorderStyle = FormBorderStyle.None;
            quanLyTaiKhoan.Dock = DockStyle.Fill;
            panelParent.Controls.Add(quanLyTaiKhoan);
            quanLyTaiKhoan.Show();
        }
    }
}
