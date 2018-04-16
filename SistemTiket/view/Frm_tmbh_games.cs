using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemTiket.model;
using SistemTiket.dao;

namespace SistemTiket.view
{
    public partial class Frm_tmbh_games : Form
    {
        public Frm_tmbh_games()
        {
            InitializeComponent();
        }

        private void btn_simpan_Click(object sender, EventArgs e){
            Games g = new Games();
            g.id_games = txt_id_games.Text;
            g.nama_games = txt_nama_games.Text;
            g.harga = Convert.ToDouble(txt_harga.Text);
            if ((g.id_games== "") || (g.nama_games == "") || (g.harga == 0)){
                MessageBox.Show("All Data Should be Filled !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (new GamesDao().InsertData(g)){
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_id_games.Text = "";
            txt_nama_games.Text = "";
            txt_harga.Text = "";
        }
    }
}
