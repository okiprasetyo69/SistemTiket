namespace SistemTiket.view
{
    partial class Frm_rpt_pegawai
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
            this.Crv_pegawai = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Crv_pegawai
            // 
            this.Crv_pegawai.ActiveViewIndex = -1;
            this.Crv_pegawai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_pegawai.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_pegawai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_pegawai.Location = new System.Drawing.Point(0, 0);
            this.Crv_pegawai.Name = "Crv_pegawai";
            this.Crv_pegawai.Size = new System.Drawing.Size(429, 261);
            this.Crv_pegawai.TabIndex = 0;
            this.Crv_pegawai.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_rpt_pegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 261);
            this.Controls.Add(this.Crv_pegawai);
            this.Name = "Frm_rpt_pegawai";
            this.Text = "Employee Report Page";
            this.Load += new System.EventHandler(this.Frm_rpt_pegawai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_pegawai;
    }
}