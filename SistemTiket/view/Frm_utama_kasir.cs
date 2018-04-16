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
    public partial class Frm_utama_kasir : Form
    {
        
        string id_pegawai;
        
        public Frm_utama_kasir(string id_pegawai)
        {
            this.id_pegawai = id_pegawai;
            //this.id_transaksi = id_transaksi;
            InitializeComponent();
            //Frm_tmbh_transaksi frm_tmbh = new Frm_tmbh_transaksi();
            
        }

        public Frm_utama_kasir()
        {
            // TODO: Complete member initialization
        }

        private void Frm_utama_kasir_Load(object sender, EventArgs e)
        {
            toolStripButton1.Text = "Cashier";
            Frm_utama_child frm_chd = new Frm_utama_child();
            frm_chd.WindowState = FormWindowState.Maximized;
            frm_chd.ControlBox = false;
            frm_chd.MdiParent = this;
            frm_chd.Show();
            
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            Frm_kasir frm_ksr = new Frm_kasir(id_pegawai, randomstring);
            frm_ksr.WindowState = FormWindowState.Maximized;
            frm_ksr.ControlBox = false;
            frm_ksr.MdiParent = this;
            frm_ksr.Show();
        }

        public string randomstring { get; set; }
    }
}
