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
    public partial class GiaoVien : Form
    {
        public GiaoVien()
        {
            InitializeComponent();
        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            sqlserver.connect();
            string sql = "select * from GiaoVien order by MaGV desc";
            dgv.DataSource = sqlserver.datatable(sql);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // sẽ gán giá trị của chỉ số (index) của dòng hiện tại đang được chọn
            int indexrow = dgv.CurrentCell.RowIndex; 
            //dòng mã này sẽ hiển thị giá trị của ô thứ 2 trong dòng được chọn trong DataGridView vào control TextBox tengv.
            tengv.Text = dgv.Rows[indexrow].Cells[1].Value.ToString();
            //dòng mã này sẽ hiển thị giá trị của ô thứ 3 trong dòng được chọn trong DataGridView vào control TextBox tengv.
            dcgv.Text = dgv.Rows[indexrow].Cells[2].Value.ToString();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string ten = tengv.Text;
            string sql = $"select * from GiaoVien where TenGV like N'%{ten}%'";
            dgv.DataSource = sqlserver.datatable(sql);
            tengv.Text = "";
            dcgv.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = tengv.Text, dc = dcgv.Text,sql;
            //string sql = "insert into GiaoVien(TenGV, DiaChi) values(N'" + ten + "',N'" + dc + "')";
            //sqlserver.nonquery(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "insert into GiaoVien(TenGV, DiaChi) values(@ten,@diachi)";
            sqlCommand.Parameters.AddWithValue("@ten", ten);
            sqlCommand.Parameters.AddWithValue("@diachi", dc);
            sqlCommand.ExecuteNonQuery();
            tengv.Text = "";
            dcgv.Text = "";
            sql = "select * from GiaoVien order by MaGV desc";
            dgv.DataSource = sqlserver.datatable(sql);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int indexrow = dgv.CurrentCell.RowIndex;
            int magv = Convert.ToInt32(dgv.Rows[indexrow].Cells[0].Value);
            string ten = tengv.Text, dc = dcgv.Text, sql;

            //string sql = "update GiaoVien set TenGV=N'" + ten + "', DiaChi=N'" + dc + "' where MaGV='" + magv + "'";
            //sqlserver.nonquery(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "update GiaoVien set TenGV=@ten, DiaChi=@diachi where MaGV=@magv";
            sqlCommand.Parameters.AddWithValue("@ten", ten);
            sqlCommand.Parameters.AddWithValue("@diachi", dc);
            sqlCommand.Parameters.AddWithValue("@magv", magv);
            sqlCommand.ExecuteNonQuery();

            sql = "select * from GiaoVien order by MaGV desc";
            dgv.DataSource = sqlserver.datatable(sql);
            tengv.Text = "";
            dcgv.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int indexrow = dgv.CurrentCell.RowIndex;
            int magv = Convert.ToInt32(dgv.Rows[indexrow].Cells[0].Value);
            string sql;
            //string sql = "delete from GiaoVien where MaGV='" + magv + "'";
            //sqlserver.nonquery(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "delete from GiaoVien where MaGV=@magv'";
            sqlCommand.Parameters.AddWithValue("@magv", magv);
            sqlCommand.ExecuteNonQuery();

            sql = "select * from GiaoVien order by MaGV desc";
            dgv.DataSource = sqlserver.datatable(sql);
            tengv.Text = "";
            dcgv.Text = "";
        }
    }
}