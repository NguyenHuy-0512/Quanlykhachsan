
namespace Quanlykhachsan
{
    partial class FormBaocaohoadon
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
            this.crvHoadon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvHoadon
            // 
            this.crvHoadon.ActiveViewIndex = -1;
            this.crvHoadon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHoadon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvHoadon.Location = new System.Drawing.Point(0, 0);
            this.crvHoadon.Name = "crvHoadon";
            this.crvHoadon.Size = new System.Drawing.Size(800, 450);
            this.crvHoadon.TabIndex = 0;
            this.crvHoadon.Load += new System.EventHandler(this.crvHoadon_Load);
            // 
            // FormBaocaohoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvHoadon);
            this.Name = "FormBaocaohoadon";
            this.Text = "FormBaocaohoadon";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHoadon;
    }
}