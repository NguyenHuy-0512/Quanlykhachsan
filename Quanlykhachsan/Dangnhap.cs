using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlykhachsan
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "nguyenquanghuy" && txtPass.Text == "123456")
            {
                
                /**FormQuanly.Username = txtUser.Text;
                FormQuanly.pass = txtPass.Text;
                FormQuanly frm = new FormQuanly();
                frm.ShowDialog();**/
            }
            else
            {
                MessageBox.Show("User hoặc pass không chính xác");
            }
        }
    }
}
