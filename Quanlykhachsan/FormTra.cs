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
    public partial class FormTra : Form
    {
        public FormTra()
        {
            InitializeComponent();
        }

        private void tblDangkyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDangkyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tBLDANGKY);

        }

        private void FormTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tBLHOADONCOTRANGTHAI.tblHoadon' table. You can move, or remove it, as needed.
            this.tblHoadonTableAdapter.Fill(this.tBLHOADONCOTRANGTHAI.tblHoadon);
            // TODO: This line of code loads data into the 'tBLDANGKY_GIAPHONG.prc_dangky_giaphong_select' table. You can move, or remove it, as needed.
            this.prc_dangky_giaphong_selectTableAdapter.Fill(this.tBLDANGKY_GIAPHONG.prc_dangky_giaphong_select);
            // TODO: This line of code loads data into the 'tABLEPHONG2.tblPhong' table. You can move, or remove it, as needed.
            this.tblPhongTableAdapter.Fill(this.tABLEPHONG2.tblPhong);
            // TODO: This line of code loads data into the 'tBLDICHVU.tblDichvu' table. You can move, or remove it, as needed.
            this.tblDichvuTableAdapter.Fill(this.tBLDICHVU.tblDichvu);
            // TODO: This line of code loads data into the 'tBLDANGKY.tblDangky' table. You can move, or remove it, as needed.
            this.tblDangkyTableAdapter.Fill(this.tBLDANGKY.tblDangky);

        }

        private void dgDangky_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Loaddata();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgDangky.Rows[e.RowIndex];

                lbSodk.Text = row.Cells[0].Value.ToString();
                lbNhanvien.Text = row.Cells[1].Value.ToString();
                lbCmnd.Text = row.Cells[2].Value.ToString();
                lbSophong.Text = row.Cells[3].Value.ToString();
                lbNgaydk.Text = row.Cells[5].Value.ToString();
                lbNgayht.Text = row.Cells[6].Value.ToString();
                //lbNgayht.Text = DateTime.Now.ToString("yyyy-MM-dd");
                lbGia.Text = row.Cells[7].Value.ToString();
            }
        }

        private void dgPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgPhong.Rows[e.RowIndex];

                lbSophong.Text = row.Cells[0].Value.ToString();
                lbGia.Text = row.Cells[1].Value.ToString();
            }*/
        }

        private void btTinhtien_Click(object sender, EventArgs e)
        {
            if (lbNgaydk.Text !="" && lbNgayht.Text != "" && lbGia.Text != "" && lbTiendv.Text != "" && lbGiadv.Text !="") {
                DateTime ngaydi = Convert.ToDateTime(lbNgaydk.Text);
                DateTime ngayve = Convert.ToDateTime(lbNgayht.Text);
                TimeSpan Time = ngayve - ngaydi;
                int TongSoNgay = Time.Days;
                int dongia = int.Parse(lbGia.Text);
                lbTiendv.Text = lbGiadv.Text;

                int Tiendv = int.Parse(lbTiendv.Text);


                if (TongSoNgay <= 0)
                {
                    TongSoNgay = 1;
                }
                int tongtien = TongSoNgay * dongia;
                lbSongay.Text = TongSoNgay.ToString();
                lbTongtien.Text = tongtien.ToString() + " VNĐ";
            }
            else
            {
                MessageBox.Show("Hãy chọn đầy đủ thông tin");
            }

        }

        private void dgDichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgDichvu.Rows[e.RowIndex];

                cbMadv.Text = row.Cells[0].Value.ToString();
                lbGiadv.Text = row.Cells[2].Value.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btThanhtoan_Click(object sender, EventArgs e)
        {
            if (lbSodk.Text == "" || cbMadv.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                int sodk = int.Parse(lbSodk.Text.ToString());
                int madv = int.Parse(cbMadv.Text.ToString());
                string dateht = DateTime.Now.ToString("yyyy-MM-dd");
                //Them hoa don
                string sql_insert = "INSERT INTO tblHoadon (iSodk,iMadv,dNgaysd,bTrangthai) VALUES ('" + sodk + "', '" + madv + "', '" + dateht + "', '"+0+"')";
                Connectdata.ExecuteInsertData(sql_insert);
                Loaddata();
            }
        }

        private void Loaddata()
        {
            string sql = "SELECT * FROM tblHoadon";
            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgHoadon.DataSource = mytable;
        }

        private void dgHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgHoadon.Rows[e.RowIndex];

                cbSohd.Text = row.Cells[0].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbSohd.Text == "")
            {
                MessageBox.Show("Không tồn tại");
            }
            else
            {
                int sohd = int.Parse(cbSohd.Text.ToString());

                DialogResult dr = MessageBox.Show("Bạn có muốn thanh toán không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    string sql_insert = "UPDATE tblHoadon " +
                    "SET  bTrangthai = 1" +
                    "WHERE iSohd = '" + sohd + "' ";
                    Connectdata.ExecuteInsertData(sql_insert);
                    Loaddata();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            /**string sql = "SELECT * FROM tblHoadon";
            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            //dgHoadon.DataSource = mytable;
            Baocaohoadon rp = new Baocaohoadon();
            rp.SetDataSource(mytable);**/
            FormBaocaohoadon frm = new FormBaocaohoadon();
            frm.Show();


        }
    }
}
