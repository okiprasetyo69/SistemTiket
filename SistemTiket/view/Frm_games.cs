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
    public partial class Frm_games : Form
    {
        public Frm_games()
        {
            InitializeComponent();
        }
        //Get Data From databases, post to Data Grid View       
        public void binding() {
            DataSet data = new GamesDao().ShowGames();
            dgv_games.DataSource = data;
            dgv_games.DataMember = "games";

            DataGridViewColumn column0 = dgv_games.Columns[0];
            column0.Width = 35;
            column0.HeaderText = "No";

            DataGridViewColumn column1 = dgv_games.Columns[1];
            column1.Width = 100;
            column1.HeaderText = "Games ID";

            DataGridViewColumn column2 = dgv_games.Columns[2];
            column2.Width = 190;
            column2.HeaderText = "Games Category";

            DataGridViewColumn column3 = dgv_games.Columns[3];
            column3.Width = 100;
            column3.HeaderText = "Price";

        }
        //Read Data on Data Grid View
        private void Frm_games_Load(object sender, EventArgs e){
            binding();
            eventclickgrid();
        }
        // Mouse hover by Clicking
        public void eventclickgrid() {

            try {
                txt_id_games.Text = Convert.ToString(dgv_games.CurrentRow.Cells[1].Value);
                txt_nama_games.Text = Convert.ToString(dgv_games.CurrentRow.Cells[2].Value);
                txt_harga.Text = Convert.ToString(dgv_games.CurrentRow.Cells[3].Value);
            }
            catch {
                MessageBox.Show("Games Not Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                binding();
            }
            
        }
        //Read Data on Data Grid View
        private void dgv_games_MouseClick(object sender, MouseEventArgs e){
            eventclickgrid();
        }
        // Mouse hover by Clicking
        private void dgv_games_KeyUp(object sender, KeyEventArgs e){
            eventclickgrid();
        }
        //Add Data
        private void btn_tambah_Click(object sender, EventArgs e){
            Frm_tmbh_games frm_tmbh = new Frm_tmbh_games();
            if (frm_tmbh.ShowDialog() == DialogResult.OK){
                MessageBox.Show("Data Has Been Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                binding();
            }

        }

        private void btn_ubah_Click(object sender, EventArgs e){
            Games g = new Games();
            g.id_games = txt_id_games.Text;
            g.nama_games = txt_nama_games.Text;
            g.harga = Convert.ToDouble(txt_harga.Text);

            if (new GamesDao().UpdateData(g))
            {
                MessageBox.Show("Data Has Been Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                binding();
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e){
            if(txt_id_games.Text == ""){
                MessageBox.Show("Games ID is Null", "Message", MessageBoxButtons.OK);
                return;
            }
            DialogResult dialogresult = MessageBox.Show("Are You Sure Want to Delete this Data ?", "Alert",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogresult == DialogResult.Yes)
            {
                Games g = new Games();
                g.id_games = txt_id_games.Text;
                if (new GamesDao().DeleteData(g))
                {
                    MessageBox.Show("Data Has Been Deleted.", "Message", MessageBoxButtons.OK);
                    binding();
                }
            }
        }

        private void btn_cari_Click(object sender, EventArgs e){
            if(txt_cari.Text == ""){
                MessageBox.Show("Please Input Keywords ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Games g = new Games();
            if(cmb_cari.Text == "Games Category"){
                try {
                    g.nama_games = txt_cari.Text;
                    DataSet ds = new GamesDao().FindByName(g);
                    dgv_games.DataSource = ds;
                    dgv_games.DataMember = "games";
                    eventclickgrid();
                }
                catch (DataException) {
                    MessageBox.Show("Games Category Not Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(cmb_cari.Text == "Games ID"){
                try {
                    g.id_games = txt_cari.Text;
                    DataSet ds = new GamesDao().FindById(g);
                    dgv_games.DataSource = ds;
                    dgv_games.DataMember = "games";
                    eventclickgrid();
                }
                catch (DataException) {
                    MessageBox.Show("Games ID Not Found !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_kembali_Click(object sender, EventArgs e){
            binding();
            eventclickgrid();
        }

    }
}
