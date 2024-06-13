using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class sqlserver
    {
        public static SqlConnection conn; //khai báo một biến tĩnh conn có kiểu dữ liệu là SqlConnection.
        public static SqlCommand cmd; //khai báo một biến tĩnh cmd có kiểu dữ liệu là SqlCommand.
        public static SqlDataAdapter da; //khai báo một biến tĩnh da có kiểu dữ liệu là SqlDataAdapter.

        /* phương thức connect() được gọi là một phương thức tĩnh,phương thức đó thuộc về lớp chứ không phải là của một thể hiện cụ thể của lớp đó và
        phương thức không trả về bất kỳ giá trị nào.*/
        public static void connect()
        {
            //string connSt= @"Data Source=THIENNGUYEN\THIENNGUYENDZ;
            //                Initial Catalog=SoLienLacDienTu;
            //                Persist Security Info=True;
            //                User ID=sa;Password=a";
            string connSt = @"Data Source=THIENNGUYEN\THIENNGUYENDZ;
                            Initial Catalog=SoLienLacDienTu;
                            Integrated Security=True";
            //Tạo một đối tượng SqlConnection mới với chuỗi kết nối đã được cung cấp.
            conn = new SqlConnection(connSt);
            //Mở kết nối tới cơ sở dữ liệu.
            conn.Open();
        }
        /* phương thức disconnect() được gọi là một phương thức tĩnh,phương thức đó thuộc về lớp chứ không phải là của một thể hiện cụ thể của lớp đó và
        phương thức không trả về bất kỳ giá trị nào.*/
        public static void disconnect()
        {
            //Đóng kết nối tới cơ sở dữ liệu.
            conn.Close();
        }
        public static DataTable datatable(string sql)
        {
            //Tạo một đối tượng SqlCommand mới với truy vấn SQL được truyền từ tham số vào và đối tượng SqlConnection conn (đã được khai báo trước đó).
            cmd = new SqlCommand(sql, conn);
            //Tạo một đối tượng SqlDataAdapter với đối tượng SqlCommand đã tạo.
            da = new SqlDataAdapter(cmd);
            //Tạo một đối tượng DataTable mới.
            DataTable dt = new DataTable();
            // Sử dụng đối tượng SqlDataAdapter để thực thi truy vấn SQL và điền kết quả vào đối tượng DataTable đã tạo.
            da.Fill(dt); 
            return dt; // trả về kết quả dưới dạng một bảng dữ liệu DataTable.
        }
        public static void nonquery(string sql)
        {
            //Tạo một đối tượng SqlCommand mới với truy vấn SQL được truyền từ tham số vào và đối tượng SqlConnection conn (đã được khai báo trước đó).
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery(); // thực hiện truy vấn không trả về dữ liệu
        }
        public static SqlDataReader reader(string sql)
        {
            //Tạo một đối tượng SqlCommand mới với truy vấn SQL được truyền từ tham số vào và đối tượng SqlConnection conn (đã được khai báo trước đó).
            cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteReader(); // trả về đối tượng giao diện IDataReader như SqlDataReader, từ đó đọc được dữ liệu trả về.
        }
        public static object scalar(string sql)
        {
            //Tạo một đối tượng SqlCommand mới với truy vấn SQL được truyền từ tham số vào và đối tượng SqlConnection conn (đã được khai báo trước đó).
            cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteScalar(); // trả về một giá trị duy nhất - ở hàng đầu tiên, cột đầu tiên ( trả về 1 đối tượng ).
        }
        public static DataTable datatableCmd(SqlCommand sqlCommand)
        {
            //Tạo một đối tượng SqlDataAdapter với đối tượng SqlCommand đã tạo.
            da = new SqlDataAdapter(sqlCommand);
            //Tạo một đối tượng DataTable mới.
            DataTable dt = new DataTable();
            // Sử dụng đối tượng SqlDataAdapter để thực thi truy vấn SQL và điền kết quả vào đối tượng DataTable đã tạo.
            da.Fill(dt);
            return dt; // trả về kết quả dưới dạng một bảng dữ liệu DataTable.
        }
    }
}