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

namespace Quanlykhachsan
{
    public partial class FormBaocaokhachhang : Form
    {
        public FormBaocaokhachhang()
        {
            InitializeComponent();
        }

        private void crystalReportViewer3_Load(object sender, EventArgs e)
        {
            Baocaokhachhang rpt = new Baocaokhachhang();
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-SF4GIP15\\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("Select * from tblKhach", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crvKhachhang.ReportSource = rpt;
        }
    }
}
