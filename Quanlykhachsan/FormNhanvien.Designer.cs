
namespace Quanlykhachsan
{
    partial class FormNhanvien
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
            this.btBoqua = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbHoten = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.qUANLYKHACHSANDataSet = new Quanlykhachsan.QUANLYKHACHSANDataSet();
            this.tblNhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhanvienTableAdapter = new Quanlykhachsan.QUANLYKHACHSANDataSetTableAdapters.tblNhanvienTableAdapter();
            this.tableAdapterManager = new Quanlykhachsan.QUANLYKHACHSANDataSetTableAdapters.TableAdapterManager();
            this.dgNhanvien = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.lbManv = new System.Windows.Forms.Label();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.btBaocao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btBoqua
            // 
            this.btBoqua.Location = new System.Drawing.Point(561, 165);
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(75, 39);
            this.btBoqua.TabIndex = 46;
            this.btBoqua.Text = "Bỏ qua";
            this.btBoqua.UseVisualStyleBackColor = true;
            this.btBoqua.Click += new System.EventHandler(this.btBoqua_Click);
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(452, 165);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 39);
            this.btTim.TabIndex = 45;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(235, 165);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 39);
            this.btXoa.TabIndex = 44;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(126, 165);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 39);
            this.btSua.TabIndex = 43;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(24, 165);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 39);
            this.btThem.TabIndex = 42;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(101, 75);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(181, 20);
            this.txtHoten.TabIndex = 38;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(390, 79);
            this.txtSdt.Multiline = true;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(246, 18);
            this.txtSdt.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Số điện thoại";
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Location = new System.Drawing.Point(21, 78);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(39, 13);
            this.lbHoten.TabIndex = 34;
            this.lbHoten.Text = "Họ tên";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(101, 128);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(536, 20);
            this.txtDiachi.TabIndex = 48;
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Location = new System.Drawing.Point(21, 131);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(40, 13);
            this.lbDiachi.TabIndex = 47;
            this.lbDiachi.Text = "Địa chỉ";
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
            // dgNhanvien
            // 
            this.dgNhanvien.AllowUserToAddRows = false;
            this.dgNhanvien.AutoGenerateColumns = false;
            this.dgNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgNhanvien.DataSource = this.tblNhanvienBindingSource;
            this.dgNhanvien.Location = new System.Drawing.Point(24, 239);
            this.dgNhanvien.Name = "dgNhanvien";
            this.dgNhanvien.Size = new System.Drawing.Size(612, 179);
            this.dgNhanvien.TabIndex = 48;
            this.dgNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNhanvien_CellContentClick);
            this.dgNhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNhanvien_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "iManv";
            this.dataGridViewTextBoxColumn1.HeaderText = "iManv";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "vHoten";
            this.dataGridViewTextBoxColumn2.HeaderText = "vHoten";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dNgaysinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "dNgaysinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "vSodienthoai";
            this.dataGridViewTextBoxColumn4.HeaderText = "vSodienthoai";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "vDiachi";
            this.dataGridViewTextBoxColumn5.HeaderText = "vDiachi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ngày sinh";
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Location = new System.Drawing.Point(390, 32);
            this.txtNgaysinh.Mask = "0000/00/00";
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(108, 20);
            this.txtNgaysinh.TabIndex = 49;
            this.txtNgaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // lbManv
            // 
            this.lbManv.AutoSize = true;
            this.lbManv.Enabled = false;
            this.lbManv.Location = new System.Drawing.Point(21, 34);
            this.lbManv.Name = "lbManv";
            this.lbManv.Size = new System.Drawing.Size(72, 13);
            this.lbManv.TabIndex = 51;
            this.lbManv.Text = "Mã nhân viên";
            // 
            // cbManv
            // 
            this.cbManv.DataSource = this.tblNhanvienBindingSource;
            this.cbManv.DisplayMember = "iManv";
            this.cbManv.Enabled = false;
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(101, 31);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(180, 21);
            this.cbManv.TabIndex = 52;
            this.cbManv.ValueMember = "iManv";
            // 
            // btBaocao
            // 
            this.btBaocao.Location = new System.Drawing.Point(352, 165);
            this.btBaocao.Name = "btBaocao";
            this.btBaocao.Size = new System.Drawing.Size(75, 39);
            this.btBaocao.TabIndex = 53;
            this.btBaocao.Text = "Báo cáo";
            this.btBaocao.UseVisualStyleBackColor = true;
            this.btBaocao.Click += new System.EventHandler(this.btBaocao_Click);
            // 
            // FormNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 462);
            this.Controls.Add(this.btBaocao);
            this.Controls.Add(this.cbManv);
            this.Controls.Add(this.lbManv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgaysinh);
            this.Controls.Add(this.dgNhanvien);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.lbDiachi);
            this.Controls.Add(this.btBoqua);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbHoten);
            this.Name = "FormNhanvien";
            this.Text = "FormNhanvien";
            this.Load += new System.EventHandler(this.FormNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBoqua;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label lbDiachi;
        private QUANLYKHACHSANDataSet qUANLYKHACHSANDataSet;
        private System.Windows.Forms.BindingSource tblNhanvienBindingSource;
        private QUANLYKHACHSANDataSetTableAdapters.tblNhanvienTableAdapter tblNhanvienTableAdapter;
        private QUANLYKHACHSANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtNgaysinh;
        private System.Windows.Forms.Label lbManv;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.Button btBaocao;
    }
}