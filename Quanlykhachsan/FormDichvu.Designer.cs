
namespace Quanlykhachsan
{
    partial class FormDichvu
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
            this.txtTendv = new System.Windows.Forms.TextBox();
            this.lbTendv = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.dgDichvu = new System.Windows.Forms.DataGridView();
            this.iMadvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTendvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGiadvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLDICHVU = new Quanlykhachsan.TBLDICHVU();
            this.tblDichvuTableAdapter = new Quanlykhachsan.TBLDICHVUTableAdapters.tblDichvuTableAdapter();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.lbMadv = new System.Windows.Forms.Label();
            this.cbMadv = new System.Windows.Forms.ComboBox();
            this.btBoqua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDICHVU)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTendv
            // 
            this.txtTendv.Location = new System.Drawing.Point(101, 75);
            this.txtTendv.Name = "txtTendv";
            this.txtTendv.Size = new System.Drawing.Size(427, 20);
            this.txtTendv.TabIndex = 3;
            // 
            // lbTendv
            // 
            this.lbTendv.AutoSize = true;
            this.lbTendv.Location = new System.Drawing.Point(25, 78);
            this.lbTendv.Name = "lbTendv";
            this.lbTendv.Size = new System.Drawing.Size(64, 13);
            this.lbTendv.TabIndex = 2;
            this.lbTendv.Text = "Tên dịch vụ";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(101, 123);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(427, 20);
            this.txtDongia.TabIndex = 5;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(25, 126);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(44, 13);
            this.lbGia.TabIndex = 4;
            this.lbGia.Text = "Đơn giá";
            // 
            // dgDichvu
            // 
            this.dgDichvu.AllowUserToAddRows = false;
            this.dgDichvu.AutoGenerateColumns = false;
            this.dgDichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iMadvDataGridViewTextBoxColumn,
            this.vTendvDataGridViewTextBoxColumn,
            this.fGiadvDataGridViewTextBoxColumn});
            this.dgDichvu.DataSource = this.tblDichvuBindingSource;
            this.dgDichvu.Location = new System.Drawing.Point(28, 263);
            this.dgDichvu.Name = "dgDichvu";
            this.dgDichvu.Size = new System.Drawing.Size(500, 150);
            this.dgDichvu.TabIndex = 6;
            this.dgDichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDichvu_CellContentClick);
            // 
            // iMadvDataGridViewTextBoxColumn
            // 
            this.iMadvDataGridViewTextBoxColumn.DataPropertyName = "iMadv";
            this.iMadvDataGridViewTextBoxColumn.HeaderText = "iMadv";
            this.iMadvDataGridViewTextBoxColumn.Name = "iMadvDataGridViewTextBoxColumn";
            this.iMadvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vTendvDataGridViewTextBoxColumn
            // 
            this.vTendvDataGridViewTextBoxColumn.DataPropertyName = "vTendv";
            this.vTendvDataGridViewTextBoxColumn.HeaderText = "vTendv";
            this.vTendvDataGridViewTextBoxColumn.Name = "vTendvDataGridViewTextBoxColumn";
            // 
            // fGiadvDataGridViewTextBoxColumn
            // 
            this.fGiadvDataGridViewTextBoxColumn.DataPropertyName = "fGiadv";
            this.fGiadvDataGridViewTextBoxColumn.HeaderText = "fGiadv";
            this.fGiadvDataGridViewTextBoxColumn.Name = "fGiadvDataGridViewTextBoxColumn";
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
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(28, 183);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 47);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(109, 183);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 47);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(190, 183);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 47);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(352, 183);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(85, 47);
            this.btTim.TabIndex = 10;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // lbMadv
            // 
            this.lbMadv.AutoSize = true;
            this.lbMadv.Enabled = false;
            this.lbMadv.Location = new System.Drawing.Point(25, 33);
            this.lbMadv.Name = "lbMadv";
            this.lbMadv.Size = new System.Drawing.Size(60, 13);
            this.lbMadv.TabIndex = 0;
            this.lbMadv.Text = "Mã dịch vụ";
            // 
            // cbMadv
            // 
            this.cbMadv.DataSource = this.tblDichvuBindingSource;
            this.cbMadv.DisplayMember = "iMadv";
            this.cbMadv.Enabled = false;
            this.cbMadv.FormattingEnabled = true;
            this.cbMadv.Location = new System.Drawing.Point(101, 25);
            this.cbMadv.Name = "cbMadv";
            this.cbMadv.Size = new System.Drawing.Size(121, 21);
            this.cbMadv.TabIndex = 11;
            this.cbMadv.ValueMember = "iMadv";
            // 
            // btBoqua
            // 
            this.btBoqua.Location = new System.Drawing.Point(443, 183);
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(85, 47);
            this.btBoqua.TabIndex = 12;
            this.btBoqua.Text = "Bỏ qua";
            this.btBoqua.UseVisualStyleBackColor = true;
            this.btBoqua.Click += new System.EventHandler(this.btBoqua_Click);
            // 
            // FormDichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 467);
            this.Controls.Add(this.btBoqua);
            this.Controls.Add(this.cbMadv);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgDichvu);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.txtTendv);
            this.Controls.Add(this.lbTendv);
            this.Controls.Add(this.lbMadv);
            this.Name = "FormDichvu";
            this.Text = "FormDichvu";
            this.Load += new System.EventHandler(this.FormDichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDichvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDICHVU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTendv;
        private System.Windows.Forms.Label lbTendv;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.DataGridView dgDichvu;
        private TBLDICHVU tBLDICHVU;
        private System.Windows.Forms.BindingSource tblDichvuBindingSource;
        private TBLDICHVUTableAdapters.tblDichvuTableAdapter tblDichvuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMadvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vTendvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGiadvDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Label lbMadv;
        private System.Windows.Forms.ComboBox cbMadv;
        private System.Windows.Forms.Button btBoqua;
    }
}