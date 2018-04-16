using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemTiket.dao;
using SistemTiket.report;

namespace SistemTiket.view
{
    public partial class Frm_rpt_games : Form
    {
        public Frm_rpt_games()
        {
            InitializeComponent();
        }

        private void Frm_rpt_games_Load(object sender, EventArgs e)
        {
            DataSet data = new GamesDao().ShowGames();
            DataTable dt = new DataTable();
            dt = data.Tables[0];

            Cr_games obj_rpt = new Cr_games();
            obj_rpt.SetDataSource(dt);
            Crv_games.ReportSource = obj_rpt;
            Crv_games.Refresh();
        }
    }
}
