
namespace Quanlykhachsan
{
    partial class FormKhachhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCmnd = new System.Windows.Forms.Label();
            this.lbHoten = new System.Windows.Forms.Label();
            this.txtNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.tblKhachBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLKHACH = new Quanlykhachsan.TBLKHACH();
            this.btBoqua = new System.Windows.Forms.Button();
            this.tblKhachTableAdapter1 = new Quanlykhachsan.TBLKHACHTableAdapters.tblKhachTableAdapter();
            this.qUANLYKHACHSANDataSet = new Quanlykhachsan.QUANLYKHACHSANDataSet();
            this.tblNhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhanvienTableAdapter = new Quanlykhachsan.QUANLYKHACHSANDataSetTableAdapters.tblNhanvienTableAdapter();
            this.tableAdapterManager = new Quanlykhachsan.QUANLYKHACHSANDataSetTableAdapters.TableAdapterManager();
            this.tableAdapterManager1 = new Quanlykhachsan.TBLKHACHTableAdapters.TableAdapterManager();
            this.dgKhach = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBaocao = new System.Windows.Forms.Button();
            this.tblKhachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKHACH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(102, 34);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(246, 20);
            this.txtCmnd.TabIndex = 25;
            this.txtCmnd.TextChanged += new System.EventHandler(this.txthang_TextChanged);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(102, 79);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(246, 20);
            this.txtHoten.TabIndex = 24;
            this.txtHoten.TextChanged += new System.EventHandler(this.txtTenLaptop_TextChanged);
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(102, 125);
            this.txtSdt.Multiline = true;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(246, 20);
            this.txtSdt.TabIndex = 23;
            this.txtSdt.TextChanged += new System.EventHandler(this.txtMaLapTop_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số điện thoại";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbCmnd
            // 
            this.lbCmnd.AutoSize = true;
            this.lbCmnd.Location = new System.Drawing.Point(23, 34);
            this.lbCmnd.Name = "lbCmnd";
            this.lbCmnd.Size = new System.Drawing.Size(73, 13);
            this.lbCmnd.TabIndex = 17;
            this.lbCmnd.Text = "CMND/CCCD";
            this.lbCmnd.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Location = new System.Drawing.Point(23, 82);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(39, 13);
            this.lbHoten.TabIndex = 16;
            this.lbHoten.Text = "Họ tên";
            this.lbHoten.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Location = new System.Drawing.Point(496, 31);
            this.txtNgaysinh.Mask = "0000/00/00";
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(127, 20);
            this.txtNgaysinh.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ngày sinh";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(26, 167);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 39);
            this.btThem.TabIndex = 28;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(122, 167);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 39);
            this.btSua.TabIndex = 29;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(232, 167);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 39);
            this.btXoa.TabIndex = 30;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(348, 167);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 39);
            this.btTim.TabIndex = 31;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // tblKhachBindingSource1
            // 
            this.tblKhachBindingSource1.DataMember = "tblKhach";
            this.tblKhachBindingSource1.DataSource = this.tBLKHACH;
            // 
            // tBLKHACH
            // 
            this.tBLKHACH.DataSetName = "TBLKHACH";
            this.tBLKHACH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btBoqua
            // 
            this.btBoqua.Location = new System.Drawing.Point(548, 167);
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(75, 39);
            this.btBoqua.TabIndex = 33;
            this.btBoqua.Text = "Bỏ qua";
            this.btBoqua.UseVisualStyleBackColor = true;
            this.btBoqua.Click += new System.EventHandler(this.btBoqua_Click);
            // 
            // tblKhachTableAdapter1
            // 
            this.tblKhachTableAdapter1.ClearBeforeFill = true;
            // 
            // qUANLYKHACHSANDataSet
            // 
            this.qUANLYKHACHSANDataSet.DataSetName = "QUANLYKHACHSANDataSet";
            this.qUANLYKHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNhanvienBindingSource
            // 
            this.tblNhanvienBindingSource.DataMember = "tblNhanvien";
            this.tblNhanvienBindingSource.DataSource = this.qUANLYKHACHSANDataSet;
            // 
            // tblNhanvienTableAdapter
            // 
            this.tblNhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblNhanvienTableAdapter = this.tblNhanvienTableAdapter;
            this.tableAdapterManager.UpdateOrder = Quanlykhachsan.QUANLYKHACHSANDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblKhachTableAdapter = this.tblKhachTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Quanlykhachsan.TBLKHACHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgKhach
            // 
            this.dgKhach.AllowUserToAddRows = false;
            this.dgKhach.AutoGenerateColumns = false;
            this.dgKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgKhach.DataSource = this.tblKhachBindingSource1;
            this.dgKhach.Location = new System.Drawing.Point(26, 226);
            this.dgKhach.Name = "dgKhach";
            this.dgKhach.Size = new System.Drawing.Size(597, 165);
            this.dgKhach.TabIndex = 33;
            this.dgKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKhach_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "vCmnd";
            this.dataGridViewTextBoxColumn1.HeaderText = "CMND";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "vHoten";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "vSdtkh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dNgaysinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btBaocao
            // 
            this.btBaocao.Location = new System.Drawing.Point(448, 167);
            this.btBaocao.Name = "btBaocao";
            this.btBaocao.Size = new System.Drawing.Size(75, 39);
            this.btBaocao.TabIndex = 34;
            this.btBaocao.Text = "Báo cáo";
            this.btBaocao.UseVisualStyleBackColor = true;
            this.btBaocao.Click += new System.EventHandler(this.btBaocao_Click);
            // 
            // FormKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 429);
            this.Controls.Add(this.btBaocao);
            this.Controls.Add(this.dgKhach);
            this.Controls.Add(this.btBoqua);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgaysinh);
            this.Controls.Add(this.txtCmnd);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCmnd);
            this.Controls.Add(this.lbHoten);
            this.Name = "FormKhachhang";
            this.Text = "FormKhachhang";
            this.Load += new System.EventHandler(this.FormKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKHACH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCmnd;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.MaskedTextBox txtNgaysinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btBoqua;
        private System.Windows.Forms.BindingSource tblKhachBindingSource;
        private TBLKHACH tBLKHACH;
        private System.Windows.Forms.BindingSource tblKhachBindingSource1;
        private TBLKHACHTableAdapters.tblKhachTableAdapter tblKhachTableAdapter1;
        private QUANLYKHACHSANDataSet qUANLYKHACHSANDataSet;
        private System.Windows.Forms.BindingSource tblNhanvienBindingSource;
        private QUANLYKHACHSANDataSetTableAdapters.tblNhanvienTableAdapter tblNhanvienTableAdapter;
        private QUANLYKHACHSANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TBLKHACHTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dgKhach;
        private System.Windows.Forms.Button btBaocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}