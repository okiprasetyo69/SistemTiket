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
    public partial class Frm_rpt_pegawai : Form
    {
        public Frm_rpt_pegawai()
        {
            InitializeComponent();
        }

        private void Frm_rpt_pegawai_Load(object sender, EventArgs e)
        {
            DataSet data = new PegawaiDao().ShowEmployee();
            DataTable dt = new DataTable();
            dt =    data.Tables[0];

            Cr_pegawai obj_rpt = new Cr_pegawai();
            obj_rpt.SetDataSource(dt);
            Crv_pegawai.ReportSource = obj_rpt;
            Crv_pegawai.Refresh();
        }
    }
}
