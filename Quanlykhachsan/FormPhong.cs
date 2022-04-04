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
    public partial class FormPhong : Form
    {
        public FormPhong()
        {
            InitializeComponent();
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tABLEPHONG2.tblPhong' table. You can move, or remove it, as needed.
            this.tblPhongTableAdapter1.Fill(this.tABLEPHONG2.tblPhong);
            // TODO: This line of code loads data into the 'tBLPHONG.tblPhong' table. You can move, or remove it, as needed.
            this.tblPhongTableAdapter.Fill(this.tBLPHONG.tblPhong);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtSophong.Text == "" || cbSucchua.Text == "" || txtDongia.Text == "" || cbTrangthai.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                int sophong = int.Parse(txtSophong.Text.ToString());
                int dongia = int.Parse(txtDongia.Text.ToString());
                int trangthai = int.Parse(cbTrangthai.Text.ToString());
                string sql_insert = "INSERT INTO tblPhong (iSophong,vSucchua,fDongia,bTrangthai) VALUES ('" + sophong + "', N'" + cbSucchua.Text + "','" + dongia + "', '" + trangthai + "')";
                Connectdata.ExecuteInsertData(sql_insert);
                Loaddata();
            }
        }
        private void Loaddata()
        {
            string sql = "SELECT * FROM tblPhong";
            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgPhong.DataSource = mytable;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtSophong.Text == "")
            {
                MessageBox.Show("Không tồn tại");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn sửa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    if (txtSophong.Text != "")
                    {
                        int sophong = int.Parse(txtSophong.Text.ToString());
                        int dongia = int.Parse(txtDongia.Text.ToString());
                        int trangthai = int.Parse(cbTrangthai.Text.ToString());

                        string sql_insert = "UPDATE tblPhong " +
                            "SET vSucchua = N'" + cbSucchua.Text + "',fDongia = '" + dongia + "',bTrangthai = '" + trangthai + "'   " +
                            "WHERE iSophong = '" + sophong + "' ";
                        Connectdata.ExecuteInsertData(sql_insert);
                        Loaddata();
                        btThem.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập chính xác số đăng ký");
                    }
                }
            }
        }

        private void dgPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddata();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgPhong.Rows[e.RowIndex];

                txtSophong.Text = row.Cells[0].Value.ToString();
                cbSucchua.Text = row.Cells[1].Value.ToString();
                txtDongia.Text = row.Cells[2].Value.ToString();
                if(row.Cells[3].Value.ToString() == "True")
                {
                    cbTrangthai.Text = "1";
                }
                else
                {
                    cbTrangthai.Text = "0";
                }
                //cbTrangthai.Text = row.Cells[3].Value.ToString();

                btThem.Enabled = false;
            }
        }

        private void dgPhong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbSucchua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtSophong.Text != "")
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    int sophong = int.Parse(txtSophong.Text.ToString());
                    string sql_insert = "DELETE FROM tblPhong WHERE iSophong = '" + sophong + "' ";
                    Connectdata.ExecuteInsertData(sql_insert);
                    Loaddata();
                    //MessageBox.Show("Xóa thành công");
                    btThem.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại nhân viên trên");
            }
        }

        private void btBoqua_Click(object sender, EventArgs e)
        {
            txtSophong.Text = "";
            txtDongia.Text = "";
            cbTrangthai.Text = "";
            cbSucchua.Text = "";

            btThem.Enabled = true;
            Loaddata();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            //iSophong,vSucchua,fDongia
            string sql = "SELECT * FROM tblPhong WHERE ";
            if (txtSophong.Text != "")
            {
                sql += "iSophong LIKE N'%" + txtSophong.Text + "%' AND ";
            }
            if (cbSucchua.Text != "")
            {
                sql += "vSucchua LIKE N'%" + cbSucchua.Text + "%' AND ";
            }
            if (txtDongia.Text != "")
            {
                sql += "fDongia LIKE '" + txtDongia.Text + "' AND ";
            }
            if (cbTrangthai.Text != "")
            {
                sql += "bTrangthai = '" + cbTrangthai.Text + "' AND ";
            }
            sql += "0 = 0";

            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgPhong.DataSource = mytable;
        }
    }
}
