
namespace Quanlykhachsan
{
    partial class FormBaocaokhachhang
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crvKhachhang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Baocaokhachhang1 = new Quanlykhachsan.Baocaokhachhang();
            this.Baocaokhachhang2 = new Quanlykhachsan.Baocaokhachhang();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1075, 555);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(1075, 555);
            this.crystalReportViewer2.TabIndex = 1;
            // 
            // crvKhachhang
            // 
            this.crvKhachhang.ActiveViewIndex = 0;
            this.crvKhachhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvKhachhang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvKhachhang.Location = new System.Drawing.Point(0, 0);
            this.crvKhachhang.Name = "crvKhachhang";
            this.crvKhachhang.ReportSource = this.Baocaokhachhang2;
            this.crvKhachhang.Size = new System.Drawing.Size(1075, 555);
            this.crvKhachhang.TabIndex = 2;
            this.crvKhachhang.Load += new System.EventHandler(this.crystalReportViewer3_Load);
            // 
            // FormBaocaokhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 555);
            this.Controls.Add(this.crvKhachhang);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormBaocaokhachhang";
            this.Text = "FormBaocaokhachhang";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvKhachhang;
        private Baocaokhachhang Baocaokhachhang1;
        private Baocaokhachhang Baocaokhachhang2;
    }
}