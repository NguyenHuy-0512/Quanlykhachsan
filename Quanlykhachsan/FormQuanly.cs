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
    public partial class FormQuanly : Form
    {
        //public static string Username = string.Empty;
        //public static string pass = string.Empty;
        public FormQuanly()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void quảnLýKháchSạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachhang frm = new FormKhachhang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoadon frm = new FormHoadon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatphong frm = new FormDatphong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýPhonhfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanvien frm = new FormNhanvien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhong frm = new FormPhong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDichvu frm = new FormDichvu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýHóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoadon frm = new FormHoadon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thuêPhòngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormThue frm = new FormThue();
            frm.MdiParent = this;
            frm.Show();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTra frm = new FormTra();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormQuanly_Load(object sender, EventArgs e)
        {
            /*if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(pass))
            {
                this.lbuser.Text = Username;
                this.lbpass.Text = pass;

            }*/
        }
    }
}
