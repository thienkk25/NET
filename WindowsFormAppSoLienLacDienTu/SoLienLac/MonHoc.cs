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
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            sqlserver.connect();
            string sql = "select * from MonHoc";
            dgv.DataSource=sqlserver.datatable(sql);

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = dgv.CurrentCell.RowIndex;
            tmm.Text = dgv.Rows[id].Cells[0].Value.ToString();
            ttm.Text = dgv.Rows[id].Cells[1].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            string tm = ttm.Text;
            // string sql = "insert into MonHoc(TenMH) values(N'" + tm + "')";
            // sqlserver.nonquery(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "insert into MonHoc(TenMH) values(@tm)";
            sqlCommand.Parameters.AddWithValue("@tm",tm);
            sqlCommand.ExecuteNonQuery();
            MonHoc_Load(sender, e);
            ttm.Text = "";
            tmm.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            string tm = ttm.Text;
            int mm = Convert.ToInt32(tmm.Text);
            // string sql = "update MonHoc set TenMH=N'" + tm + "' where MaMH='" + mm + "'";
            // sqlserver.nonquery(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "update MonHoc set TenMH=@tm where MaMH=@mm";
            sqlCommand.Parameters.AddWithValue("@tm",tm);
            sqlCommand.Parameters.AddWithValue("@mm",mm);
            sqlCommand.ExecuteNonQuery();
            MonHoc_Load(sender, e);
            ttm.Text = "";
            tmm.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            int mm = Convert.ToInt32(tmm.Text);
            // string sql = "delete from MonHoc where MaMH='" + mm + "'";
            // sqlserver.nonquery(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "delete from MonHoc where MaMH=@mm";
            sqlCommand.Parameters.AddWithValue("@mm",mm);
            sqlCommand.ExecuteNonQuery();
            MonHoc_Load(sender, e);
        }
    }
}
