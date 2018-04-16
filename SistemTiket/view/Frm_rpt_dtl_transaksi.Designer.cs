namespace SistemTiket.view
{
    partial class Frm_rpt_dtl_transaksi
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
            this.Crv_dtl_transaksi = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Crv_dtl_transaksi
            // 
            this.Crv_dtl_transaksi.ActiveViewIndex = -1;
            this.Crv_dtl_transaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_dtl_transaksi.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_dtl_transaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_dtl_transaksi.Location = new System.Drawing.Point(0, 0);
            this.Crv_dtl_transaksi.Name = "Crv_dtl_transaksi";
            this.Crv_dtl_transaksi.Size = new System.Drawing.Size(630, 261);
            this.Crv_dtl_transaksi.TabIndex = 0;
            this.Crv_dtl_transaksi.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_rpt_dtl_transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 261);
            this.Controls.Add(this.Crv_dtl_transaksi);
            this.Name = "Frm_rpt_dtl_transaksi";
            this.Text = "Transaction Page";
            this.Load += new System.EventHandler(this.Frm_rpt_dtl_transaksi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_dtl_transaksi;
    }
}