
namespace Quanlykhachsan
{
    partial class FormHoadon
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
            this.lbSodangky = new System.Windows.Forms.Label();
            this.lbMadv = new System.Windows.Forms.Label();
            this.lbNgaysd = new System.Windows.Forms.Label();
            this.cbSodk = new System.Windows.Forms.ComboBox();
            this.tblDangkyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLDANGKY = new Quanlykhachsan.TBLDANGKY();
            this.tblDangkyTableAdapter = new Quanlykhachsan.TBLDANGKYTableAdapters.tblDangkyTableAdapter();
            this.cbMadv = new System.Windows.Forms.ComboBox();
            this.tblDichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLDICHVU = new Quanlykhachsan.TBLDICHVU();
            this.tblDichvuTableAdapter = new Quanlykhachsan.TBLDICHVUTableAdapters.tblDichvuTableAdapter();
            this.dgHoadon = new System.Windows.Forms.DataGridView();
            this.tblHoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLHOADON = new Quanlykhachsan.TBLHOADON();
            this.tblHoadonTableAdapter = new Quanlykhachsan.TBLHOADONTableAdapters.tblHoadonTableAdapter();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btBoqua = new System.Windows.Forms.Button();
            this.mtxtNgaysd1 = new System.Windows.Forms.MaskedTextBox();
            this.lbSohd = new System.Windows.Forms.Label();
            this.txtSohd = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.tBLHOADONCOTRANGTHAI = new Quanlykhachsan.TBLHOADONCOTRANGTHAI();
            this.tBLHOADONCOTRANGTHAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHoadonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblHoadonTableAdapter1 = new Quanlykhachsan.TBLHOADONCOTRANGTHAITableAdapters.tblHoadonTableAdapter();
            this.iSohdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSodkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMadvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaysdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTrangthaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblDangkyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDANGKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDICHVU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHOADON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHOADONCOTRANGTHAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHOADONCOTRANGTHAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoadonBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSodangky
            // 
            this.lbSodangky.AutoSize = true;
            this.lbSodangky.Location = new System.Drawing.Point(21, 63);
            this.lbSodangky.Name = "lbSodangky";
            this.lbSodangky.Size = new System.Drawing.Size(62, 13);
            this.lbSodangky.TabIndex = 0;
            this.lbSodangky.Text = "Số đăng ký";
            // 
            // lbMadv
            // 
            this.lbMadv.AutoSize = true;
            this.lbMadv.Location = new System.Drawing.Point(21, 110);
            this.lbMadv.Name = "lbMadv";
            this.lbMadv.Size = new System.Drawing.Size(60, 13);
            this.lbMadv.TabIndex = 1;
            this.lbMadv.Text = "Mã dịch vụ";
            // 
            // lbNgaysd
            // 
            this.lbNgaysd.AutoSize = true;
            this.lbNgaysd.Location = new System.Drawing.Point(21, 155);
            this.lbNgaysd.Name = "lbNgaysd";
            this.lbNgaysd.Size = new System.Drawing.Size(73, 13);
            this.lbNgaysd.TabIndex = 2;
            this.lbNgaysd.Text = "Ngày sử dụng";
            // 
            // cbSodk
            // 
            this.cbSodk.DataSource = this.tblDangkyBindingSource;
            this.cbSodk.DisplayMember = "iSodk";
            this.cbSodk.FormattingEnabled = true;
            this.cbSodk.Location = new System.Drawing.Point(124, 60);
            this.cbSodk.Name = "cbSodk";
            this.cbSodk.Size = new System.Drawing.Size(121, 21);
            this.cbSodk.TabIndex = 3;
            this.cbSodk.ValueMember = "iSodk";
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
            // tblDangkyTableAdapter
            // 
            this.tblDangkyTableAdapter.ClearBeforeFill = true;
            // 
            // cbMadv
            // 
            this.cbMadv.DataSource = this.tblDichvuBindingSource;
            this.cbMadv.DisplayMember = "iMadv";
            this.cbMadv.FormattingEnabled = true;
            this.cbMadv.Location = new System.Drawing.Point(124, 107);
            this.cbMadv.Name = "cbMadv";
            this.cbMadv.Size = new System.Drawing.Size(121, 21);
            this.cbMadv.TabIndex = 4;
            this.cbMadv.ValueMember = "iMadv";
            // 
            // tblDichvuBindingSource
            // 
            this.tblDichvuBindingSource.DataMember = "tblDichvu";
            this.tblDichvuBindingSource.DataSource = this.tBLDICHVU;
            // 
            // tBLDICHVU
            // 
            this.tBLDICHVU.DataSetName = "TBLDICHVU";
            this.tBLDICHVU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDichvuTableAdapter
            // 
            this.tblDichvuTableAdapter.ClearBeforeFill = true;
            // 
            // dgHoadon
            // 
            this.dgHoadon.AllowUserToAddRows = false;
            this.dgHoadon.AllowUserToDeleteRows = false;
            this.dgHoadon.AutoGenerateColumns = false;
            this.dgHoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSohdDataGridViewTextBoxColumn,
            this.iSodkDataGridViewTextBoxColumn,
            this.iMadvDataGridViewTextBoxColumn,
            this.dNgaysdDataGridViewTextBoxColumn,
            this.bTrangthaiDataGridViewCheckBoxColumn});
            this.dgHoadon.DataSource = this.tblHoadonBindingSource1;
            this.dgHoadon.Location = new System.Drawing.Point(21, 267);
            this.dgHoadon.Name = "dgHoadon";
            this.dgHoadon.Size = new System.Drawing.Size(465, 150);
            this.dgHoadon.TabIndex = 6;
            this.dgHoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHoadon_CellContentClick);
            this.dgHoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHoadon_CellContentClick_1);
            // 
            // tblHoadonBindingSource
            // 
            this.tblHoadonBindingSource.DataMember = "tblHoadon";
            this.tblHoadonBindingSource.DataSource = this.tBLHOADON;
            // 
            // tBLHOADON
            // 
            this.tBLHOADON.DataSetName = "TBLHOADON";
            this.tBLHOADON.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHoadonTableAdapter
            // 
            this.tblHoadonTableAdapter.ClearBeforeFill = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(24, 198);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 40);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(124, 198);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 40);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(222, 198);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 40);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btBoqua
            // 
            this.btBoqua.Location = new System.Drawing.Point(411, 198);
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(75, 40);
            this.btBoqua.TabIndex = 10;
            this.btBoqua.Text = "Bỏ qua";
            this.btBoqua.UseVisualStyleBackColor = true;
            this.btBoqua.Click += new System.EventHandler(this.btBoqua_Click);
            // 
            // mtxtNgaysd1
            // 
            this.mtxtNgaysd1.Location = new System.Drawing.Point(124, 152);
            this.mtxtNgaysd1.Mask = "0000/00/00";
            this.mtxtNgaysd1.Name = "mtxtNgaysd1";
            this.mtxtNgaysd1.Size = new System.Drawing.Size(75, 20);
            this.mtxtNgaysd1.TabIndex = 11;
            this.mtxtNgaysd1.ValidatingType = typeof(System.DateTime);
            // 
            // lbSohd
            // 
            this.lbSohd.AutoSize = true;
            this.lbSohd.Enabled = false;
            this.lbSohd.Location = new System.Drawing.Point(21, 19);
            this.lbSohd.Name = "lbSohd";
            this.lbSohd.Size = new System.Drawing.Size(63, 13);
            this.lbSohd.TabIndex = 12;
            this.lbSohd.Text = "Số hóa đơn";
            // 
            // txtSohd
            // 
            this.txtSohd.Enabled = false;
            this.txtSohd.Location = new System.Drawing.Point(124, 12);
            this.txtSohd.Name = "txtSohd";
            this.txtSohd.Size = new System.Drawing.Size(100, 20);
            this.txtSohd.TabIndex = 13;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(315, 198);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 40);
            this.btTim.TabIndex = 14;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // tBLHOADONCOTRANGTHAI
            // 
            this.tBLHOADONCOTRANGTHAI.DataSetName = "TBLHOADONCOTRANGTHAI";
            this.tBLHOADONCOTRANGTHAI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLHOADONCOTRANGTHAIBindingSource
            // 
            this.tBLHOADONCOTRANGTHAIBindingSource.DataSource = this.tBLHOADONCOTRANGTHAI;
            this.tBLHOADONCOTRANGTHAIBindingSource.Position = 0;
            // 
            // tblHoadonBindingSource1
            // 
            this.tblHoadonBindingSource1.DataMember = "tblHoadon";
            this.tblHoadonBindingSource1.DataSource = this.tBLHOADONCOTRANGTHAIBindingSource;
            // 
            // tblHoadonTableAdapter1
            // 
            this.tblHoadonTableAdapter1.ClearBeforeFill = true;
            // 
            // iSohdDataGridViewTextBoxColumn
            // 
            this.iSohdDataGridViewTextBoxColumn.DataPropertyName = "iSohd";
            this.iSohdDataGridViewTextBoxColumn.HeaderText = "iSohd";
            this.iSohdDataGridViewTextBoxColumn.Name = "iSohdDataGridViewTextBoxColumn";
            this.iSohdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSodkDataGridViewTextBoxColumn
            // 
            this.iSodkDataGridViewTextBoxColumn.DataPropertyName = "iSodk";
            this.iSodkDataGridViewTextBoxColumn.HeaderText = "iSodk";
            this.iSodkDataGridViewTextBoxColumn.Name = "iSodkDataGridViewTextBoxColumn";
            // 
            // iMadvDataGridViewTextBoxColumn
            // 
            this.iMadvDataGridViewTextBoxColumn.DataPropertyName = "iMadv";
            this.iMadvDataGridViewTextBoxColumn.HeaderText = "iMadv";
            this.iMadvDataGridViewTextBoxColumn.Name = "iMadvDataGridViewTextBoxColumn";
            // 
            // dNgaysdDataGridViewTextBoxColumn
            // 
            this.dNgaysdDataGridViewTextBoxColumn.DataPropertyName = "dNgaysd";
            this.dNgaysdDataGridViewTextBoxColumn.HeaderText = "dNgaysd";
            this.dNgaysdDataGridViewTextBoxColumn.Name = "dNgaysdDataGridViewTextBoxColumn";
            // 
            // bTrangthaiDataGridViewCheckBoxColumn
            // 
            this.bTrangthaiDataGridViewCheckBoxColumn.DataPropertyName = "bTrangthai";
            this.bTrangthaiDataGridViewCheckBoxColumn.HeaderText = "bTrangthai";
            this.bTrangthaiDataGridViewCheckBoxColumn.Name = "bTrangthaiDataGridViewCheckBoxColumn";
            // 
            // FormHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 442);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.txtSohd);
            this.Controls.Add(this.lbSohd);
            this.Controls.Add(this.mtxtNgaysd1);
            this.Controls.Add(this.btBoqua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgHoadon);
            this.Controls.Add(this.cbMadv);
            this.Controls.Add(this.cbSodk);
            this.Controls.Add(this.lbNgaysd);
            this.Controls.Add(this.lbMadv);
            this.Controls.Add(this.lbSodangky);
            this.Name = "FormHoadon";
            this.Text = "FormHoadon";
            this.Load += new System.EventHandler(this.FormHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDangkyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDANGKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDICHVU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHOADON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHOADONCOTRANGTHAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHOADONCOTRANGTHAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoadonBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSodangky;
        private System.Windows.Forms.Label lbMadv;
        private System.Windows.Forms.Label lbNgaysd;
        private System.Windows.Forms.ComboBox cbSodk;
        private TBLDANGKY tBLDANGKY;
        private System.Windows.Forms.BindingSource tblDangkyBindingSource;
        private TBLDANGKYTableAdapters.tblDangkyTableAdapter tblDangkyTableAdapter;
        private System.Windows.Forms.ComboBox cbMadv;
        private TBLDICHVU tBLDICHVU;
        private System.Windows.Forms.BindingSource tblDichvuBindingSource;
        private TBLDICHVUTableAdapters.tblDichvuTableAdapter tblDichvuTableAdapter;
        private System.Windows.Forms.DataGridView dgHoadon;
        private TBLHOADON tBLHOADON;
        private System.Windows.Forms.BindingSource tblHoadonBindingSource;
        private TBLHOADONTableAdapters.tblHoadonTableAdapter tblHoadonTableAdapter;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btBoqua;
        private System.Windows.Forms.Label lbSohd;
        private System.Windows.Forms.TextBox txtSohd;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.DateTimePicker mtxtNgaysd;
        private System.Windows.Forms.MaskedTextBox mtxtNgaysd1;
        private System.Windows.Forms.BindingSource tBLHOADONCOTRANGTHAIBindingSource;
        private TBLHOADONCOTRANGTHAI tBLHOADONCOTRANGTHAI;
        private System.Windows.Forms.BindingSource tblHoadonBindingSource1;
        private TBLHOADONCOTRANGTHAITableAdapters.tblHoadonTableAdapter tblHoadonTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSohdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSodkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMadvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaysdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bTrangthaiDataGridViewCheckBoxColumn;
    }
}