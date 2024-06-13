using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            label4.Text = " ";
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)  // kiểm tra xem CheckBox tích chưa 
            {
                tbMK.UseSystemPasswordChar = false;
                cbShow.Text = "Ẩn";
            }
            else
            {
                tbMK.UseSystemPasswordChar = true;
                cbShow.Text = "Hiện";
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            string tk = tbTK.Text, mk = tbMK.Text, em = tbEM.Text;
            //string sql = "select count(*) from TaiKhoan where TenTK='" + tk + "'";
            //int kt = (int)sqlserver.scalar(sql); // trả về một giá trị duy nhất - ở hàng đầu tiên, cột đầu tiên.
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection=sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select count(*) from TaiKhoan where TenTK=@tk";
            sqlCommand.Parameters.AddWithValue("@tk", tk);
            int kt = (int)sqlCommand.ExecuteScalar();
            if (kt != 0)
            {
                label4.Text = "Error: Tên tài khoản đã tồn tại!";
                tbTK.Clear();
                tbMK.Clear();
            }
            else
            {
                //sql = "insert into TaiKhoan(TenTK,MatKhau,Email) values('" + tk + "','" + mk + "','" + em + "')";
                //sqlserver.nonquery(sql); // thực thi truy vấn không trả về dữ liệu
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "insert into TaiKhoan(TenTK,MatKhau,Email) values(@tk,@mk,@em)";
                sqlCommand.Parameters.AddWithValue("@tk", tk);
                sqlCommand.Parameters.AddWithValue("@mk", mk);
                sqlCommand.Parameters.AddWithValue("@em", em);
                sqlCommand.ExecuteNonQuery();
                label4.ForeColor = System.Drawing.Color.Green; // đặt màu chữ của một Label sang màu xanh
                label4.Text = "Đăng ký tài khoản thành công!";
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form
            DangNhap fdn = new DangNhap(); // tạo ra một đối tượng mới của lớp "DangNhap" và gán nó vào biến "fdn"
            fdn.ShowDialog(); //hiển thị một cửa sổ hoặc hộp thoại và chờ đợi cho đến khi người dùng đóng cửa sổ đó trước khi tiếp tục thực hiện các tác vụ sau.
            this.Close(); // Đóng form
        }
    }
}
