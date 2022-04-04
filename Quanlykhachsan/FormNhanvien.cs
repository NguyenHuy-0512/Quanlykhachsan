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
    public partial class FormNhanvien : Form
    {
        public FormNhanvien()
        {
            InitializeComponent();
        }

        private void FormNhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYKHACHSANDataSet.tblNhanvien' table. You can move, or remove it, as needed.
            this.tblNhanvienTableAdapter.Fill(this.qUANLYKHACHSANDataSet.tblNhanvien);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == "" || txtSdt.Text == "" || txtNgaysinh.Text == "" || txtDiachi.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                //Batdulieu(txtSdt.Text, txtCmnd.Text, txtHoten.Text, txtNgaysinh.Text);
                string sql_insert = "INSERT INTO tblNhanvien (vHoten,dNgaysinh,vSodienthoai,vDiachi) VALUES ('" + txtHoten.Text + "', N'" + txtNgaysinh.Text + "','" + txtSdt.Text + "', '" + txtDiachi.Text + "')";
                Connectdata.ExecuteInsertData(sql_insert);
                Loaddata();
            }
        }
        private void Loaddata()
        {
            string sql = "SELECT * FROM tblNhanvien";
            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgNhanvien.DataSource = mytable;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbManv.Text == "")
            {
                MessageBox.Show("Không tồn tại nhân viên trên");
            }
            else
            {

                int manv = int.Parse(cbManv.Text.ToString());

                DialogResult dr = MessageBox.Show("Bạn có muốn sửa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    if (cbManv.Text != "")
                    {
                        string sql_insert = "UPDATE tblNhanvien SET vDiachi = N'" + txtDiachi.Text + "', vHoten = N'" + txtHoten.Text + "', dNgaysinh = '" + txtNgaysinh.Text + "' WHERE iManv = '" + manv + "' ";
                        Connectdata.ExecuteInsertData(sql_insert);
                        Loaddata();
                        //MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập chính xác số CMND");
                    }
                }
                lbManv.Enabled = false;
                cbManv.Enabled = false;
                btThem.Enabled = true;
            }
        }

        private void dgNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddata();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgNhanvien.Rows[e.RowIndex];

                cbManv.Text = row.Cells[0].Value.ToString();
                txtHoten.Text = row.Cells[1].Value.ToString();
                txtNgaysinh.Text = row.Cells[2].Value.ToString();
                txtSdt.Text = row.Cells[3].Value.ToString();
                txtDiachi.Text = row.Cells[4].Value.ToString();

                lbManv.Enabled = true;
                cbManv.Enabled = true;
                btThem.Enabled = false;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
                // delete
            if (cbManv.Text != "")
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    int manv = int.Parse(cbManv.Text.ToString());
                    string sql_insert = "DELETE FROM tblNhanvien WHERE iManv = '" + manv + "' ";
                    Connectdata.ExecuteInsertData(sql_insert);
                    Loaddata();
                    //MessageBox.Show("Xóa thành công");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại nhân viên trên");
            }
            
        }

        private void btBoqua_Click(object sender, EventArgs e)
        {
            cbManv.Text = "";
            txtDiachi.Text = "";
            txtHoten.Text = "";
            txtSdt.Text = "";
            txtNgaysinh.Text = "";


            lbManv.Enabled = false;
            cbManv.Enabled = false;
            btThem.Enabled = true;
            Loaddata();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblDangky WHERE ";
            if (cbManv.Text != "")
            {
                sql += "iManv LIKE N'%" + cbManv.Text + "%' AND ";
            }
            if (txtHoten.Text != "")
            {
                sql += "vHoten LIKE N'%" + txtHoten.Text + "%' AND ";
            }
            if (txtSdt.Text != "")
            {
                sql += "vSodienthoai LIKE '" + txtSdt.Text + "' AND ";
            }
            sql += "0 = 0";

            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgNhanvien.DataSource = mytable;
        }

        private void dgNhanvien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btBaocao_Click(object sender, EventArgs e)
        {
            FormBaocaonhanvien frm = new FormBaocaonhanvien();
            frm.Show();
        }
    }
}
