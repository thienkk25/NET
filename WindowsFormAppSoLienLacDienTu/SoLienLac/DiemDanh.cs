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
    public partial class DiemDanh : Form
    {
        public DiemDanh()
        {
            InitializeComponent();
        }

        private void DiemDanh_Load(object sender, EventArgs e)
        {
            sqlserver.connect();
            string sql = "select * from Lop order by TenLop";
            cbbLop.DataSource = sqlserver.datatable(sql);
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "MaLop";

            sql = "select MaHS,TenHS, GT, NS from HocSinh where MaLop=9";
            dgvHocSinh.DataSource =sqlserver.datatable(sql);

            
            DataGridViewCheckBoxColumn columnName = new DataGridViewCheckBoxColumn();// tạo ra một đối tượng mới có kiểu dữ liệu DataGridViewCheckBoxColumn
            columnName.HeaderText = "Điểm danh"; // Đặt tiêu đề cho cột
            columnName.Name = "DD"; // Đặt tên name design
            // Thêm cột vào DataGridView
            dgvHocSinh.Columns.Add(columnName);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose(); //  sử dụng để giải phóng tài nguyên đã được đặt dành cho đối tượng đó
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            sqlserver.connect();
            //string sql = "select MaHS,TenHS, GT, NS from HocSinh where MaLop='" + cbbLop.SelectedValue + "'";
            //dgvHocSinh.DataSource = sqlserver.datatable(sql);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection =sqlserver.conn;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "select MaHS,TenHS, GT, NS from HocSinh where MaLop=@maLop";
            sqlCommand.Parameters.AddWithValue("@maLop",cbbLop.SelectedValue);
            dgvHocSinh.DataSource = sqlserver.datatableCmd(sqlCommand);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 2007 or Higher(.xlsx) | *.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook excelBook = excelApp.Workbooks.Add();
                Microsoft.Office.Interop.Excel.Worksheet excelSheet = excelBook.Sheets[1];

                excelSheet.Cells[1, 1] = "Danh sách lớp: " + cbbLop.Text;
                excelSheet.Cells[1, 2] = DateTime.Now.ToString();

                // Xuất tên cột của DataGridView sang Excel
                for (int i = 0; i < 4; i++)
                {
                    excelSheet.Cells[1, i + 5] = dgvHocSinh.Columns[i].HeaderText;
                }
                excelSheet.Cells[1, 9] = "Có mặt";

                // Xuất các dữ liệu của DataGridView sang Excel
                for (int i = 0; i < dgvHocSinh.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvHocSinh.Columns.Count; j++)
                    {
                        excelSheet.Cells[i+2, j+1] = dgvHocSinh.Rows[i].Cells[j].Value;
                    }
                }

                // Lưu file
                excelBook.SaveAs(filePath);
                excelApp.Quit();
                MessageBox.Show("File đã được lưu tại đường dẫn: " + filePath, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
