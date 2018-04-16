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
    public partial class Frm_rpt_dtl_transaksi : Form
    {
        public Frm_rpt_dtl_transaksi()
        {
            InitializeComponent();
        }

        private void Frm_rpt_dtl_transaksi_Load(object sender, EventArgs e)
        {
            DataSet data = new DtlTransasksiDao().ShowTransaction();
            DataTable dt = new DataTable();
            dt = data.Tables[0];

            Cr_dtl_transaksi obj_rpt = new Cr_dtl_transaksi();
            obj_rpt.SetDataSource(dt);
            Crv_dtl_transaksi.ReportSource = obj_rpt;
            Crv_dtl_transaksi.Refresh();
        }
    }
}
