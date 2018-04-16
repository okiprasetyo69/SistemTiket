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
    public partial class Frm_rpt_ticket : Form
    {
        public Frm_rpt_ticket()
        {
            InitializeComponent();
        }

        private void Frm_rpt_ticket_Load(object sender, EventArgs e)
        {
            DataSet data = new DtlTransasksiDao().ShowTransaction();
            DataTable dt = new DataTable();
            dt = data.Tables[0];

            Cr_ticket obj_rpt = new Cr_ticket();
            obj_rpt.SetDataSource(dt);
            Crv_ticket.ReportSource = obj_rpt;
            Crv_ticket.Refresh();
        }
    }
}
