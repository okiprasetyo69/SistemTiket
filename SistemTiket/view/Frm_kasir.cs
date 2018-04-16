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
    public partial class Frm_kasir : Form
    {
        private string id_pegawai;
        private string randomstring;
        
        public Frm_kasir(string id_pegawai, string randomstring) //string id_transaksi)
        {
            this.id_pegawai = id_pegawai;
            this.randomstring = randomstring;
            InitializeComponent();
        }

    
   
        //Get Data From databases, post to Data Grid View       
        public void binding(){

            DataSet data = new DtlTransasksiDao().CountTicket(dtl);
            dgv_transaksi.DataSource = data;
            dgv_transaksi.DataMember = "db_ticket";

            DataGridViewColumn column0 = dgv_transaksi.Columns[0];
            column0.Width = 125;
            column0.HeaderText = "Transaction ID";

            DataGridViewColumn column1 = dgv_transaksi.Columns[1];
            column1.Width = 125;
            column1.HeaderText = "Transaction Date";

            DataGridViewColumn column2 = dgv_transaksi.Columns[2];
            column2.Width = 80;
            column2.HeaderText = "Games ID";

            DataGridViewColumn column3 = dgv_transaksi.Columns[3];
            column3.Width = 150;
            column3.HeaderText = "Games Category";

            DataGridViewColumn column4 = dgv_transaksi.Columns[4];
            column4.Width = 50;
            column4.HeaderText = "Price";

            DataGridViewColumn column5 = dgv_transaksi.Columns[5];
            column5.Width = 50;
            column5.HeaderText = "Amount";

            DataGridViewColumn column6 = dgv_transaksi.Columns[6];
            column6.Width = 100;
            column6.HeaderText = "Total";
        }

        public void BindingGame() {
            DataSet data = new GamesDao().ShowGames();
            dgv_game.DataSource = data;
            dgv_game.DataMember = "games";

            DataGridViewColumn column0 = dgv_game.Columns[0];
            column0.Width = 35;
            column0.HeaderText = "No";

            DataGridViewColumn column1 = dgv_game.Columns[1];
            column1.Width = 100;
            column1.HeaderText = "Games ID";

            DataGridViewColumn column2 = dgv_game.Columns[2];
            column2.Width = 150;
            column2.HeaderText = "Games Category";

            DataGridViewColumn column3 = dgv_game.Columns[3];
            column3.Width = 100;
            column3.HeaderText = "Price";
        }
            
        private void Frm_kasir_Load(object sender, EventArgs e){
            
            BindingGame();       
            lbl_total.Text = "-";
            GenerateRandom(randomstring);
            
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
           
            // Insert Data in Form
            
                Frm_tmbh_transaksi frm_tmbh = new Frm_tmbh_transaksi(id_pegawai, txt_id_transaksi.Text);
                if (frm_tmbh.ShowDialog() == DialogResult.OK){
                    MessageBox.Show("Data Has Been Added To Cart", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    binding();
                    DataSet ds = new DtlTransasksiDao().GrandTotal(dtl);
               
                    lbl_total.Text = ds.Tables[0].Rows[0][0].ToString();          
                }
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            if(txt_cari.Text == ""){
                MessageBox.Show("Please Input Keywords ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Games g = new Games();
            if(cmb_cari.Text == "Games ID"){
                try{
                    g.id_games = txt_cari.Text;
                    DataSet ds = new GamesDao().FindById(g);
                    dgv_game.DataSource = ds;
                    dgv_game.DataMember = "games";
                   
                } catch (DataException){
                    MessageBox.Show("Games ID Not Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (cmb_cari.Text == "Games Category"){
                try {
                    g.nama_games = txt_cari.Text;
                    DataSet ds = new GamesDao().FindByName(g);
                    dgv_game.DataSource = ds;
                    dgv_game.DataMember = "games";
                }catch(DataException){
                    MessageBox.Show("Games ID Not Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            BindingGame();
        }

        internal DtlTransaksi dtl { get; set; }

        

        private void btn_cetak_Click(object sender, EventArgs e)
        {
            Frm_rpt_ticket frm_rpt = new Frm_rpt_ticket();
            frm_rpt.WindowState = FormWindowState.Maximized;
            frm_rpt.ControlBox = false;
            
            frm_rpt.Show();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            MasterTransaksi mstr_trns = new MasterTransaksi();
            mstr_trns.id_transaksi = txt_id_transaksi.Text;
            mstr_trns.total = Convert.ToDouble(lbl_total.Text);
            if(new MasterTransaksiDao().UpdateData(mstr_trns)){
                MessageBox.Show("Data Transaaction Has Been Saved","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            binding();
            GenerateRandom(randomstring);
            lbl_kembalian.Text = "";
            txt_bayar.Text = "";
            lbl_total.Text = "";
            
        }

        private void btn_bayar_Click(object sender, EventArgs e)
        {
            DtlTransaksi dtl = new DtlTransaksi();
            if (txt_bayar.Text == "")
            {
                MessageBox.Show("Please input cash money !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                DataSet ds = new DtlTransasksiDao().GrandTotal(dtl);
                lbl_total.Text = ds.Tables[0].Rows[0][0].ToString();

                double bayar = Convert.ToDouble(txt_bayar.Text);
                double grand_total = Convert.ToDouble(lbl_total.Text);

                double kembalian = bayar - grand_total;
                lbl_kembalian.Text = Convert.ToString(kembalian);
            }
            
            
        }

        public void GenerateRandom(string randomstring) {
            MasterTransaksi mstr_trns = new MasterTransaksi();
            // Create Random ID Transaction
            char[] acak = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            Random rand = new Random();
            randomstring = "";
            for (int i = 0; i < 10; i++)
            {
                randomstring += acak[rand.Next(0, 10)].ToString();
            }

            //Insert ID Transaction

            txt_id_transaksi.Text = randomstring;
            mstr_trns.id_transaksi = txt_id_transaksi.Text;
            if (new MasterTransaksiDao().InsertData(mstr_trns))
            {
                this.DialogResult = DialogResult.OK;
            }
            return;
        }

        
    }
}
