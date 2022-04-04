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
    public partial class FormDatphong : Form
    {
        public FormDatphong()
        {
            InitializeComponent();
        }

        private void FormDatphong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tBLDANGKY.tblDangky' table. You can move, or remove it, as needed.
            this.tblDangkyTableAdapter.Fill(this.tBLDANGKY.tblDangky);
            // TODO: This line of code loads data into the 'qUANLYKHACHSANDataSet.tblNhanvien' table. You can move, or remove it, as needed.
            this.tblNhanvienTableAdapter.Fill(this.qUANLYKHACHSANDataSet.tblNhanvien);
            // TODO: This line of code loads data into the 'tBLPHONG.tblPhong' table. You can move, or remove it, as needed.
            this.tblPhongTableAdapter.Fill(this.tBLPHONG.tblPhong);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtCmnd.Text == "" || cbNhanvien.Text == ""|| cbSophong.Text == "" || mtxtNgaydk.Text == "" || mtxtNgaynp.Text =="" || mtxtNgaytp.Text =="")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                int manv = int.Parse(cbNhanvien.SelectedValue.ToString());
                int sophong = int.Parse(cbSophong.Text.ToString());
                //Batdulieu(txtSdt.Text, txtCmnd.Text, txtHoten.Text, txtNgaysinh.Text);
                //string sql_insertkh = "INSERT INTO tblKhach (vSdtkh,vCmnd, vHoten, dNgaysinh) VALUES ('" + txtSdt.Text + "','" + txtCmnd.Text + "', N'" + txtHoten.Text + "', '" + txtNgaysinh.Text + "')";
                //Connectdata.ExecuteInsertData(sql_insertkh);
                string sql_insertdk = "INSERT INTO tblDangky (iManv,vCmnd,iSophong,dNgaydk,dNgaynp,dNgaytp) VALUES ('"+manv+"', '"+txtCmnd.Text+"', '"+sophong+"', '"+mtxtNgaydk.Text+"', '"+mtxtNgaynp.Text+"','"+mtxtNgaytp.Text+"')";
                Connectdata.ExecuteInsertData(sql_insertdk);
                Loaddata();
            }
        }
        private void Loaddata()
        {
            string sql = "SELECT * FROM tblDangky";
            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgDangky.DataSource = mytable;
            lbSodk.Enabled = false;
            cbSodk.Enabled = false;
            btThem.Enabled = true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbSodk.Text == "")
            {
                MessageBox.Show("Không tồn tại");
            }
            else
            {

                int sodk = int.Parse(cbSodk.Text.ToString());
                int manv = int.Parse(cbNhanvien.Text.ToString());
                int sophong = int.Parse(cbSophong.Text.ToString());

                DialogResult dr = MessageBox.Show("Bạn có muốn sửa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    if (cbSodk.Text != "")
                    {
                        string sql_insert = "UPDATE tblDangky " +
                            "SET  iManv = '"+manv+"',vCmnd = '"+txtCmnd.Text+"',iSophong = '"+sophong+"',dNgaydk = '"+mtxtNgaydk.Text+"',dNgaynp = '"+mtxtNgaynp.Text+"',dNgaytp = '"+mtxtNgaytp.Text+ "'  " +
                            "WHERE iSodk = '" + sodk + "' ";
                        Connectdata.ExecuteInsertData(sql_insert);
                        Loaddata();
                        //MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập chính xác số đăng ký");
                    }
                }

                lbSodk.Enabled = false;
                cbSodk.Enabled = false;
                btThem.Enabled = true;
            }
        }

        private void dgDangky_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddata();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgDangky.Rows[e.RowIndex];

                cbSodk.Text = row.Cells[0].Value.ToString();
                cbNhanvien.Text = row.Cells[1].Value.ToString();
                txtCmnd.Text = row.Cells[2].Value.ToString();
                cbSophong.Text = row.Cells[3].Value.ToString();
                mtxtNgaydk.Text = row.Cells[4].Value.ToString();
                mtxtNgaynp.Text = row.Cells[5].Value.ToString();
                mtxtNgaytp.Text = row.Cells[6].Value.ToString();


                lbSodk.Enabled = true;
                cbSodk.Enabled = true;
                btThem.Enabled = false;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbSodk.Text != "")
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    int sodk = int.Parse(cbSodk.Text.ToString());
                    string sql_insert = "DELETE FROM tblDangky WHERE iSodk = '" +sodk+ "' ";
                    Connectdata.ExecuteInsertData(sql_insert);
                    Loaddata();
                    //MessageBox.Show("Xóa thành công");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại số đăng ký trên");
            }

            lbSodk.Enabled = false;
            cbSodk.Enabled = false;
            btThem.Enabled = true;
        }

        private void btBoqua_Click(object sender, EventArgs e)
        {
            cbSodk.Text = "";
            cbNhanvien.Text = "";
            txtCmnd.Text = "";
            cbSophong.Text = "";
            mtxtNgaydk.Text = "";
            mtxtNgaynp.Text = "";
            mtxtNgaytp.Text = "";

            Loaddata();
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblDangky WHERE ";
            //iManv,vCmnd,iSophong
            if (cbNhanvien.Text != "")
            {
                sql += "iManv LIKE N'%" + cbNhanvien.Text + "%' AND ";
            }
            if (txtCmnd.Text != "")
            {
                sql += "vCmnd LIKE N'%" + txtCmnd.Text + "%' AND ";
            }
            if (cbSophong.Text != "")
            {
                sql += "iSophong LIKE '" + cbSophong.Text + "' AND ";
            }
            sql += "0 = 0";

            DataTable mytable = Connectdata.ExcuteDataTable_SQL(sql);
            dgDangky.DataSource = mytable;
        }
    }
}
