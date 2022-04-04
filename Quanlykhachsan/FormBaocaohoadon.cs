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
    public partial class FormBaocaohoadon : Form
    {
        //public static string biengido = string.Empty;
        public FormBaocaohoadon()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void crvHoadon_Load(object sender, EventArgs e)
        {
            Baocaohoadon rpt = new Baocaohoadon();
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-SF4GIP15\\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("Select * from tblHoadon ", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crvHoadon.ReportSource = rpt;
        }
    }
}
