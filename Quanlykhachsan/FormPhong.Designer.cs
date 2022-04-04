
namespace Quanlykhachsan
{
    partial class FormPhong
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
            this.tblPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLPHONG = new Quanlykhachsan.TBLPHONG();
            this.tblPhongTableAdapter = new Quanlykhachsan.TBLPHONGTableAdapters.tblPhongTableAdapter();
            this.quanlykhachsanDataSet1 = new Quanlykhachsan.QUANLYKHACHSANDataSet();
            this.lbSophong = new System.Windows.Forms.Label();
            this.txtSophong = new System.Windows.Forms.TextBox();
            this.lbSucchua = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.lbDongia = new System.Windows.Forms.Label();
            this.lbTrangthai = new System.Windows.Forms.Label();
            this.tABLEPHONG2 = new Quanlykhachsan.TABLEPHONG2();
            this.tblPhongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblPhongTableAdapter1 = new Quanlykhachsan.TABLEPHONG2TableAdapters.tblPhongTableAdapter();
            this.cbTrangthai = new System.Windows.Forms.ComboBox();
            this.cbSucchua = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new Quanlykhachsan.TBLPHONGTableAdapters.TableAdapterManager();
            this.tableAdapterManager1 = new Quanlykhachsan.TABLEPHONG2TableAdapters.TableAdapterManager();
            this.dgPhong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btBoqua = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPHONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLEPHONG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPhongBindingSource
            // 
            this.tblPhongBindingSource.DataMember = "tblPhong";
            this.tblPhongBindingSource.DataSource = this.tBLPHONG;
            // 
            // tBLPHONG
            // 
            this.tBLPHONG.DataSetName = "TBLPHONG";
            this.tBLPHONG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPhongTableAdapter
            // 
            this.tblPhongTableAdapter.ClearBeforeFill = true;
            // 
            // quanlykhachsanDataSet1
            // 
            this.quanlykhachsanDataSet1.DataSetName = "QUANLYKHACHSANDataSet";
            this.quanlykhachsanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbSophong
            // 
            this.lbSophong.AutoSize = true;
            this.lbSophong.Location = new System.Drawing.Point(13, 23);
            this.lbSophong.Name = "lbSophong";
            this.lbSophong.Size = new System.Drawing.Size(53, 13);
            this.lbSophong.TabIndex = 0;
            this.lbSophong.Text = "Số phòng";
            // 
            // txtSophong
            // 
            this.txtSophong.Location = new System.Drawing.Point(78, 23);
            this.txtSophong.Name = "txtSophong";
            this.txtSophong.Size = new System.Drawing.Size(49, 20);
            this.txtSophong.TabIndex = 1;
            // 
            // lbSucchua
            // 
            this.lbSucchua.AutoSize = true;
            this.lbSucchua.Location = new System.Drawing.Point(285, 26);
            this.lbSucchua.Name = "lbSucchua";
            this.lbSucchua.Size = new System.Drawing.Size(53, 13);
            this.lbSucchua.TabIndex = 2;
            this.lbSucchua.Text = "Sức chứa";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(78, 81);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(198, 20);
            this.txtDongia.TabIndex = 5;
            // 
            // lbDongia
            // 
            this.lbDongia.AutoSize = true;
            this.lbDongia.Location = new System.Drawing.Point(13, 81);
            this.lbDongia.Name = "lbDongia";
            this.lbDongia.Size = new System.Drawing.Size(44, 13);
            this.lbDongia.TabIndex = 4;
            this.lbDongia.Text = "Đơn giá";
            // 
            // lbTrangthai
            // 
            this.lbTrangthai.AutoSize = true;
            this.lbTrangthai.Location = new System.Drawing.Point(285, 84);
            this.lbTrangthai.Name = "lbTrangthai";
            this.lbTrangthai.Size = new System.Drawing.Size(55, 13);
            this.lbTrangthai.TabIndex = 6;
            this.lbTrangthai.Text = "Trạng thái";
            // 
            // tABLEPHONG2
            // 
            this.tABLEPHONG2.DataSetName = "TABLEPHONG2";
            this.tABLEPHONG2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPhongBindingSource1
            // 
            this.tblPhongBindingSource1.DataMember = "tblPhong";
            this.tblPhongBindingSource1.DataSource = this.tABLEPHONG2;
            // 
            // tblPhongTableAdapter1
            // 
            this.tblPhongTableAdapter1.ClearBeforeFill = true;
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangthai.FormattingEnabled = true;
            this.cbTrangthai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbTrangthai.Location = new System.Drawing.Point(358, 76);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(121, 21);
            this.cbTrangthai.TabIndex = 7;
            this.cbTrangthai.SelectedIndexChanged += new System.EventHandler(this.cbTrangthai_SelectedIndexChanged);
            // 
            // cbSucchua
            // 
            this.cbSucchua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucchua.FormattingEnabled = true;
            this.cbSucchua.Items.AddRange(new object[] {
            "Phòng đơn",
            "Phòng đôi"});
            this.cbSucchua.Location = new System.Drawing.Point(358, 26);
            this.cbSucchua.Name = "cbSucchua";
            this.cbSucchua.Size = new System.Drawing.Size(121, 21);
            this.cbSucchua.TabIndex = 8;
            this.cbSucchua.SelectedIndexChanged += new System.EventHandler(this.cbSucchua_SelectedIndexChanged);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblPhongTableAdapter = this.tblPhongTableAdapter;
            this.tableAdapterManager.UpdateOrder = Quanlykhachsan.TBLPHONGTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblPhongTableAdapter = this.tblPhongTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Quanlykhachsan.TABLEPHONG2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgPhong
            // 
            this.dgPhong.AllowUserToAddRows = false;
            this.dgPhong.AutoGenerateColumns = false;
            this.dgPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.dgPhong.DataSource = this.tblPhongBindingSource1;
            this.dgPhong.Location = new System.Drawing.Point(16, 230);
            this.dgPhong.Name = "dgPhong";
            this.dgPhong.Size = new System.Drawing.Size(474, 220);
            this.dgPhong.TabIndex = 8;
            this.dgPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhong_CellContentClick);
            this.dgPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhong_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "iSophong";
            this.dataGridViewTextBoxColumn1.HeaderText = "iSophong";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "vSucchua";
            this.dataGridViewTextBoxColumn2.HeaderText = "vSucchua";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fDongia";
            this.dataGridViewTextBoxColumn3.HeaderText = "fDongia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "bTrangthai";
            this.dataGridViewCheckBoxColumn1.HeaderText = "bTrangthai";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(16, 149);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 43);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(108, 149);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 43);
            this.btSua.TabIndex = 10;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(201, 149);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 43);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btBoqua
            // 
            this.btBoqua.Location = new System.Drawing.Point(404, 149);
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(75, 43);
            this.btBoqua.TabIndex = 12;
            this.btBoqua.Text = "Bỏ qua";
            this.btBoqua.UseVisualStyleBackColor = true;
            this.btBoqua.Click += new System.EventHandler(this.btBoqua_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(323, 149);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 43);
            this.btTim.TabIndex = 13;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 495);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.btBoqua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgPhong);
            this.Controls.Add(this.cbSucchua);
            this.Controls.Add(this.cbTrangthai);
            this.Controls.Add(this.lbTrangthai);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.lbDongia);
            this.Controls.Add(this.lbSucchua);
            this.Controls.Add(this.txtSophong);
            this.Controls.Add(this.lbSophong);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPHONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlykhachsanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLEPHONG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TBLPHONG tBLPHONG;
        private System.Windows.Forms.BindingSource tblPhongBindingSource;
        private TBLPHONGTableAdapters.tblPhongTableAdapter tblPhongTableAdapter;
        private QUANLYKHACHSANDataSet quanlykhachsanDataSet1;
        private System.Windows.Forms.Label lbSophong;
        private System.Windows.Forms.TextBox txtSophong;
        private System.Windows.Forms.Label lbSucchua;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label lbDongia;
        private System.Windows.Forms.Label lbTrangthai;
        private TABLEPHONG2 tABLEPHONG2;
        private System.Windows.Forms.BindingSource tblPhongBindingSource1;
        private TABLEPHONG2TableAdapters.tblPhongTableAdapter tblPhongTableAdapter1;
        private System.Windows.Forms.ComboBox cbTrangthai;
        private System.Windows.Forms.ComboBox cbSucchua;
        private TBLPHONGTableAdapters.TableAdapterManager tableAdapterManager;
        private TABLEPHONG2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dgPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btBoqua;
        private System.Windows.Forms.Button btTim;
    }
}