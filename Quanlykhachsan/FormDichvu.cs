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
    public partial class FormDichvu : Form
    {
        public FormDichvu()
        {
            InitializeComponent();
        }

        private void FormDichvu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tBLDICHVU.tblDichvu' table. You can move, or remove it, as needed.
            this.tblDichvuTableAdapter.Fill(this.tBLDICHVU.tblDichvu);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTendv.Text == "" || txtDongia.Text == "" )
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                //int madv = int.Parse(cbMadv.SelectedValue.ToString());
                int dongia = int.Parse(txtDongia.Text.ToString());
                //Batdulieu(txtSdt.Text, txtCmnd.Text, txtHoten.Text, txtNgaysinh.Text);
                string sql_insert = "INSERT INTO tblDichvu (vTendv,fGiadv) VALUES (N'"+txtTendv.Text+"','" + dongia + "' )";
                Connectdata.ExecuteInsertData(sql_insert);
                Loaddata();
            }
        }
        private void Loaddata()
        {
            string sql = "SELECT * FROM tblDichvu";
            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgDichvu.DataSource = mytable;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbMadv.Text == "")
            {
                MessageBox.Show("Không tồn tại dịch vụ");
            }
            else
            {

                int madv = int.Parse(cbMadv.Text.ToString());
                int dongia = int.Parse(txtDongia.Text.ToString());

                DialogResult dr = MessageBox.Show("Bạn có muốn sửa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    if (cbMadv.Text != "")
                    {
                        string sql_insert = "UPDATE tblDichvu SET vTendv = N'"+txtTendv.Text+"', fGiadv = '"+dongia+"'  WHERE iMadv = '" + madv + "' ";
                        Connectdata.ExecuteInsertData(sql_insert);
                        Loaddata();
                        //MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập chính xác số CMND");
                    }
                }
                lbMadv.Enabled = false;
                cbMadv.Enabled = false;
                btThem.Enabled = true;
            }
        }

        private void dgDichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddata();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgDichvu.Rows[e.RowIndex];

                cbMadv.Text = row.Cells[0].Value.ToString();
                txtTendv.Text = row.Cells[1].Value.ToString();
                txtDongia.Text = row.Cells[2].Value.ToString();

                lbMadv.Enabled = true;
                cbMadv.Enabled = true;
                btThem.Enabled = false;
            }
        }

        private void dgDichvu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbMadv.Text != "")
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    int madv = int.Parse(cbMadv.Text.ToString());
                    string sql_insert = "DELETE FROM tblDichvu WHERE iMadv = '" + madv + "' ";
                    Connectdata.ExecuteInsertData(sql_insert);
                    Loaddata();
                    //MessageBox.Show("Xóa thành công");
                    lbMadv.Enabled = false;
                    cbMadv.Enabled = false;
                    btThem.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại dịch vụ trên");
            }
        }

        private void btBoqua_Click(object sender, EventArgs e)
        {
            cbMadv.Text = "";
            txtTendv.Text = "";
            txtDongia.Text = "";

            lbMadv.Enabled = false;
            cbMadv.Enabled = false;
            btThem.Enabled = true;
            Loaddata();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblDichvu WHERE ";
            //vTendv,fGiadv
            if (cbMadv.Text != "")
            {
                sql += "iMadv LIKE N'%" + cbMadv.Text + "%' AND ";
            }
            if (txtTendv.Text != "")
            {
                sql += "vTendv LIKE N'%" + txtTendv.Text + "%' AND ";
            }
            sql += "0 = 0";

            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgDichvu.DataSource = mytable;
        }
    }
}
