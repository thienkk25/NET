using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class ThoiKhoaBieu : Form
    {
        public int lop;
        public Label[,] lbx;
        public ThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void ThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            sqlserver.connect();
            string sql = "select * from Lop order by TenLop";
            tlh.DataSource = sqlserver.datatable(sql);
            tlh.DisplayMember = "TenLop";
            tlh.ValueMember = "MaLop";
            //Môn học
            sql = "select * from MonHoc";
            tmh.DataSource = sqlserver.datatable(sql);
            tmh.DisplayMember = "TenMH";
            tmh.ValueMember = "MaMH";
            //ngày học(thứ), tiết học
            tnh.SelectedIndex = 0;
            tth.SelectedIndex = 0;
            tkb_add();
        }

        //phương thức không trả về giá trị (void) và thêm các label vào một TableLayoutPanel.
        private void tkb_add()
        {
            lbx = new Label[9, 8];
            for(int i=1;i<=7;i++)
                for (int j = 1; j <= 8; j++)
                {
                    lbx[j, i] = new Label();
                    lbx[j, i].Dock = DockStyle.Fill;
                    lbx[j, i].Text = "";
                    tkb.Controls.Add(lbx[j, i], i, j);
                }
        }

        private void tkb_view(int ml)
        {
            for (int i = 1; i <= 7; i++)
                for (int j = 1; j <= 8; j++)
                {
                    lbx[j, i].Text = "";
                }
            //show
            sqlserver.connect();
            //string sql = $"select * from ThoiKhoaBieu where MaLop={ml}";
            //SqlDataReader rd = sqlserver.reader(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select * from ThoiKhoaBieu where MaLop=@ml";
            sqlCommand.Parameters.AddWithValue("@ml", ml);
            using(var rd = sqlCommand.ExecuteReader())
            {
                if (rd.HasRows)
                {
                    string tkbm;
                    int tkbn, tkbt;
                    while (rd.Read())
                    {
                        tkbm = rd.GetString(3); // lấy tên môn học trong bảng ThoiKhoaBieu cột 3 tính từ 0.
                        tkbn = Convert.ToInt32(rd.GetValue(4)) - 1; // lấy ngày học  trong bảng ThoiKhoaBieu cột 4 tính từ 0.
                                                                    //tkbn--;
                        tkbt = Convert.ToInt32(rd.GetValue(5)); // lấy tiết học trong bảng ThoiKhoaBieu cột 5 tính từ 0.
                        lbx[tkbt, tkbn].Text = tkbm;
                    }
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int malop = Convert.ToInt32(tlh.SelectedValue);
            tkb_view(malop);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            int malop = Convert.ToInt32(tlh.SelectedValue);
            lop = malop;
            int mamh = Convert.ToInt32(tmh.SelectedValue);
            //string sql = "select TenMH from MonHoc where MaMH='" + mamh + "'";
            //string tenmh = (string)sqlserver.scalar(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select TenMH from MonHoc where MaMH=@mamh'";
            sqlCommand.Parameters.AddWithValue("@mamh", mamh);
            string tenmh = (string)sqlCommand.ExecuteScalar();
            int ngay, tiet;
            ngay = tnh.SelectedIndex;
            tiet = tth.SelectedIndex;
            ngay = ngay + 2; // + thêm 2 vì không có ngày học 0,1 hay còn gọi là thứ.
            tiet = tiet + 1; // + thêm 1 vì không có tiết 0.
            //sql = "select count(*) from ThoiKhoaBieu where MaLop='" + malop + "' and NgayHoc='" + ngay + "' and TietHoc='" + tiet + "'";
            //int kt = (int)sqlserver.scalar(sql);
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = "select count(*) from ThoiKhoaBieu where MaLop=@malop and NgayHoc=@ngay and TietHoc=@tiet";
            sqlCommand.Parameters.AddWithValue("@malop", malop);
            sqlCommand.Parameters.AddWithValue("@ngay", ngay);
            sqlCommand.Parameters.AddWithValue("@tiet", tiet);
            int kt = (int)sqlCommand.ExecuteScalar();
            if (kt != 0) MessageBox.Show("Bị trùng thời khóa biểu!");
            else
            {
                //sql = "insert into ThoiKhoaBieu(MaLop,MaMH,TenMH,NgayHoc,TietHoc) values('" + malop + "','" + mamh + "',N'" + tenmh + "','" + ngay + "','" + tiet + "')";
                //sqlserver.nonquery(sql);
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "insert into ThoiKhoaBieu(MaLop,MaMH,TenMH,NgayHoc,TietHoc) values(@malop,@mamh,@tenmh,@ngay,@tiet)";
                sqlCommand.Parameters.AddWithValue("@malop",malop);
                sqlCommand.Parameters.AddWithValue("@mamh", mamh);
                sqlCommand.Parameters.AddWithValue("@tenmh", tenmh);
                sqlCommand.Parameters.AddWithValue("@ngay", ngay);
                sqlCommand.Parameters.AddWithValue("@tiet", tiet);
                sqlCommand.ExecuteNonQuery();
                tkb_view(malop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int kt, malop, ngay, tiet;
            ngay = tnh.SelectedIndex;
            tiet = tth.SelectedIndex;
            ngay = ngay + 2; // + thêm 2 vì không có ngày học 0,1 hay còn gọi là thứ.
            tiet = tiet + 1; // + thêm 1 vì không có tiết 0.
            malop = Convert.ToInt32(tlh.SelectedValue);
            lop = malop;
            sqlserver.connect();
            //string sql = "select count(*) from ThoiKhoaBieu where MaLop='" + malop + "' and NgayHoc='" + ngay + "' and TietHoc='" + tiet + "'";
            //kt = (int)sqlserver.scalar(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select count(*) from ThoiKhoaBieu where MaLop=@malop and NgayHoc=@ngay and TietHoc=@tiet";
            sqlCommand.Parameters.AddWithValue("@malop", malop);
            sqlCommand.Parameters.AddWithValue("@ngay", ngay);
            sqlCommand.Parameters.AddWithValue("@tiet", tiet);
            kt = (int)sqlCommand.ExecuteScalar();
            if (kt == 0) MessageBox.Show("Lớp Học bạn chọn không có Môn nào học vào Thứ " + ngay + " và Tiết " + tiet);
            else
            {
                //sql = "delete from ThoiKhoaBieu where MaLop='" + malop + "' and NgayHoc='" + ngay + "' and TietHoc='" + tiet + "'";
                //sqlserver.nonquery(sql);
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "delete from ThoiKhoaBieu where MaLop=@malop and NgayHoc=@ngay and TietHoc=@tiet";
                sqlCommand.Parameters.AddWithValue("@malop", malop);
                sqlCommand.Parameters.AddWithValue("@ngay", ngay);
                sqlCommand.Parameters.AddWithValue("@tiet", tiet);
                sqlCommand.ExecuteNonQuery();
                tkb_view(malop);
            }
        }

        private void btnXemtkb_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            if (string.IsNullOrEmpty(tmhs.Text))
            {
                MessageBox.Show("Không bỏ trống");
                return;
            }
            int mhs = Convert.ToInt32(tmhs.Text);
            //string sql = "select count(*) from HocSinh where MaHS='" + mhs + "'";
            //int kt = (int)sqlserver.scalar(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select count(*) from HocSinh where MaHS=@mhs";
            sqlCommand.Parameters.AddWithValue("@mhs",mhs);
            int kt = (int)sqlCommand.ExecuteScalar();
            if (kt == 0) MessageBox.Show("Mã học sinh không tồn tại");
            else
            {
                //sql = "select MaLop from HocSinh where MaHS='" + mhs + "'";
                //int malop = (int)sqlserver.scalar(sql);
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "select MaLop from HocSinh where MaHS=@mhs";
                sqlCommand.Parameters.AddWithValue("@mhs", mhs);
                int malop = (int)sqlCommand.ExecuteScalar();
                tkb_view(malop);
            }
        }
    }
}
