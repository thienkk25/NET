using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        // Phương thức này được sử dụng để hiển thị dữ liệu từ bảng TaiKhoan lên DataGridView dgvQuanlytaikhoan
        private void HienThiDuLieu()
        {
            // Kết nối đến cơ sở dữ liệu
            sqlserver.connect();

            // Tạo câu truy vấn SQL để lấy tất cả dữ liệu từ bảng TaiKhoan
            string sql = "select * from TaiKhoan";

            // Gán dữ liệu từ câu truy vấn vào DataGridView dgvQuanlytaikhoan bằng cách sử dụng phương thức datatable của đối tượng sqlserver
            dgvQuanlytaikhoan.DataSource = sqlserver.datatable(sql);
        }

        // Sự kiện load form QuanLyTaiKhoan, sẽ gọi phương thức HienThiDuLieu để hiển thị dữ liệu
        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // Gọi phương thức HienThiDuLieu để hiển thị dữ liệu khi form được load
            HienThiDuLieu();
        }


        private void dgvQuanlytaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dgvQuanlytaikhoan.Rows.Count kiểm tra xem có bao nhiêu hàng chứa dữ liệu
            // e.RowIndex vị trí hàng mà chọn trên DataGridView
            if (dgvQuanlytaikhoan.Rows.Count > 0 && e.RowIndex >= 0)
            {
                txtMatk.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells["MaTK"].Value.ToString(); // Lấy giá trị cột MaTK ép sang kiểu String
                txtTk.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells["TenTK"].Value.ToString();
                txtMk.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
                txtEmail.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                cbbLoai.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells["LoaiTK"].Value.ToString();
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMatk.Text = ""; // c2: txtTk.Clear();
            txtTk.Text = "";
            txtMk.Text = "";
            txtEmail.Text = "@gmail.com";
            cbbLoai.Text = "";
            HienThiDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // string.IsNullOrEmpty() kiểm tra chuỗi rỗng hay null không
            if (string.IsNullOrEmpty(txtTk.Text))
            {
                MessageBox.Show("Tài khoản không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(txtMk.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(cbbLoai.Text))
            {
                MessageBox.Show("Loại tài khoản không được để trống");
                return;
            }
            // string sql=$"select count(*) from TaiKhoan where TenTK='{txtTk.Text}'";
            // int kt=(int)sqlserver.scalar(sql);
            sqlserver.connect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select count(*) from TaiKhoan where TenTK=@TenTK";
            sqlCommand.Parameters.AddWithValue("@TenTK",txtTk.Text);
            int kt=(int)sqlCommand.ExecuteScalar();
            if (kt != 0)
            {
                MessageBox.Show("Trùng tài khoản, vui lòng thử lại!");
                return;
            }
            //int.Parse(cbbLoai.Text) ép kiểu String sang int
            // sql = $"insert into TaiKhoan(TenTK,MatKhau,Email,LoaiTK) values('{txtTk.Text}','{txtMk.Text}','{txtEmail.Text}',{int.Parse(cbbLoai.Text)})";
            // sqlserver.nonquery(sql);
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = "insert into TaiKhoan(TenTK,MatKhau,Email,LoaiTK) values(@tk,@mk,@email,@loaiTK)";
            sqlCommand.Parameters.AddWithValue("@tk",txtTk.Text);
            sqlCommand.Parameters.AddWithValue("@mk",txtMk.Text);
            sqlCommand.Parameters.AddWithValue("@email",txtEmail.Text);
            sqlCommand.Parameters.AddWithValue("@loaiTK",int.Parse(cbbLoai.Text));
            sqlCommand.ExecuteNonQuery();
            HienThiDuLieu() ;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTk.Text))
            {
                MessageBox.Show("Tài khoản không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(txtMk.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(cbbLoai.Text))
            {
                MessageBox.Show("Loại tài khoản không được để trống");
                return;
            }
            // string sql = $"update TaiKhoan set TenTK='{txtTk.Text}', MatKhau='{txtMk.Text}', Email='{txtEmail.Text}', LoaiTK={int.Parse(cbbLoai.Text)} where MaTK={int.Parse(txtMatk.Text)}";
            // sqlserver.nonquery(sql);
            sqlserver.connect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "update TaiKhoan set TenTK=@tk, MatKhau=@mk, Email=@email, LoaiTK=@loaiTK where MaTK=matk";
            sqlCommand.Parameters.AddWithValue("@tk",txtTk.Text);
            sqlCommand.Parameters.AddWithValue("@mk",txtMk.Text);
            sqlCommand.Parameters.AddWithValue("@email",txtEmail.Text);
            sqlCommand.Parameters.AddWithValue("@loaiTK",int.Parse(cbbLoai.Text));
            sqlCommand.Parameters.AddWithValue("@matk",int.Parse(txtMatk.Text));
            sqlCommand.ExecuteNonQuery();
            HienThiDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTk.Text))
            {
                MessageBox.Show("Tài khoản không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(txtMk.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(cbbLoai.Text))
            {
                MessageBox.Show("Loại tài khoản không được để trống");
                return;
            }
            // string sql = $"delete from TaiKhoan where MaTK={int.Parse(txtMatk.Text)}";
            // sqlserver.nonquery(sql);
            sqlserver.connect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "delete from TaiKhoan where MaTK=@matk";
            sqlCommand.Parameters.AddWithValue("@matk",int.Parse(txtMatk.Text));
            sqlCommand.ExecuteNonQuery();
            HienThiDuLieu();
        }
    }
}
