namespace SistemTiket.view
{
    partial class Frm_rpt_games
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Crv_games = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Crv_games
            // 
            this.Crv_games.ActiveViewIndex = -1;
            this.Crv_games.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_games.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_games.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_games.Location = new System.Drawing.Point(0, 0);
            this.Crv_games.Name = "Crv_games";
            this.Crv_games.Size = new System.Drawing.Size(439, 261);
            this.Crv_games.TabIndex = 0;
            this.Crv_games.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_rpt_games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 261);
            this.Controls.Add(this.Crv_games);
            this.Name = "Frm_rpt_games";
            this.Text = "Games Page Report";
            this.Load += new System.EventHandler(this.Frm_rpt_games_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_games;
    }
}