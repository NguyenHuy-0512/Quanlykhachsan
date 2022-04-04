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
    public partial class FormHoadon : Form
    {
        public FormHoadon()
        {
            InitializeComponent();
        }

        private void FormHoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tBLHOADONCOTRANGTHAI.tblHoadon' table. You can move, or remove it, as needed.
            this.tblHoadonTableAdapter1.Fill(this.tBLHOADONCOTRANGTHAI.tblHoadon);
            // TODO: This line of code loads data into the 'tBLHOADON.tblHoadon' table. You can move, or remove it, as needed.
            this.tblHoadonTableAdapter.Fill(this.tBLHOADON.tblHoadon);
            // TODO: This line of code loads data into the 'tBLDICHVU.tblDichvu' table. You can move, or remove it, as needed.
            this.tblDichvuTableAdapter.Fill(this.tBLDICHVU.tblDichvu);
            // TODO: This line of code loads data into the 'tBLDANGKY.tblDangky' table. You can move, or remove it, as needed.
            this.tblDangkyTableAdapter.Fill(this.tBLDANGKY.tblDangky);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbMadv.Text == "" || cbSodk.Text == "" || mtxtNgaysd1.Text == "" )
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                int madv = int.Parse(cbMadv.Text.ToString());
                int sodk = int.Parse(cbSodk.Text.ToString());

                //Batdulieu(txtSdt.Text, txtCmnd.Text, txtHoten.Text, txtNgaysinh.Text);
                string sql_insertkh = "INSERT INTO tblHoadon (iSodk,iMadv,dNgaysd) VALUES ('" + sodk + "','" + madv + "', '"+mtxtNgaysd1.Text+"')";
                Connectdata.ExecuteInsertData(sql_insertkh);
               
                Loaddata();
            }
        }
        private void Loaddata()
        {
            string sql = "SELECT * FROM tblHoadon";
            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgHoadon.DataSource = mytable;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtSohd.Text == "")
            {
                MessageBox.Show("Không tồn tại");
            }
            else
            {
                int sohd = int.Parse(txtSohd.Text.ToString());
                int sodk = int.Parse(cbSodk.Text.ToString());
                int madv = int.Parse(cbMadv.Text.ToString());

                DialogResult dr = MessageBox.Show("Bạn có muốn sửa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    if (cbSodk.Text != "")
                    {
                        string sql_insert = "UPDATE tblHoadon " +
                            "SET  iSodk = '"+sodk+"',iMadv = '"+madv+"',dNgaysd = '"+mtxtNgaysd1.Text+"'" +
                            "WHERE iSohd = '" + sohd + "' ";
                        Connectdata.ExecuteInsertData(sql_insert);
                        Loaddata();
                        //MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập chính xác số đăng ký");
                    }
                }
                btThem.Enabled = true;
                lbSohd.Enabled = false;
                txtSohd.Enabled = false;
            }
        }

        private void dgHoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddata();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgHoadon.Rows[e.RowIndex];

                txtSohd.Text = row.Cells[0].Value.ToString();
                cbSodk.Text = row.Cells[1].Value.ToString();
                cbMadv.Text = row.Cells[2].Value.ToString();
                mtxtNgaysd1.Text = row.Cells[3].Value.ToString();


                lbSohd.Enabled = true;
                txtSohd.Enabled = true;
                btThem.Enabled = false;
            }
        }

        private void btBoqua_Click(object sender, EventArgs e)
        {
            txtSohd.Text = "";
            cbMadv.Text = "";
            cbSodk.Text = "";
            mtxtNgaysd1.Text = "";
            lbSohd.Enabled = false;
            txtSohd.Enabled = false;

            Loaddata();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtSohd.Text != "")
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    int sohd = int.Parse(txtSohd.Text.ToString());
                    string sql_insert = "DELETE FROM tblHoadon WHERE iSohd = '" + sohd + "' ";
                    Connectdata.ExecuteInsertData(sql_insert);
                    Loaddata();
                    //MessageBox.Show("Xóa thành công");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại");
            }
        }

        private void dgHoadon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btTim_Click(object sender, EventArgs e)
        {
            // iSodk,iMadv,dNgaysd
            string sql = "SELECT * FROM tblHoadon WHERE ";
            if (txtSohd.Text != "")
            {
                sql += "iSohd LIKE N'%" + txtSohd.Text + "%' AND ";
            }
            if (cbSodk.Text != "")
            {
                sql += "iSodk LIKE N'%" + cbSodk.Text + "%' AND ";
            }
            if (cbMadv.Text != "")
            {
                sql += "iMadv LIKE '" + cbMadv.Text + "' AND ";
            }
            if (mtxtNgaysd1.Text != "")
            {
                sql += "dNgaysd = '" + mtxtNgaysd1.Text + "' AND ";
            }
            sql += "0 = 0";

            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgHoadon.DataSource = mytable;
        }
    }
}
