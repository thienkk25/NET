using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class HocSinh : Form
    {
        public HocSinh()
        {
            InitializeComponent();
        }

        private void HocSinh_Load(object sender, EventArgs e)
        {
            tgt.SelectedIndex = 0;
            ttkt.SelectedIndex = 0;
            sqlserver.connect();
            string sql = "select MaHS, TenHS, GT, NS, DiaChi, HoTenCha, HoTenMe from HocSinh";
            dgv.DataSource = sqlserver.datatable(sql);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlserver.connect();
            int idr = dgv.CurrentCell.RowIndex;
            tht.Text = dgv.Rows[idr].Cells[1].Value.ToString();
            if (dgv.Rows[idr].Cells[2].Value.ToString() == "Nam")
            {
                tgt.SelectedIndex = 0;
            }
            else
            {
                tgt.SelectedIndex = 1;
            }
            tns.Text = dgv.Rows[idr].Cells[3].Value.ToString(); // Lấy giá trị cột 4
            tdc.Text = dgv.Rows[idr].Cells[4].Value.ToString(); // Lấy giá trị cột 5
            ttb.Text = dgv.Rows[idr].Cells[5].Value.ToString();
            ttm.Text = dgv.Rows[idr].Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ht, gt, ns, dc, tb, tm;
            ht = tht.Text;
            gt = tgt.Text;
            ns = tns.Text;
            dc = tdc.Text;
            tb = ttb.Text;
            tm = ttm.Text;
            //string sql = "insert into HocSinh(TenHS, GT, NS, DiaChi, HoTenCha, HoTenMe) values(N'" + ht + "',N'" + gt + "','" + ns + "',N'" + dc + "',N'" + tb + "',N'" + tm + "')";
            //sqlserver.nonquery(sql);
            sqlserver.connect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "insert into HocSinh(TenHS, GT, NS, DiaChi, HoTenCha, HoTenMe) values(@ht,@gt,@ns,@dc,@tb,@tm)";
            sqlCommand.Parameters.AddWithValue("@ht",ht);
            sqlCommand.Parameters.AddWithValue("@gt", gt);
            sqlCommand.Parameters.AddWithValue("@ns", ns);
            sqlCommand.Parameters.AddWithValue("@dc", dc);
            sqlCommand.Parameters.AddWithValue("@tb", tb);
            sqlCommand.Parameters.AddWithValue("@tm", tm);
            sqlCommand.ExecuteNonQuery();
            HocSinh_Load(sender, e); // Gọi lại phương thức HocSinh_Load()
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ht, gt, ns, dc, tb, tm;
            ht = tht.Text;
            gt = tgt.Text;
            ns = tns.Text;
            dc = tdc.Text;
            tb = ttb.Text;
            tm = ttm.Text;
            int idr = dgv.CurrentCell.RowIndex;
            int mahs = Convert.ToInt32(dgv.Rows[idr].Cells[0].Value);
            //string sql = "update HocSinh set TenHS=N'" + ht + "', GT=N'" + gt + "', NS='" + ns + "', DiaChi=N'" + dc + "', HoTenCha=N'" + tb + "', HoTenMe=N'" + tm + "' where MaHS='" + mahs + "'";
            //sqlserver.nonquery(sql);
            sqlserver.connect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "update HocSinh set TenHS=@ht, GT=@gt, NS=@ns, DiaChi=@dc, HoTenCha=@tb, HoTenMe=@tm where MaHS=@mahs";
            sqlCommand.Parameters.AddWithValue("@ht", ht);
            sqlCommand.Parameters.AddWithValue("@gt", gt);
            sqlCommand.Parameters.AddWithValue("@ns", ns);
            sqlCommand.Parameters.AddWithValue("@dc", dc);
            sqlCommand.Parameters.AddWithValue("@tb", tb);
            sqlCommand.Parameters.AddWithValue("@tm", tm);
            sqlCommand.Parameters.AddWithValue("@mahs", mahs);
            sqlCommand.ExecuteNonQuery();
            HocSinh_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            int idr = dgv.CurrentCell.RowIndex;

            int mahs = Convert.ToInt32(dgv.Rows[idr].Cells[0].Value);

            // string sqlBangdiem = "delete from BangDiem where MaHS='" + mahs + "'";
            // sqlserver.nonquery(sqlBangdiem);
            sqlserver.connect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "delete from BangDiem where MaHS=@mahs";
            sqlCommand.Parameters.AddWithValue("@mahs",mahs);
            sqlCommand.ExecuteNonQuery();

            // string sqlDanhGia = "delete from DanhGia where MaHS='" + mahs + "'";
            // sqlserver.nonquery(sqlDanhGia);
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = "delete from DanhGia where MaHS=@mahs";
            sqlCommand.Parameters.AddWithValue("@mahs",mahs);
            sqlCommand.ExecuteNonQuery();

            // string sqlHocSinh = "delete from HocSinh where MaHS='" + mahs + "'";
            // sqlserver.nonquery(sqlHocSinh);
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = "delete from HocSinh where MaHS=@mahs";
            sqlCommand.Parameters.AddWithValue("@mahs",mahs);
            sqlCommand.ExecuteNonQuery();
            HocSinh_Load(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            int kt = ttkt.SelectedIndex; // lấy vị trí mà combobox chọn
            string tk = ttk.Text;
            string tkt;
            switch (kt)
            {
                case 1: tkt = "MaHS"; break;
                case 2: tkt = "GT"; break;
                case 3: tkt = "NS"; break;
                case 4: tkt = "DiaChi"; break;
                case 5: tkt = "HoTenCha"; break;
                case 6: tkt = "HoTenMe"; break;
                default: tkt = "TenHS"; break;
            }
            string sql = $"select MaHS, TenHS, GT, NS, DiaChi, HoTenCha, HoTenMe from HocSinh where {tkt} like N'%{tk}%'";
            dgv.DataSource = sqlserver.datatable(sql);
            ttk.Text = "";
        }
    }
}