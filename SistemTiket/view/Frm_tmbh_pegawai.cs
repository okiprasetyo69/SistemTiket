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
    public partial class Frm_tmbh_pegawai : Form
    {
        public Frm_tmbh_pegawai()
        {
            InitializeComponent();
        }

        private void btn_simpan_Click(object sender, EventArgs e){
            Pegawai p = new Pegawai();
            p.id_pegawai = txt_id_pegawai.Text;
            p.nama_pegawai = txt_nama_pegawai.Text;
            p.status = cmb_status.Text;
            p.passwords = txt_passwords.Text;

            if((p.id_pegawai == "")||(p.nama_pegawai == "")||(p.passwords == "")||(p.status == "")){
                MessageBox.Show("All Data Should be Filled !","Alert",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if(new PegawaiDao().InsertData(p)){
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e){
            txt_id_pegawai.Text = "";
            txt_nama_pegawai.Text = "";
            cmb_status.Text = "";
            txt_passwords.Text = ""; 
        }
    }
}
