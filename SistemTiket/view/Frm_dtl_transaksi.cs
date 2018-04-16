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
    public partial class Frm_dtl_transaksi : Form
    {
        public Frm_dtl_transaksi()
        {
            InitializeComponent();
        }

        private void Frm_dtl_transaksi_Load(object sender, EventArgs e){
            binding();
            eventclickgrid();
           
        }
        public void binding() {
            DataSet data = new DtlTransasksiDao().ShowTransaction();
            dgv_transaksi.DataSource = data;
            dgv_transaksi.DataMember = "db_ticket";

            DataGridViewColumn column0 = dgv_transaksi.Columns[0];
            column0.Width = 125;
            column0.HeaderText = "ID Order";

            DataGridViewColumn column1 = dgv_transaksi.Columns[1];
            column1.Width = 125;
            column1.HeaderText = "ID Transaction";

            DataGridViewColumn column2 = dgv_transaksi.Columns[2];
            column2.Width = 150;
            column2.HeaderText = "Transaction Date";

            DataGridViewColumn column3 = dgv_transaksi.Columns[3];
            column3.Width = 100;
            column3.HeaderText = "Employee ID";

            DataGridViewColumn column4 = dgv_transaksi.Columns[4];
            column4.Width = 100;
            column4.HeaderText = "Games ID";

            DataGridViewColumn column5 = dgv_transaksi.Columns[5];
            column5.Width = 150;
            column5.HeaderText = "Game Category";

            DataGridViewColumn column6 = dgv_transaksi.Columns[6];
            column6.Width = 100;
            column6.HeaderText = "Price";

            DataGridViewColumn column7 = dgv_transaksi.Columns[7];
            column7.Width = 50;
            column7.HeaderText = "Amount";

            DataGridViewColumn column8 = dgv_transaksi.Columns[8];
            column8.Width = 100;
            column8.HeaderText = "Total";

           

        }
        public void eventclickgrid() {
            txt_dtl_transaksi.Text = Convert.ToString(dgv_transaksi.CurrentRow.Cells[0].Value);
            txt_id_transaksi.Text = Convert.ToString(dgv_transaksi.CurrentRow.Cells[1].Value);
            dtp_tgl_transaksi.Text = Convert.ToString(dgv_transaksi.CurrentRow.Cells[2].Value);
            txt_id_pegawai.Text = Convert.ToString(dgv_transaksi.CurrentRow.Cells[3].Value);
            txt_id_game.Text = Convert.ToString(dgv_transaksi.CurrentRow.Cells[4].Value);
            txt_jumlah.Text = Convert.ToString(dgv_transaksi.CurrentRow.Cells[7].Value);
        }

        private void btn_cari_Click(object sender, EventArgs e){
            if(txt_cari.Text == ""){
                MessageBox.Show("Please Input Keywords ! ","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           DtlTransaksi dtl_transaksi = new DtlTransaksi();
           if(cmb_cari.Text == "ID Transaction"){
                try{
                    dtl_transaksi.id_transaksi = txt_cari.Text;
                    DataSet ds = new DtlTransasksiDao().FindById(dtl_transaksi);

                    dgv_transaksi.DataSource = ds;
                    dgv_transaksi.DataMember = "dtl_transaksi";
                    eventclickgrid();
                }
                catch (DataException){
                    MessageBox.Show("ID Transaction Not Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(cmb_cari.Text == "ID Games"){
                try {
                    dtl_transaksi.id_games = txt_cari.Text;
                    DataSet ds = new DtlTransasksiDao().FindByCategory(dtl_transaksi);
                    dgv_transaksi.DataSource = ds;
                    dgv_transaksi.DataMember = "dtl_transaksi";
                    eventclickgrid();
                }
                catch (DataException) {
                    MessageBox.Show("ID Games Not Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }          
        }

        private void btn_kembali_Click(object sender, EventArgs e) {
            binding();
        }

        private void btn_cari_tgl_Click(object sender, EventArgs e){
            if ((dtp_awal.Text == "") || (dtp_akhir.Text == ""))
            {
                MessageBox.Show("Please Input Keywords ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                try {
                    DtlTransaksi dtl_transaksi = new DtlTransaksi();
                    dtl_transaksi.tgl_transaksi_awal = dtp_awal.Value.ToString("yyyy-MM-dd");
                    dtl_transaksi.tgl_transaksi_akhir = dtp_akhir.Value.ToString("yyyy-MM-dd");
                    DataSet ds = new DtlTransasksiDao().FindByDate(dtl_transaksi);
                    dgv_transaksi.DataSource = ds;
                    dgv_transaksi.DataMember = "dtl_transaksi";
                }
                catch (DataException){
                    MessageBox.Show("Games Category Not Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }                  
        }

        private void btn_kembali_tgl_Click(object sender, EventArgs e){
            binding();
        }

        private void dgv_transaksi_KeyUp(object sender, KeyEventArgs e)
        {
            eventclickgrid();
        }

        private void dgv_transaksi_MouseClick(object sender, MouseEventArgs e)
        {
            eventclickgrid();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if(txt_id_transaksi.Text == ""){
                MessageBox.Show("ID Transaction not selected", "Message", MessageBoxButtons.OK);
                return;
            }
            DialogResult dialogresult = MessageBox.Show("Are You Sure Want to Delete this Data ?", "Alert",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (dialogresult == DialogResult.Yes){
                DtlTransaksi dtl = new DtlTransaksi();
                dtl.id_transaksi =txt_id_transaksi.Text;

                if(new DtlTransasksiDao().DeleteData(dtl)){
                    MessageBox.Show("Data Has Been Deleted.", "Message", MessageBoxButtons.OK);
                    binding();
                }
            }
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            DtlTransaksi dtl = new DtlTransaksi();
            dtl.id_dtl_transaksi = Convert.ToInt16(txt_dtl_transaksi.Text);
            dtl.id_transaksi = txt_id_transaksi.Text;
            dtl.tgl_transaksi = dtp_tgl_transaksi.Value.ToString("yyyy-MM-dd");
            dtl.id_pegawai = txt_id_pegawai.Text;
            dtl.id_games = txt_id_game.Text;       
            dtl.jumlah = Convert.ToInt16(txt_jumlah.Text);

            if(new DtlTransasksiDao().UpdateData(dtl)){
                MessageBox.Show("Data Has Been Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                binding();
            }
        }
    }
}
