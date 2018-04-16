namespace SistemTiket.view
{
    partial class Frm_rpt_ticket
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
            this.Crv_ticket = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Crv_ticket
            // 
            this.Crv_ticket.ActiveViewIndex = -1;
            this.Crv_ticket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_ticket.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_ticket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_ticket.Location = new System.Drawing.Point(0, 0);
            this.Crv_ticket.Name = "Crv_ticket";
            this.Crv_ticket.Size = new System.Drawing.Size(713, 340);
            this.Crv_ticket.TabIndex = 0;
            this.Crv_ticket.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_rpt_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 340);
            this.Controls.Add(this.Crv_ticket);
            this.Name = "Frm_rpt_ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Frm_rpt_ticket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_ticket;
    }
}