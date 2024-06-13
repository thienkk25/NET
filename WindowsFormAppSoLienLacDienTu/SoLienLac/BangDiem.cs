using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace WindowsFormsApplication1
{
    public partial class BangDiem : Form
    {
        public BangDiem()
        {
            InitializeComponent();
        }

        private void BangDiem_Load(object sender, EventArgs e)
        {
            sqlserver.connect(); //gọi phương thức connect() trong class sqlserver để thực hiện kết nối tới cơ sở dữ liệu SQL Server.
            ttkt.SelectedIndex = 0; // thiết lập mặc định chọn đầu combox
            string sql = "select * from MonHoc";   //truy vấn SQL để chọn tất cả các bản ghi từ bảng MonHoc.
            tmh.DataSource = sqlserver.datatable(sql); // Gán bảng dữ liệu DataTable trả về từ câu lệnh SQL vào DataSource của tmh.
            tmh.DisplayMember = "TenMH";  // Hiển thị thuộc tính TenMH của đối tượng MonHoc trong combobox
            tmh.ValueMember = "MaMH"; // Giá trị tương ứng với DisplayMember là thuộc tính MaMH
            sql = "select HocSinh.MaHS, HocSinh.TenHS, Lop.TenLop from HocSinh, Lop where HocSinh.MaLop=Lop.MaLop"; // Truy vấn SQL để lấy thông tin mã học sinh, tên học sinh và tên lớp của bảng HocSinh
            ghs.DataSource = sqlserver.datatable(sql); // Gán bảng dữ liệu DataTable trả về từ câu lệnh SQL vào DataSource của ghs
        }

        private void ghs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = ghs.CurrentCell.RowIndex; // Lấy vị trí hàng chọn
            tmhs.Text = ghs.Rows[id].Cells[0].Value.ToString(); // Lấy giá trị cột đầu
            tths.Text = ghs.Rows[id].Cells[1].Value.ToString(); // Lấy giá trị cột hai
            sqlserver.connect();
            int mhs=Convert.ToInt32(tmhs.Text); // ép kiểu string sang int
            //string sql = "select MonHoc.TenMH, BangDiem.Diem from MonHoc, BangDiem where BangDiem.MaMH=MonHoc.MaMH and BangDiem.MaHS='" + mhs + "'";
            //gbd.DataSource = sqlserver.datatable(sql);
            //sql = "select HanhKiem, XepLoai, NhanXet from DanhGia where MaHS='"+mhs+"'";
            //gdg.DataSource = sqlserver.datatable(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection=sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select MonHoc.TenMH, BangDiem.Diem from MonHoc, BangDiem where BangDiem.MaMH=MonHoc.MaMH and BangDiem.MaHS=@mhs";
            sqlCommand.Parameters.AddWithValue("@mhs", mhs);
            gbd.DataSource=sqlserver.datatableCmd(sqlCommand);
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = "select HanhKiem, XepLoai, NhanXet from DanhGia where MaHS=@mhs";
            sqlCommand.Parameters.AddWithValue("@mhs", mhs);
            gdg.DataSource =sqlserver.datatableCmd(sqlCommand);

            tabControl1.Enabled = true; //người dùng có thể tương tác với các tab và các phần tử khác trong TabControl.
            thk.SelectedIndex = 0;
            txl.SelectedIndex = 0;
     
        }
        private void gbd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlserver.connect();
            int id = gbd.CurrentCell.RowIndex;
            string tenmh = gbd.Rows[id].Cells[0].Value.ToString();
            int i = 0;
            string sql = "select * from MonHoc";
            SqlDataReader rd = sqlserver.reader(sql); // trả về đối tượng giao diện SqlDataReader gắn vào biến rd
            //đọc được dữ liệu
            while (rd.Read())
            {
                if (tenmh == rd.GetString(1)) // rd.GetString(1) này trả về giá trị của cột thứ hai trong bản ghi hiện tại.
                {
                    sqlserver.disconnect();
                    break;
                }
                else i++;
            }
            tmh.SelectedIndex = i;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            string sql, tkt;
            int kt = ttkt.SelectedIndex;
            if (kt == 0) tkt = "TenLop";
            else if (kt == 1) tkt = "TenHS";
            else tkt = "MaHS";
            string tk = ttk.Text;
            sql = $"select HocSinh.MaHS, HocSinh.TenHS, Lop.TenLop from HocSinh, Lop where HocSinh.MaLop=Lop.MaLop and {tkt} like N'%{tk}%'";
            ghs.DataSource = sqlserver.datatable(sql);
            //SqlCommand sqlCommand = new SqlCommand();
            //sqlCommand.Connection = sqlserver.conn;
            //sqlCommand.CommandType = CommandType.Text;
            //sqlCommand.CommandText = $"select HocSinh.MaHS, HocSinh.TenHS, Lop.TenLop from HocSinh, Lop where HocSinh.MaLop=Lop.MaLop and @tkt like N'%{tk}%'";
            //sqlCommand.Parameters.AddWithValue("@tkt", tkt);
            //ghs.DataSource = sqlserver.datatableCmd(sqlCommand);
            ttk.Text = "";
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            int mhs, mmh, diem;
            mhs = Convert.ToInt32(tmhs.Text);
            mmh = Convert.ToInt32(tmh.SelectedValue);
            diem = Convert.ToInt32(tdiem.Text);
            int kt;
            //string sql = $"select count(*) from BangDiem where MaHS='{mhs}' and MaMH='{mmh}'";
            //kt = (int)sqlserver.scalar(sql); // trả về một giá trị duy nhất - ở hàng đầu tiên, cột đầu tiên.
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select count(*) from BangDiem where MaHS=@mhs and MaMH=@mmh";
            sqlCommand.Parameters.AddWithValue("@mhs", mhs);
            sqlCommand.Parameters.AddWithValue("@mmh", mmh);
            kt = (int)sqlCommand.ExecuteScalar();
            if (kt == 0)
            {
                sqlCommand.Parameters.Clear();
                //sql = $"insert into BangDiem values('{mhs}','{mmh}','{diem}')";
                //sqlserver.nonquery(sql); // thực thi truy vấn không trả về dữ liệu
                sqlCommand.CommandText = "insert into BangDiem values(@mhs,@mmh,@diem)";
                sqlCommand.Parameters.AddWithValue("@mhs", mhs);
                sqlCommand.Parameters.AddWithValue("@mmh", mmh);
                sqlCommand.Parameters.AddWithValue("@diem", diem);
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                sqlCommand.Parameters.Clear();
                //sql = $"update BangDiem set Diem='{diem}' where MaHS='{mhs}' and MaMH='{mmh}'";
                //sqlserver.nonquery(sql);
                sqlCommand.CommandText = "update BangDiem set Diem=@diem where MaHS=@mhs and MaMH=@mmh";
                sqlCommand.Parameters.AddWithValue("@mhs", mhs);
                sqlCommand.Parameters.AddWithValue("@mmh", mmh);
                sqlCommand.Parameters.AddWithValue("@diem", diem);
                sqlCommand.ExecuteNonQuery();
            }
            tdiem.Text = "";
            //sql = $"select MonHoc.TenMH, BangDiem.Diem from MonHoc, BangDiem where BangDiem.MaMH=MonHoc.MaMH and BangDiem.MaHS='{mhs}'";
            //gbd.DataSource = sqlserver.datatable(sql);
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select MonHoc.TenMH, BangDiem.Diem from MonHoc, BangDiem where BangDiem.MaMH=MonHoc.MaMH and BangDiem.MaHS=@mhs";
            sqlCommand.Parameters.AddWithValue("@mhs", mhs);
            gbd.DataSource = sqlserver.datatableCmd(sqlCommand);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            int mhs, mmh;
            mhs = Convert.ToInt32(tmhs.Text);
            mmh = Convert.ToInt32(tmh.SelectedValue);
            //string sql = "delete from BangDiem where MaHS='" + mhs + "' and MaMH='" + mmh + "'";
            //sqlserver.nonquery(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "delete from BangDiem where MaHS=@mhs and MaMH=@mmh";
            sqlCommand.Parameters.AddWithValue("@mhs", mhs);
            sqlCommand.Parameters.AddWithValue("@mmh", mmh);
            sqlCommand.ExecuteNonQuery();

            //sql = "select MonHoc.TenMH, BangDiem.Diem from MonHoc, BangDiem where BangDiem.MaMH=MonHoc.MaMH and BangDiem.MaHS='" + mhs + "'";
            //gbd.DataSource = sqlserver.datatable(sql);
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = "select MonHoc.TenMH, BangDiem.Diem from MonHoc, BangDiem where BangDiem.MaMH=MonHoc.MaMH and BangDiem.MaHS=@mhs";
            sqlCommand.Parameters.AddWithValue("@mhs", mhs);
            gbd.DataSource = sqlserver.datatableCmd(sqlCommand);
        }

        private void btnCapnhat1_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            int kt, mhs;
            mhs = Convert.ToInt32(tmhs.Text);
            string hk, xl, nx;
            kt = thk.SelectedIndex; // lấy vị trí chọn trong comboBox
            switch (kt)
            {
                case 0: hk = "Tốt"; break;
                case 1: hk = "Khá"; break;
                case 2: hk = "Trung Bình"; break;
                default: hk = "Yếu"; break;
            }
            kt = txl.SelectedIndex;
            switch (kt)
            {
                case 0: xl = "Giỏi"; break;
                case 1: xl = "Khá"; break;
                case 2: xl = "Trung Bình"; break;
                default: xl = "Yếu"; break;
            }
            nx = tnx.Text;
            //string sql = "select count(*) from DanhGia where MaHS='" + mhs + "'";
            //kt = (int)sqlserver.scalar(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select count(*) from DanhGia where MaHS=@mhs";
            sqlCommand.Parameters.AddWithValue("@mhs", mhs);
            kt = (int)sqlCommand.ExecuteScalar();
            if (kt == 0)
            {
                //sql = "insert into DanhGia values('" + mhs + "',N'" + hk + "',N'" + xl + "',N'" + nx + "')";
                //sqlserver.nonquery(sql);
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "insert into DanhGia values(@mhs,N'" + hk + "',N'" + xl + "',N'" + nx + "')";
                sqlCommand.Parameters.AddWithValue("@mhs", mhs);
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                //sql = "update DanhGia set HanhKiem=N'" + hk + "', XepLoai=N'" + xl + "', NhanXet=N'" + nx + "' where MaHS='" + mhs + "'";
                //sqlserver.nonquery(sql);
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "update DanhGia set HanhKiem=N'" + hk + "', XepLoai=N'" + xl + "', NhanXet=N'" + nx + "' where MaHS=@mhs";
                sqlCommand.Parameters.AddWithValue("@mhs", mhs);
                sqlCommand.ExecuteNonQuery();
            }
            tnx.Text = "";
            //sql = "select HanhKiem, XepLoai, NhanXet from DanhGia where MaHS='" + mhs + "'";
            //gdg.DataSource = sqlserver.datatable(sql);
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = "select HanhKiem, XepLoai, NhanXet from DanhGia where MaHS=@mhs";
            sqlCommand.Parameters.AddWithValue("@mhs", mhs);
            gdg.DataSource = sqlserver.datatableCmd(sqlCommand);
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            int mhs;
            mhs = Convert.ToInt32(tmhs.Text);
            //string sql = "delete from DanhGia where MaHS='" + mhs + "'";
            //sqlserver.nonquery(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "delete from DanhGia where MaHS=@mhs";
            sqlCommand.Parameters.AddWithValue("@mhs", mhs);
            sqlCommand.ExecuteNonQuery();

            //sql = "select HanhKiem, XepLoai, NhanXet from DanhGia where MaHS='" + mhs + "'";
            //gdg.DataSource = sqlserver.datatable(sql);
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = "select HanhKiem, XepLoai, NhanXet from DanhGia where MaHS=@mhs";
            sqlCommand.Parameters.AddWithValue("@mhs", mhs);
            gdg.DataSource =sqlserver.datatableCmd(sqlCommand);
        }
    }
}

