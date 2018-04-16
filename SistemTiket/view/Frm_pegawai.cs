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
    public partial class Frm_pegawai : Form
    {
        public Frm_pegawai()
        {
            InitializeComponent();
        }

        //Get Data From databases, post to Data Grid View
        public void binding() {
            DataSet data = new PegawaiDao().ShowEmployee();
            dgv_pegawai.DataSource = data;
            dgv_pegawai.DataMember = "users";

            DataGridViewColumn column0 = dgv_pegawai.Columns[0];
            column0.Width = 35;
            column0.HeaderText = "No.";

            DataGridViewColumn column1 = dgv_pegawai.Columns[1];
            column1.Width = 100;
            column1.HeaderText = "Employee ID";

            DataGridViewColumn column2 = dgv_pegawai.Columns[2];
            column2.Width = 175;
            column2.HeaderText = "User Name";

            DataGridViewColumn column3 = dgv_pegawai.Columns[3];
            column3.Width = 70;
            column3.HeaderText = "Status";

            DataGridViewColumn column4 = dgv_pegawai.Columns[4];
            column4.Width = 150;
            column4.HeaderText = "Passwords";

        }

        //Load Data By Binding and Event Click Grid
        private void Frm_pegawai_Load(object sender, EventArgs e)
        {
            binding();
            eventclickgrid();
        }

        //Click Data
        public void eventclickgrid() {
            try{
                txt_id_pegawai.Text = Convert.ToString(dgv_pegawai.CurrentRow.Cells[1].Value);
                txt_nama_pegawai.Text = Convert.ToString(dgv_pegawai.CurrentRow.Cells[2].Value);
                cmb_status.Text = Convert.ToString(dgv_pegawai.CurrentRow.Cells[3].Value);
                txt_passwords.Text = Convert.ToString(dgv_pegawai.CurrentRow.Cells[4].Value);
            }
            catch {
                MessageBox.Show("User Not Found !","Message" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                binding();
            }
            
        }

        //Read Data on Data Grid View
        private void dgv_pegawai_MouseClick(object sender, MouseEventArgs e){
            eventclickgrid();
        }

        // Mouse hover by Clicking
        private void dgv_pegawai_KeyUp(object sender, KeyEventArgs e) {
            eventclickgrid();
        }

        private void btn_tambah_Click(object sender, EventArgs e) {
            Frm_tmbh_pegawai frm_tmbh = new Frm_tmbh_pegawai();
            if(frm_tmbh.ShowDialog()==DialogResult.OK){
                MessageBox.Show("Data Has Been Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                binding();
            }
        }

        private void btn_ubah_Click(object sender, EventArgs e){
            Pegawai p = new Pegawai();

            p.id_pegawai = txt_id_pegawai.Text;
            p.nama_pegawai = txt_nama_pegawai.Text;
            p.status = cmb_status.Text;
            p.passwords = txt_passwords.Text;

            if(new PegawaiDao().UpdateData(p)){
                MessageBox.Show("Data Has Been Updated","Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
                binding();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e){
            if(txt_id_pegawai.Text == ""){
                MessageBox.Show("Employee ID is Null", "Message",MessageBoxButtons.OK);
                return;
            }
            DialogResult dialogresult = MessageBox.Show("Are You Sure Want to Delete this Data ?", "Alert",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if(dialogresult == DialogResult.Yes){
                Pegawai p = new Pegawai();
    
                if(new PegawaiDao().DeleteData(p)){
                    MessageBox.Show("Data Has Been Deleted.","Message",MessageBoxButtons.OK);
                    binding();
                }
            }
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            if( txt_cari.Text == ""){
                MessageBox.Show("Please Input Keywords ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Pegawai p = new Pegawai();

            if (cmb_cari.Text == "User Name"){
                try{
                    p.nama_pegawai = txt_cari.Text;
                    DataSet ds = new PegawaiDao().FindByName(p);
                    dgv_pegawai.DataSource = ds;
                    dgv_pegawai.DataMember = "users";
                    eventclickgrid();                  
                }
                catch (DataException){
                    MessageBox.Show("User Name Not Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(cmb_cari.Text == "Employee ID"){
                try {
                    p.id_pegawai = txt_cari.Text;
                    DataSet ds = new PegawaiDao().FindById(p);
                    dgv_pegawai.DataSource = ds;
                    dgv_pegawai.DataMember = "users";
                    eventclickgrid();
                }
                catch (DataException){
                   MessageBox.Show("Employee ID Not Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }

        private void btn_kembali_Click(object sender, EventArgs e) {
            
            binding();
            eventclickgrid();
        }   
    }
}
