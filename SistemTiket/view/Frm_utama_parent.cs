using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemTiket.view
{
    public partial class Frm_utama_parent : Form
    {
        private string p;
        private TextBox txt_id_pegawai;

        public Frm_utama_parent()
        {
            InitializeComponent();
        }

        public Frm_utama_parent(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        public Frm_utama_parent(TextBox txt_id_pegawai)
        {
            // TODO: Complete member initialization
            this.txt_id_pegawai = txt_id_pegawai;
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e){
            Frm_pembuat pembuat = new Frm_pembuat();
            pembuat.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void Frm_utama_parent_Load(object sender, EventArgs e){
            toolStripStatusLabel1.Text = "Ready";
            Frm_utama_child frm_utama_chd = new Frm_utama_child();
            frm_utama_chd.WindowState = FormWindowState.Maximized;

            frm_utama_chd.ControlBox = false;
            frm_utama_chd.MdiParent = this;
            frm_utama_chd.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e){
            toolStripStatusLabel1.Text = "Employees Data";
            Frm_pegawai frm_peg = new Frm_pegawai();
            frm_peg.WindowState = FormWindowState.Maximized;
            frm_peg.ControlBox = false;
            frm_peg.MdiParent = this;
            frm_peg.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e){
            toolStripStatusLabel1.Text = "Games Data";
            Frm_games frm_gms = new Frm_games();
            frm_gms.WindowState = FormWindowState.Maximized;
            frm_gms.ControlBox = false;
            frm_gms.MdiParent = this;
            frm_gms.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e){
            toolStripStatusLabel1.Text = "Transaction Data";
            Frm_dtl_transaksi frm_transaksi = new Frm_dtl_transaksi();
            frm_transaksi.WindowState = FormWindowState.Maximized;
            frm_transaksi.ControlBox = false;
            frm_transaksi.MdiParent = this;
            frm_transaksi.Show();
        }


       private void employeesDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Employee Report";
            Frm_rpt_pegawai frm_rpt = new Frm_rpt_pegawai();
            frm_rpt.WindowState = FormWindowState.Maximized;
            frm_rpt.ControlBox = false;
            frm_rpt.MdiParent = this;
            frm_rpt.Show();
        }

       

        private void gamesDataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Games Report";
            Frm_rpt_games frm_rpt_gms = new Frm_rpt_games();
            frm_rpt_gms.WindowState = FormWindowState.Maximized;
            frm_rpt_gms.ControlBox = false;
            frm_rpt_gms.MdiParent = this;
            frm_rpt_gms.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e){
            toolStripStatusLabel1.Text = "Transaction Report";
            Frm_rpt_dtl_transaksi frm_rpt_dtl_trns = new Frm_rpt_dtl_transaksi();
            frm_rpt_dtl_trns.WindowState = FormWindowState.Maximized;
            frm_rpt_dtl_trns.ControlBox = false;
            frm_rpt_dtl_trns.MdiParent = this;
            frm_rpt_dtl_trns.Show();
        } 
    }
}
