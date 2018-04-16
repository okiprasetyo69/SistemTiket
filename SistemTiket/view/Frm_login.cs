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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e){
            if((txt_id_pegawai.Text == "")||(txt_passwords.Text == ""))
            {
                MessageBox.Show("Please fill in all field !","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Login obj_login = new Login();
            obj_login.id_pegawai = txt_id_pegawai.Text;
            obj_login.passwords = txt_passwords.Text;

            if(new LoginDao().login_pegawai(obj_login) == "sukses"){
                MessageBox.Show("Login Success","Message");
                if (new StatusPegawaiDao().status(obj_login) == "SPV"){
                    Frm_utama_parent frm_utama = new Frm_utama_parent();
                    frm_utama.Show();
                }
                else if(new StatusPegawaiDao().status(obj_login) == "KSR"){
                    Frm_utama_kasir frm_ksr = new Frm_utama_kasir(txt_id_pegawai.Text);
                    frm_ksr.Show();
                }                               
            }
            else{
                MessageBox.Show("ID Employee & Password is Wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_id_pegawai.Text = "";
            txt_passwords.Text = "";
        }

        
    }
}
