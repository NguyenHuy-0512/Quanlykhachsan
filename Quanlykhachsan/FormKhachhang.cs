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
    public partial class FormKhachhang : Form
    {
        public FormKhachhang()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkhoiluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcolor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenLaptop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaLapTop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormKhachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYKHACHSANDataSet.tblNhanvien' table. You can move, or remove it, as needed.
            this.tblNhanvienTableAdapter.Fill(this.qUANLYKHACHSANDataSet.tblNhanvien);
            // TODO: This line of code loads data into the 'tBLKHACH.tblKhach' table. You can move, or remove it, as needed.
            this.tblKhachTableAdapter1.Fill(this.tBLKHACH.tblKhach);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtCmnd.Text == "" || txtSdt.Text == "" || txtHoten.Text == "" || txtNgaysinh.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                //Batdulieu(txtSdt.Text, txtCmnd.Text, txtHoten.Text, txtNgaysinh.Text);
                string sql_insert = "INSERT INTO tblKhach (vSdtkh,vCmnd, vHoten, dNgaysinh) VALUES ('" + txtSdt.Text + "','" + txtCmnd.Text + "', N'" + txtHoten.Text + "', '" + txtNgaysinh.Text + "')";
                Connectdata.ExecuteInsertData(sql_insert);
                Loaddata();
            }
        }
        private void Loaddata()
        {
            string sql = "SELECT * FROM tblKhach";
            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgKhach.DataSource = mytable;

            btThem.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                // delete
                if (txtCmnd.Text != "")
                {
                    string sql_insert = "DELETE FROM tblKhach WHERE vCmnd = '" + txtCmnd.Text + "' ";
                    Connectdata.ExecuteInsertData(sql_insert);
                    Loaddata();
                }
                else
                {
                    MessageBox.Show("Không tồn tại số điện thoại trên");
                }
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblKhach WHERE ";
            if (txtSdt.Text != "")
            {
                sql += "vSdtkh LIKE N'%" + txtSdt.Text + "%' AND ";
            }
            if (txtHoten.Text != "")
            {
                sql += "vHoten LIKE N'%" + txtHoten.Text + "%' AND ";
            }
            if (txtCmnd.Text != "")
            {
                sql += "vCmnd LIKE '" + txtCmnd.Text + "' AND ";
            }
            /**if (txtNgaysinh.Text != "")
            {
                sql += "dNgaysinh = '" + txtNgaysinh.Text + "' AND ";
            }**/
            sql += "0 = 0";

            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgKhach.DataSource = mytable;
        }

        private void btBoqua_Click(object sender, EventArgs e)
        {
            txtSdt.Text = "";
            txtCmnd.Text = "";
            txtHoten.Text = "";
            txtNgaysinh.Text = "";

            Loaddata();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                if (txtCmnd.Text != "")
                {
                    string sql_insert = "UPDATE tblKhach SET vSdtkh = '" + txtSdt.Text + "', vHoten = N'" + txtHoten.Text + "', dNgaysinh = '" + txtNgaysinh.Text + "' WHERE vCmnd = '" + txtCmnd.Text + "' ";
                    Connectdata.ExecuteInsertData(sql_insert);
                    Loaddata();
                }
                else
                {
                    MessageBox.Show("Hãy nhập chính xác số CMND");
                }
            }
        }

        private void btBaocao_Click(object sender, EventArgs e)
        {
            FormBaocaokhachhang frm = new FormBaocaokhachhang();
            frm.Show();
        }

        private void dgKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgKhach.Rows[e.RowIndex];

            txtCmnd.Text = row.Cells[0].Value.ToString();
            txtHoten.Text = row.Cells[1].Value.ToString();
            txtSdt.Text = row.Cells[2].Value.ToString();
            txtNgaysinh.Text = row.Cells[3].Value.ToString();

            btThem.Enabled = false;
        }
    }
}
