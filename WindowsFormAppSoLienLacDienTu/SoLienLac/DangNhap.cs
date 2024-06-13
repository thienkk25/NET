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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
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

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            string tk = tbTK.Text, mk = tbMK.Text;
            //string sql = "select * from TaiKhoan where TenTK='" + tk + "' and MatKhau='" + mk + "'";
            //SqlDataReader rd = sqlserver.reader(sql);
            //if (!rd.HasRows)
            //{
            //    lbTB.Text = "Sai thông tin tài khoản!";
            //}
            //else
            //{
            //    while (rd.Read())
            //    {
            //        session.user = rd.GetString(1);
            //        session.loaitk = Convert.ToInt32(rd.GetValue(4));
            //    }
            //    TrangChu ftc = new TrangChu();
            //    this.Hide();
            //    ftc.ShowDialog();
            //    this.Close();
            //}
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select * from TaiKhoan where TenTK=@tk and MatKhau=@mk";
            sqlCommand.Parameters.AddWithValue("@tk",tk);
            sqlCommand.Parameters.AddWithValue ("@mk",mk);
            using(var rd = sqlCommand.ExecuteReader())
            {
                if (!rd.HasRows)
                {
                    lbTB.Text = "Sai thông tin tài khoản!";
                }
                else
                {
                    while (rd.Read())
                    {
                        session.user = rd.GetString(1);
                        session.loaitk = Convert.ToInt32(rd.GetValue(4));
                    }
                    TrangChu ftc = new TrangChu();
                    this.Hide();
                    ftc.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy fdk = new DangKy();
            fdk.ShowDialog();
            this.Close();
        }
    }
}
