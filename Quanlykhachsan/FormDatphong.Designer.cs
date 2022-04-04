
namespace Quanlykhachsan
{
    partial class FormDatphong
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgDangky = new System.Windows.Forms.DataGridView();
            this.iSodkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iManvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCmndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSophongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaydkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaynpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaytpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDangkyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLDANGKY = new Quanlykhachsan.TBLDANGKY();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dNgaytraphong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNhanvien = new System.Windows.Forms.ComboBox();
            this.tblNhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYKHACHSANDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYKHACHSANDataSet = new Quanlykhachsan.QUANLYKHACHSANDataSet();
            this.lbNhanvien = new System.Windows.Forms.Label();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.lbCmnd = new System.Windows.Forms.Label();
            this.tBLPHONG = new Quanlykhachsan.TBLPHONG();
            this.tblPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPhongTableAdapter = new Quanlykhachsan.TBLPHONGTableAdapters.tblPhongTableAdapter();
            this.cbSophong = new System.Windows.Forms.ComboBox();
            this.tblNhanvienTableAdapter = new Quanlykhachsan.QUANLYKHACHSANDataSetTableAdapters.tblNhanvienTableAdapter();
            this.tblDangkyTableAdapter = new Quanlykhachsan.TBLDANGKYTableAdapters.tblDangkyTableAdapter();
            this.mtxtNgaydk = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNgaynp = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNgaytp = new System.Windows.Forms.MaskedTextBox();
            this.lbSodk = new System.Windows.Forms.Label();
            this.tblDangkyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbSodk = new System.Windows.Forms.ComboBox();
            this.btBoqua = new System.Windows.Forms.Button();
            this.btTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDangky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangkyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDANGKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHACHSANDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPHONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangkyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Số phòng";
            // 
            // dgDangky
            // 
            this.dgDangky.AllowUserToAddRows = false;
            this.dgDangky.AutoGenerateColumns = false;
            this.dgDangky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDangky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDangky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSodkDataGridViewTextBoxColumn,
            this.iManvDataGridViewTextBoxColumn,
            this.vCmndDataGridViewTextBoxColumn,
            this.iSophongDataGridViewTextBoxColumn,
            this.dNgaydkDataGridViewTextBoxColumn,
            this.dNgaynpDataGridViewTextBoxColumn,
            this.dNgaytpDataGridViewTextBoxColumn});
            this.dgDangky.DataSource = this.tblDangkyBindingSource;
            this.dgDangky.Location = new System.Drawing.Point(10, 252);
            this.dgDangky.Name = "dgDangky";
            this.dgDangky.Size = new System.Drawing.Size(658, 172);
            this.dgDangky.TabIndex = 61;
            this.dgDangky.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDangky_CellContentClick);
            // 
            // iSodkDataGridViewTextBoxColumn
            // 
            this.iSodkDataGridViewTextBoxColumn.DataPropertyName = "iSodk";
            this.iSodkDataGridViewTextBoxColumn.HeaderText = "iSodk";
            this.iSodkDataGridViewTextBoxColumn.Name = "iSodkDataGridViewTextBoxColumn";
            this.iSodkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iManvDataGridViewTextBoxColumn
            // 
            this.iManvDataGridViewTextBoxColumn.DataPropertyName = "iManv";
            this.iManvDataGridViewTextBoxColumn.HeaderText = "iManv";
            this.iManvDataGridViewTextBoxColumn.Name = "iManvDataGridViewTextBoxColumn";
            // 
            // vCmndDataGridViewTextBoxColumn
            // 
            this.vCmndDataGridViewTextBoxColumn.DataPropertyName = "vCmnd";
            this.vCmndDataGridViewTextBoxColumn.HeaderText = "vCmnd";
            this.vCmndDataGridViewTextBoxColumn.Name = "vCmndDataGridViewTextBoxColumn";
            // 
            // iSophongDataGridViewTextBoxColumn
            // 
            this.iSophongDataGridViewTextBoxColumn.DataPropertyName = "iSophong";
            this.iSophongDataGridViewTextBoxColumn.HeaderText = "iSophong";
            this.iSophongDataGridViewTextBoxColumn.Name = "iSophongDataGridViewTextBoxColumn";
            // 
            // dNgaydkDataGridViewTextBoxColumn
            // 
            this.dNgaydkDataGridViewTextBoxColumn.DataPropertyName = "dNgaydk";
            this.dNgaydkDataGridViewTextBoxColumn.HeaderText = "dNgaydk";
            this.dNgaydkDataGridViewTextBoxColumn.Name = "dNgaydkDataGridViewTextBoxColumn";
            // 
            // dNgaynpDataGridViewTextBoxColumn
            // 
            this.dNgaynpDataGridViewTextBoxColumn.DataPropertyName = "dNgaynp";
            this.dNgaynpDataGridViewTextBoxColumn.HeaderText = "dNgaynp";
            this.dNgaynpDataGridViewTextBoxColumn.Name = "dNgaynpDataGridViewTextBoxColumn";
            // 
            // dNgaytpDataGridViewTextBoxColumn
            // 
            this.dNgaytpDataGridViewTextBoxColumn.DataPropertyName = "dNgaytp";
            this.dNgaytpDataGridViewTextBoxColumn.HeaderText = "dNgaytp";
            this.dNgaytpDataGridViewTextBoxColumn.Name = "dNgaytpDataGridViewTextBoxColumn";
            // 
            // tblDangkyBindingSource
            // 
            this.tblDangkyBindingSource.DataMember = "tblDangky";
            this.tblDangkyBindingSource.DataSource = this.tBLDANGKY;
            // 
            // tBLDANGKY
            // 
            this.tBLDANGKY.DataSetName = "TBLDANGKY";
            this.tBLDANGKY.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(276, 187);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 44);
            this.btXoa.TabIndex = 60;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(142, 187);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 44);
            this.btSua.TabIndex = 59;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(10, 187);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 44);
            this.btThem.TabIndex = 58;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dNgaytraphong
            // 
            this.dNgaytraphong.AutoSize = true;
            this.dNgaytraphong.Location = new System.Drawing.Point(391, 147);
            this.dNgaytraphong.Name = "dNgaytraphong";
            this.dNgaytraphong.Size = new System.Drawing.Size(80, 13);
            this.dNgaytraphong.TabIndex = 57;
            this.dNgaytraphong.Text = "Ngày trả phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Ngày nhận phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Ngày đăng ký";
            // 
            // cbNhanvien
            // 
            this.cbNhanvien.DataSource = this.tblNhanvienBindingSource;
            this.cbNhanvien.DisplayMember = "iManv";
            this.cbNhanvien.FormattingEnabled = true;
            this.cbNhanvien.Location = new System.Drawing.Point(103, 59);
            this.cbNhanvien.Name = "cbNhanvien";
            this.cbNhanvien.Size = new System.Drawing.Size(139, 21);
            this.cbNhanvien.TabIndex = 51;
            this.cbNhanvien.ValueMember = "iManv";
            // 
            // tblNhanvienBindingSource
            // 
            this.tblNhanvienBindingSource.DataMember = "tblNhanvien";
            this.tblNhanvienBindingSource.DataSource = this.qUANLYKHACHSANDataSetBindingSource;
            // 
            // qUANLYKHACHSANDataSetBindingSource
            // 
            this.qUANLYKHACHSANDataSetBindingSource.DataSource = this.qUANLYKHACHSANDataSet;
            this.qUANLYKHACHSANDataSetBindingSource.Position = 0;
            // 
            // qUANLYKHACHSANDataSet
            // 
            this.qUANLYKHACHSANDataSet.DataSetName = "QUANLYKHACHSANDataSet";
            this.qUANLYKHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbNhanvien
            // 
            this.lbNhanvien.AutoSize = true;
            this.lbNhanvien.Location = new System.Drawing.Point(10, 63);
            this.lbNhanvien.Name = "lbNhanvien";
            this.lbNhanvien.Size = new System.Drawing.Size(71, 13);
            this.lbNhanvien.TabIndex = 50;
            this.lbNhanvien.Text = "Nhân viên dk";
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(105, 15);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(138, 20);
            this.txtCmnd.TabIndex = 69;
            // 
            // lbCmnd
            // 
            this.lbCmnd.AutoSize = true;
            this.lbCmnd.Location = new System.Drawing.Point(12, 15);
            this.lbCmnd.Name = "lbCmnd";
            this.lbCmnd.Size = new System.Drawing.Size(73, 13);
            this.lbCmnd.TabIndex = 65;
            this.lbCmnd.Text = "CMND/CCCD";
            // 
            // tBLPHONG
            // 
            this.tBLPHONG.DataSetName = "TBLPHONG";
            this.tBLPHONG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPhongBindingSource
            // 
            this.tblPhongBindingSource.DataMember = "tblPhong";
            this.tblPhongBindingSource.DataSource = this.tBLPHONG;
            // 
            // tblPhongTableAdapter
            // 
            this.tblPhongTableAdapter.ClearBeforeFill = true;
            // 
            // cbSophong
            // 
            this.cbSophong.DataSource = this.tblPhongBindingSource;
            this.cbSophong.DisplayMember = "iSophong";
            this.cbSophong.FormattingEnabled = true;
            this.cbSophong.Location = new System.Drawing.Point(451, 56);
            this.cbSophong.Name = "cbSophong";
            this.cbSophong.Size = new System.Drawing.Size(96, 21);
            this.cbSophong.TabIndex = 72;
            this.cbSophong.ValueMember = "iSophong";
            // 
            // tblNhanvienTableAdapter
            // 
            this.tblNhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // tblDangkyTableAdapter
            // 
            this.tblDangkyTableAdapter.ClearBeforeFill = true;
            // 
            // mtxtNgaydk
            // 
            this.mtxtNgaydk.Location = new System.Drawing.Point(473, 100);
            this.mtxtNgaydk.Mask = "0000/00/00";
            this.mtxtNgaydk.Name = "mtxtNgaydk";
            this.mtxtNgaydk.Size = new System.Drawing.Size(74, 20);
            this.mtxtNgaydk.TabIndex = 73;
            this.mtxtNgaydk.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtNgaynp
            // 
            this.mtxtNgaynp.Location = new System.Drawing.Point(104, 140);
            this.mtxtNgaynp.Mask = "0000/00/00";
            this.mtxtNgaynp.Name = "mtxtNgaynp";
            this.mtxtNgaynp.Size = new System.Drawing.Size(74, 20);
            this.mtxtNgaynp.TabIndex = 74;
            this.mtxtNgaynp.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtNgaytp
            // 
            this.mtxtNgaytp.Location = new System.Drawing.Point(473, 144);
            this.mtxtNgaytp.Mask = "0000/00/00";
            this.mtxtNgaytp.Name = "mtxtNgaytp";
            this.mtxtNgaytp.Size = new System.Drawing.Size(74, 20);
            this.mtxtNgaytp.TabIndex = 75;
            this.mtxtNgaytp.ValidatingType = typeof(System.DateTime);
            // 
            // lbSodk
            // 
            this.lbSodk.AutoSize = true;
            this.lbSodk.Enabled = false;
            this.lbSodk.Location = new System.Drawing.Point(11, 103);
            this.lbSodk.Name = "lbSodk";
            this.lbSodk.Size = new System.Drawing.Size(62, 13);
            this.lbSodk.TabIndex = 76;
            this.lbSodk.Text = "Số đăng ký";
            // 
            // tblDangkyBindingSource1
            // 
            this.tblDangkyBindingSource1.DataMember = "tblDangky";
            this.tblDangkyBindingSource1.DataSource = this.tBLDANGKY;
            // 
            // cbSodk
            // 
            this.cbSodk.DataSource = this.tblDangkyBindingSource1;
            this.cbSodk.DisplayMember = "iSodk";
            this.cbSodk.Enabled = false;
            this.cbSodk.FormattingEnabled = true;
            this.cbSodk.Location = new System.Drawing.Point(104, 94);
            this.cbSodk.Name = "cbSodk";
            this.cbSodk.Size = new System.Drawing.Size(139, 21);
            this.cbSodk.TabIndex = 77;
            this.cbSodk.ValueMember = "iSodk";
            // 
            // btBoqua
            // 
            this.btBoqua.Location = new System.Drawing.Point(593, 187);
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(75, 44);
            this.btBoqua.TabIndex = 78;
            this.btBoqua.Text = "Bỏ qua";
            this.btBoqua.UseVisualStyleBackColor = true;
            this.btBoqua.Click += new System.EventHandler(this.btBoqua_Click);
            // 
            // btTimkiem
            // 
            this.btTimkiem.Location = new System.Drawing.Point(472, 187);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(75, 44);
            this.btTimkiem.TabIndex = 79;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // FormDatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 461);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.btBoqua);
            this.Controls.Add(this.cbSodk);
            this.Controls.Add(this.lbSodk);
            this.Controls.Add(this.mtxtNgaytp);
            this.Controls.Add(this.mtxtNgaynp);
            this.Controls.Add(this.mtxtNgaydk);
            this.Controls.Add(this.cbSophong);
            this.Controls.Add(this.txtCmnd);
            this.Controls.Add(this.lbCmnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgDangky);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dNgaytraphong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNhanvien);
            this.Controls.Add(this.lbNhanvien);
            this.Name = "FormDatphong";
            this.Text = "FormDatphong";
            this.Load += new System.EventHandler(this.FormDatphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDangky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangkyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDANGKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHACHSANDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPHONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangkyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgDangky;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label dNgaytraphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNhanvien;
        private System.Windows.Forms.Label lbNhanvien;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.Label lbCmnd;
        private TBLPHONG tBLPHONG;
        private System.Windows.Forms.BindingSource tblPhongBindingSource;
        private TBLPHONGTableAdapters.tblPhongTableAdapter tblPhongTableAdapter;
        private System.Windows.Forms.ComboBox cbSophong;
        private System.Windows.Forms.BindingSource qUANLYKHACHSANDataSetBindingSource;
        private QUANLYKHACHSANDataSet qUANLYKHACHSANDataSet;
        private System.Windows.Forms.BindingSource tblNhanvienBindingSource;
        private QUANLYKHACHSANDataSetTableAdapters.tblNhanvienTableAdapter tblNhanvienTableAdapter;
        private TBLDANGKY tBLDANGKY;
        private System.Windows.Forms.BindingSource tblDangkyBindingSource;
        private TBLDANGKYTableAdapters.tblDangkyTableAdapter tblDangkyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSodkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iManvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vCmndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSophongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaydkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaynpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaytpDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox mtxtNgaydk;
        private System.Windows.Forms.MaskedTextBox mtxtNgaynp;
        private System.Windows.Forms.MaskedTextBox mtxtNgaytp;
        private System.Windows.Forms.Label lbSodk;
        private System.Windows.Forms.BindingSource tblDangkyBindingSource1;
        private System.Windows.Forms.ComboBox cbSodk;
        private System.Windows.Forms.Button btBoqua;
        private System.Windows.Forms.Button btTimkiem;
    }
}