namespace SistemTiket.view
{
    partial class Frm_kasir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_kasir));
            this.btn_tambah = new System.Windows.Forms.Button();
            this.grouBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_transaksi = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_game = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_kembalian = new System.Windows.Forms.Label();
            this.btn_bayar = new System.Windows.Forms.Button();
            this.txt_bayar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_cetak = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.btn_cari = new System.Windows.Forms.Button();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_cari = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_transaksi = new System.Windows.Forms.TextBox();
            this.grouBox2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_game)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tambah.Image = ((System.Drawing.Image)(resources.GetObject("btn_tambah.Image")));
            this.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tambah.Location = new System.Drawing.Point(16, 15);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(120, 53);
            this.btn_tambah.TabIndex = 7;
            this.btn_tambah.Text = "Get The Ticket";
            this.btn_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // grouBox2
            // 
            this.grouBox2.Controls.Add(this.lbl_total);
            this.grouBox2.Controls.Add(this.label5);
            this.grouBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouBox2.Location = new System.Drawing.Point(41, 366);
            this.grouBox2.Name = "grouBox2";
            this.grouBox2.Size = new System.Drawing.Size(343, 90);
            this.grouBox2.TabIndex = 1;
            this.grouBox2.TabStop = false;
            this.grouBox2.Text = "Grand Total";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(56, 52);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(17, 24);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rp. ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_transaksi);
            this.groupBox2.Location = new System.Drawing.Point(41, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 231);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voucher Cart";
            // 
            // dgv_transaksi
            // 
            this.dgv_transaksi.AllowUserToAddRows = false;
            this.dgv_transaksi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaksi.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_transaksi.Location = new System.Drawing.Point(18, 25);
            this.dgv_transaksi.Name = "dgv_transaksi";
            this.dgv_transaksi.Size = new System.Drawing.Size(541, 188);
            this.dgv_transaksi.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_game);
            this.groupBox3.Location = new System.Drawing.Point(653, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 231);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Games Category";
            // 
            // dgv_game
            // 
            this.dgv_game.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_game.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_game.Location = new System.Drawing.Point(13, 24);
            this.dgv_game.Name = "dgv_game";
            this.dgv_game.Size = new System.Drawing.Size(462, 189);
            this.dgv_game.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_kembalian);
            this.groupBox4.Controls.Add(this.btn_bayar);
            this.groupBox4.Controls.Add(this.txt_bayar);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(412, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 148);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment";
            // 
            // lbl_kembalian
            // 
            this.lbl_kembalian.AutoSize = true;
            this.lbl_kembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kembalian.Location = new System.Drawing.Point(78, 71);
            this.lbl_kembalian.Name = "lbl_kembalian";
            this.lbl_kembalian.Size = new System.Drawing.Size(15, 20);
            this.lbl_kembalian.TabIndex = 9;
            this.lbl_kembalian.Text = "-";
            // 
            // btn_bayar
            // 
            this.btn_bayar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bayar.Image = ((System.Drawing.Image)(resources.GetObject("btn_bayar.Image")));
            this.btn_bayar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bayar.Location = new System.Drawing.Point(108, 99);
            this.btn_bayar.Name = "btn_bayar";
            this.btn_bayar.Size = new System.Drawing.Size(80, 43);
            this.btn_bayar.TabIndex = 8;
            this.btn_bayar.Text = "Count";
            this.btn_bayar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_bayar.UseVisualStyleBackColor = false;
            this.btn_bayar.Click += new System.EventHandler(this.btn_bayar_Click);
            // 
            // txt_bayar
            // 
            this.txt_bayar.Location = new System.Drawing.Point(73, 31);
            this.txt_bayar.Name = "txt_bayar";
            this.txt_bayar.Size = new System.Drawing.Size(154, 20);
            this.txt_bayar.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Change :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cash :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_tambah);
            this.groupBox5.Location = new System.Drawing.Point(41, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(158, 88);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Transaction";
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_simpan.Image = ((System.Drawing.Image)(resources.GetObject("btn_simpan.Image")));
            this.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_simpan.Location = new System.Drawing.Point(127, 19);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(77, 53);
            this.btn_simpan.TabIndex = 9;
            this.btn_simpan.Text = "Save";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_cetak
            // 
            this.btn_cetak.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cetak.Image = ((System.Drawing.Image)(resources.GetObject("btn_cetak.Image")));
            this.btn_cetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cetak.Location = new System.Drawing.Point(18, 19);
            this.btn_cetak.Name = "btn_cetak";
            this.btn_cetak.Size = new System.Drawing.Size(103, 53);
            this.btn_cetak.TabIndex = 11;
            this.btn_cetak.Text = "Print Voucher";
            this.btn_cetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cetak.UseVisualStyleBackColor = false;
            this.btn_cetak.Click += new System.EventHandler(this.btn_cetak_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cetak);
            this.groupBox1.Controls.Add(this.btn_simpan);
            this.groupBox1.Location = new System.Drawing.Point(701, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 85);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_kembali);
            this.groupBox6.Controls.Add(this.btn_cari);
            this.groupBox6.Controls.Add(this.txt_cari);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.cmb_cari);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(687, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(425, 88);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search Games";
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kembali.Image = ((System.Drawing.Image)(resources.GetObject("btn_kembali.Image")));
            this.btn_kembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kembali.Location = new System.Drawing.Point(326, 19);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(84, 57);
            this.btn_kembali.TabIndex = 5;
            this.btn_kembali.Text = "Back";
            this.btn_kembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kembali.UseVisualStyleBackColor = false;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cari.Image = ((System.Drawing.Image)(resources.GetObject("btn_cari.Image")));
            this.btn_cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cari.Location = new System.Drawing.Point(236, 19);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(84, 57);
            this.btn_cari.TabIndex = 4;
            this.btn_cari.Text = "Search";
            this.btn_cari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cari.UseVisualStyleBackColor = false;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // txt_cari
            // 
            this.txt_cari.Location = new System.Drawing.Point(78, 53);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(121, 20);
            this.txt_cari.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Keywords :";
            // 
            // cmb_cari
            // 
            this.cmb_cari.FormattingEnabled = true;
            this.cmb_cari.Items.AddRange(new object[] {
            "Games ID",
            "Games Category"});
            this.cmb_cari.Location = new System.Drawing.Point(78, 26);
            this.cmb_cari.Name = "cmb_cari";
            this.cmb_cari.Size = new System.Drawing.Size(121, 21);
            this.cmb_cari.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By :";
            // 
            // txt_id_transaksi
            // 
            this.txt_id_transaksi.Location = new System.Drawing.Point(226, 32);
            this.txt_id_transaksi.Name = "txt_id_transaksi";
            this.txt_id_transaksi.Size = new System.Drawing.Size(100, 20);
            this.txt_id_transaksi.TabIndex = 14;
            // 
            // Frm_kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 599);
            this.Controls.Add(this.txt_id_transaksi);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grouBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_kasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier Page";
            this.Load += new System.EventHandler(this.Frm_kasir_Load);
            this.grouBox2.ResumeLayout(false);
            this.grouBox2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_game)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.GroupBox grouBox2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_transaksi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_bayar;
        private System.Windows.Forms.TextBox txt_bayar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.DataGridView dgv_game;
        private System.Windows.Forms.Button btn_cetak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_cari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_kembalian;
        private System.Windows.Forms.TextBox txt_id_transaksi;
    }
}