using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemTiket.dao;
using SistemTiket.model;

namespace SistemTiket.view
{
    public partial class Frm_tmbh_transaksi : Form
    {
        string id_pegawai;
        string randomstring;
        
        public Frm_tmbh_transaksi(string id_pegawai, string randomstring)
        {
            this.id_pegawai = id_pegawai;
            this.randomstring = randomstring;
            InitializeComponent();
            txt_id_pegawai.Text = id_pegawai;
            txt_id_transaksi.Text = randomstring;
            
        }

         private void btn_simpan_Click(object sender, EventArgs e)
        {
            try {
                DtlTransaksi dtl = new DtlTransaksi();



                dtl.id_transaksi = randomstring;
                dtl.tgl_transaksi = dtp_transaksi.Value.ToString("yyyy-MM-dd");
                dtl.id_pegawai = id_pegawai;
                dtl.id_games = txt_id_game.Text;
                dtl.jumlah = Convert.ToInt16(txt_jumlah.Text);

                if ((dtl.tgl_transaksi == "") || (dtl.id_pegawai == "") || (dtl.id_games == "") || (dtl.jumlah == 0))
                {
                    MessageBox.Show("All Data Should be Filled !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (new DtlTransasksiDao().InsertData(dtl))
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch(DataException) {
                MessageBox.Show("Input Failed","Message");
            }
            
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
    }
}
