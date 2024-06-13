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
    public partial class LopHoc : Form
    {
        public LopHoc()
        {
            InitializeComponent();
        }

        private void LopHoc_Load(object sender, EventArgs e)
        {
            sqlserver.connect();
            //tabcontrol 1
            string sql = "select * from GiaoVien";
            magv.DataSource = sqlserver.datatable(sql); // Gán bảng dữ liệu DataTable trả về từ câu lệnh SQL vào DataSource
            magv.DisplayMember = "TenGV"; // Hiển thị thuộc tính TenGV của đối tượng GiaoVien trong combobox
            magv.ValueMember = "MaGV"; // Giá trị tương ứng với DisplayMember là thuộc tính MaGV
            magv.SelectedIndex = -1;
            sql = "select Lop.MaLop, Lop.TenLop, GiaoVien.MaGV, GiaoVien.TenGV from Lop, GiaoVien where Lop.MaGV=GiaoVien.MaGV";
            dgv.DataSource = sqlserver.datatable(sql);
            //tabcontrol 2
            sql = "select * from Lop order by TenLop";
            xemlop.DataSource = sqlserver.datatable(sql);
            xemlop.DisplayMember = "TenLop";
            xemlop.ValueMember = "MaLop";
            lopmoi.DataSource = sqlserver.datatable(sql);
            lopmoi.DisplayMember = "TenLop";
            lopmoi.ValueMember = "MaLop";
            sql = "select MaHS, TenHS from HocSinh where MaLop IS NULL";
            dg.DataSource = sqlserver.datatable(sql);
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlserver.connect();
            int idr = dgv.CurrentCell.RowIndex;
            tenlop.Text = dgv.Rows[idr].Cells[1].Value.ToString();
            string hoten = dgv.Rows[idr].Cells[3].Value.ToString();
            int i = 0;
            string sql = "select * from GiaoVien";
            SqlDataReader rd = sqlserver.reader(sql);
            while (rd.Read())
            {
                if (hoten == rd.GetValue(1).ToString())
                {
                    sqlserver.disconnect();
                    break;
                }
                i++;
            }
            magv.SelectedIndex = i;
            
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlserver.connect();
            int id = dg.CurrentCell.RowIndex;
            tenhs.Text = dg.Rows[id].Cells[1].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            string tl = tenlop.Text;
            // string sql = "select count(*) from Lop where TenLop='" + tl + "'";
            // int kt = (int)sqlserver.scalar(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select count(*) from Lop where TenLop=@tl";
            sqlCommand.Parameters.AddWithValue("@tl",tl);
            int kt = (int)sqlCommand.ExecuteScalar();
            if (kt != 0) MessageBox.Show("Tên Lớp này đã tồn tại");
            else
            {
                int mgv = Convert.ToInt32(magv.SelectedValue);
                // sql = "insert into Lop(TenLop,MaGV) values('" + tl + "','" + mgv + "')";
                // sqlserver.nonquery(sql);
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "insert into Lop(TenLop,MaGV) values(@tl,@mgv)";
                sqlCommand.Parameters.AddWithValue("@tl",tl);
                sqlCommand.Parameters.AddWithValue("@mgv",mgv);
                sqlCommand.ExecuteNonQuery();
                tenlop.Text = "";
                LopHoc_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            string tl = tenlop.Text;
            // string sql = "select count(*) from Lop where TenLop='" + tl + "'";
            // int kt = (int)sqlserver.scalar(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select count(*) from Lop where TenLop=@tl";
            sqlCommand.Parameters.AddWithValue("@tl",tl);
            int kt = (int)sqlCommand.ExecuteScalar();
            if (kt != 0) MessageBox.Show("Tên Lớp này đã tồn tại");
            else
            {
                int indexrow = dgv.CurrentCell.RowIndex;
                int mgv = Convert.ToInt32(magv.SelectedValue);
                int mlop = Convert.ToInt32(dgv.Rows[indexrow].Cells[0].Value);

                // sql = "update Lop set TenLop='" + tl + "', MaGV='" + mgv + "' where MaLop='" + mlop + "'";
                // sqlserver.nonquery(sql);
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "update Lop set TenLop=@tl, MaGV=@mgv where MaLop=@mlop";
                sqlCommand.Parameters.AddWithValue("@tl",tl);
                sqlCommand.Parameters.AddWithValue("@mgv",mgv);
                sqlCommand.Parameters.AddWithValue("@mlop",mlop);
                sqlCommand.ExecuteNonQuery();
                tenlop.Text = "";
                LopHoc_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            int indexrow = dgv.CurrentCell.RowIndex;
            int mlop = Convert.ToInt32(dgv.Rows[indexrow].Cells[0].Value);
            // string sql = "delete from Lop where MaLop='" + mlop + "'";
            // sqlserver.nonquery(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "delete from Lop where MaLop=@mlop";
            sqlCommand.Parameters.AddWithValue("@mlop",mlop);
            sqlCommand.ExecuteNonQuery();
            tenlop.Text = "";
            LopHoc_Load(sender, e);
        }

        private void btnXemlop_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            int malop = Convert.ToInt32(xemlop.SelectedValue);
            // string sql = "select HocSinh.MaHS, HocSinh.TenHS, Lop.MaLop, Lop.TenLop from HocSinh, Lop where HocSinh.MaLop=Lop.MaLop and HocSinh.MaLop='" + malop + "'";
            // dg.DataSource = sqlserver.datatable(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select HocSinh.MaHS, HocSinh.TenHS, Lop.MaLop, Lop.TenLop from HocSinh, Lop where HocSinh.MaLop=Lop.MaLop and HocSinh.MaLop=@malop";
            sqlCommand.Parameters.AddWithValue("@malop",malop);
            dg.DataSource = sqlserver.datatableCmd(sqlCommand);
        }

        private void btnHocsinhchuaxeplop_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            string sql = "select MaHS, TenHS from HocSinh where MaLop IS NULL";
            dg.DataSource = sqlserver.datatable(sql);
        }

        private void btnChuyenlop_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            int mahs, malop;
            int id = dg.CurrentCell.RowIndex;
            mahs = Convert.ToInt32(dg.Rows[id].Cells[0].Value);
            malop = Convert.ToInt32(lopmoi.SelectedValue);
            // string sql = "update HocSinh set MaLop='" + malop + "' where MaHS='" + mahs + "'";
            // sqlserver.nonquery(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "update HocSinh set MaLop=@malop where MaHS=@mahs";
            sqlCommand.Parameters.AddWithValue("@malop",malop);
            sqlCommand.Parameters.AddWithValue("@mahs",mahs);
            sqlCommand.ExecuteNonQuery();
            LopHoc_Load(sender, e);
        }
    }
}
