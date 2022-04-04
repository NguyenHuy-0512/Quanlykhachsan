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
    public partial class FormThue : Form
    {
        public FormThue()
        {
            InitializeComponent();
        }

        private void tblKhachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblKhachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tBLKHACH);

        }

        private void FormThue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYKHACHSANDataSet.tblNhanvien' table. You can move, or remove it, as needed.
            this.tblNhanvienTableAdapter.Fill(this.qUANLYKHACHSANDataSet.tblNhanvien);
            // TODO: This line of code loads data into the 'pHONGTRONG.prc_phongtrong_select' table. You can move, or remove it, as needed.
            this.prc_phongtrong_selectTableAdapter.Fill(this.pHONGTRONG.prc_phongtrong_select);
            // TODO: This line of code loads data into the 'tABLEPHONG2.tblPhong' table. You can move, or remove it, as needed.
            this.tblPhongTableAdapter.Fill(this.tABLEPHONG2.tblPhong);
            // TODO: This line of code loads data into the 'tBLDANGKY.tblDangky' table. You can move, or remove it, as needed.
            this.tblDangkyTableAdapter.Fill(this.tBLDANGKY.tblDangky);
            // TODO: This line of code loads data into the 'tBLKHACH.tblKhach' table. You can move, or remove it, as needed.
            this.tblKhachTableAdapter.Fill(this.tBLKHACH.tblKhach);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtCmnd.Text == "" || cbNhanvien.Text == "" || cbSophong.Text == "" || mtxtNgaydk.Text == "" || mtxtNgaynp.Text == "" || mtxtNgaytp.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                int manv = int.Parse(cbNhanvien.SelectedValue.ToString());
                int sophong = int.Parse(cbSophong.Text.ToString());
                //Them dang ky
                string sql_insertdk = "INSERT INTO tblDangky (iManv,vCmnd,iSophong,dNgaydk,dNgaynp,dNgaytp) VALUES ('" + manv + "', '" + txtCmnd.Text + "', '" + sophong + "', '" + mtxtNgaydk.Text + "', '" + mtxtNgaynp.Text + "','" + mtxtNgaytp.Text + "')";
                Connectdata.ExecuteInsertData(sql_insertdk);
                // Set phong
                 string sql_updatephong = "UPDATE tblPhong  SET bTrangthai = 1 WHERE iSophong = '" + sophong + "'";
                 Connectdata.ExecuteInsertData(sql_updatephong);
                Loaddatathue();
                Loaddataphong();
            }
        }
        private void Loaddatathue()
        {
            string sql = "SELECT * FROM tblDangky";
            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgThue.DataSource = mytable;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblPhongTableAdapter.FillBy(this.tABLEPHONG2.tblPhong);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void layphongtrongToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblPhongTableAdapter.Layphongtrong(this.tABLEPHONG2.tblPhong);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btCapnhatkhach_Click(object sender, EventArgs e)
        {
            FormKhachhang frm = new FormKhachhang();
            frm.Show();
        }

        private void dgKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddatakhach();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgKhach.Rows[e.RowIndex];

                txtCmnd.Text = row.Cells[0].Value.ToString();
            }
        }
        private void Loaddatakhach()
        {
            string sqlkh = "SELECT * FROM tblKhach";
            DataTable mytablekh = Connectdata.ExcuteDataTable_SQL(sqlkh);
            dgKhach.DataSource = mytablekh;
        }

        private void dgPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddataphong();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgPhong.Rows[e.RowIndex];

                cbSophong.Text = row.Cells[0].Value.ToString();
            }
        }
        private void Loaddataphong()
        {
            string sql = "SELECT * FROM tblPhong WHERE bTrangthai = 0";
            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgPhong.DataSource = mytable;
        }

        private void btCapnhatphong_Click(object sender, EventArgs e)
        {
            FormPhong frm = new FormPhong();
            frm.Show();
        }

        private void dgThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddatathue();
        }
    }
}
