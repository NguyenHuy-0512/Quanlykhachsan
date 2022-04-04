using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlykhachsan
{
    class Connectdata
    {
        public static String ConnectString = "Data Source=LAPTOP-SF4GIP15\\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";

        //  select
        public static DataTable ExcuteDataTable_SQL(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                using (SqlDataAdapter dad = new SqlDataAdapter(sql, con))
                {
                    using (DataSet dst = new DataSet())
                    {
                        try
                        {
                            dad.Fill(dst);
                            return dst.Tables[0];
                        }
                        catch (Exception loi)
                        {
                            // Khối này thực thi khi có lỗi - đối tượng Exception bắt được lưu ở biến loi
                            //Console.WriteLine("Có lỗi rồi");
                            //Console.WriteLine(loi.Message);

                            MessageBox.Show("Đã phát sinh lỗi");
                            MessageBox.Show(loi.Message);
                            return dst.Tables[0];
                        }
                    }
                }
            }
        }

        //  insert,delete,update
        public static void ExecuteInsertData(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();



                try
                {
                    // Các khối code được giám sát để bắt lỗi nếu có
                    // nếu có lỗi sẽ phát sinh ngoại lệ Exception
                    // Ngoại lệ này bắt lại được ở khối catch
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        com.ExecuteNonQuery();
                        com.Dispose();
                        //MessageBox.Show("OK");
                    }
                }
                catch (Exception loi)
                {
                    // Khối này thực thi khi có lỗi - đối tượng Exception bắt được lưu ở biến loi
                    //Console.WriteLine("Có lỗi rồi");
                    //Console.WriteLine(loi.Message);
                    MessageBox.Show("Đã phát sinh lỗi");
                    MessageBox.Show(loi.Message);
                }


                con.Close();
                con.Dispose();
            }
        }
    }
}
