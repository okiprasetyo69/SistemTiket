namespace SistemTiket.view
{
    partial class Frm_dtl_transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_dtl_transaksi));
            this.dgv_transaksi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.btn_cari = new System.Windows.Forms.Button();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.cmb_cari = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_kembali_tgl = new System.Windows.Forms.Button();
            this.btn_cari_tgl = new System.Windows.Forms.Button();
            this.dtp_akhir = new System.Windows.Forms.DateTimePicker();
            this.dtp_awal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.txt_dtl_transaksi = new System.Windows.Forms.TextBox();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_tgl_transaksi = new System.Windows.Forms.DateTimePicker();
            this.txt_jumlah = new System.Windows.Forms.TextBox();
            this.txt_id_game = new System.Windows.Forms.TextBox();
            this.txt_id_pegawai = new System.Windows.Forms.TextBox();
            this.txt_id_transaksi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_transaksi
            // 
            this.dgv_transaksi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaksi.Location = new System.Drawing.Point(27, 28);
            this.dgv_transaksi.Name = "dgv_transaksi";
            this.dgv_transaksi.Size = new System.Drawing.Size(758, 150);
            this.dgv_transaksi.TabIndex = 0;
            this.dgv_transaksi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_transaksi_KeyUp);
            this.dgv_transaksi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_transaksi_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_kembali);
            this.groupBox1.Controls.Add(this.btn_cari);
            this.groupBox1.Controls.Add(this.txt_cari);
            this.groupBox1.Controls.Add(this.cmb_cari);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(293, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Transaction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Keywords :";
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kembali.Image = ((System.Drawing.Image)(resources.GetObject("btn_kembali.Image")));
            this.btn_kembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kembali.Location = new System.Drawing.Point(154, 90);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(84, 53);
            this.btn_kembali.TabIndex = 4;
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
            this.btn_cari.Location = new System.Drawing.Point(64, 90);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(82, 53);
            this.btn_cari.TabIndex = 3;
            this.btn_cari.Text = "Search";
            this.btn_cari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cari.UseVisualStyleBackColor = false;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // txt_cari
            // 
            this.txt_cari.Location = new System.Drawing.Point(92, 61);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(146, 22);
            this.txt_cari.TabIndex = 2;
            // 
            // cmb_cari
            // 
            this.cmb_cari.FormattingEnabled = true;
            this.cmb_cari.Items.AddRange(new object[] {
            "ID Transaction",
            "ID Games"});
            this.cmb_cari.Location = new System.Drawing.Point(92, 26);
            this.cmb_cari.Name = "cmb_cari";
            this.cmb_cari.Size = new System.Drawing.Size(146, 24);
            this.cmb_cari.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_kembali_tgl);
            this.groupBox2.Controls.Add(this.btn_cari_tgl);
            this.groupBox2.Controls.Add(this.dtp_akhir);
            this.groupBox2.Controls.Add(this.dtp_awal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(555, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Transaction By Date";
            // 
            // btn_kembali_tgl
            // 
            this.btn_kembali_tgl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kembali_tgl.Image = ((System.Drawing.Image)(resources.GetObject("btn_kembali_tgl.Image")));
            this.btn_kembali_tgl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kembali_tgl.Location = new System.Drawing.Point(164, 88);
            this.btn_kembali_tgl.Name = "btn_kembali_tgl";
            this.btn_kembali_tgl.Size = new System.Drawing.Size(84, 53);
            this.btn_kembali_tgl.TabIndex = 6;
            this.btn_kembali_tgl.Text = "Back";
            this.btn_kembali_tgl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kembali_tgl.UseVisualStyleBackColor = false;
            this.btn_kembali_tgl.Click += new System.EventHandler(this.btn_kembali_tgl_Click);
            // 
            // btn_cari_tgl
            // 
            this.btn_cari_tgl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cari_tgl.Image = ((System.Drawing.Image)(resources.GetObject("btn_cari_tgl.Image")));
            this.btn_cari_tgl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cari_tgl.Location = new System.Drawing.Point(76, 88);
            this.btn_cari_tgl.Name = "btn_cari_tgl";
            this.btn_cari_tgl.Size = new System.Drawing.Size(82, 53);
            this.btn_cari_tgl.TabIndex = 5;
            this.btn_cari_tgl.Text = "Search";
            this.btn_cari_tgl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cari_tgl.UseVisualStyleBackColor = false;
            this.btn_cari_tgl.Click += new System.EventHandler(this.btn_cari_tgl_Click);
            // 
            // dtp_akhir
            // 
            this.dtp_akhir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_akhir.Location = new System.Drawing.Point(92, 59);
            this.dtp_akhir.Name = "dtp_akhir";
            this.dtp_akhir.Size = new System.Drawing.Size(156, 22);
            this.dtp_akhir.TabIndex = 3;
            // 
            // dtp_awal
            // 
            this.dtp_awal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_awal.Location = new System.Drawing.Point(92, 26);
            this.dtp_awal.Name = "dtp_awal";
            this.dtp_awal.Size = new System.Drawing.Size(156, 22);
            this.dtp_awal.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Date :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_transaksi);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(810, 189);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction Data Tables";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_ubah);
            this.groupBox4.Controls.Add(this.txt_dtl_transaksi);
            this.groupBox4.Controls.Add(this.btn_hapus);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.dtp_tgl_transaksi);
            this.groupBox4.Controls.Add(this.txt_jumlah);
            this.groupBox4.Controls.Add(this.txt_id_game);
            this.groupBox4.Controls.Add(this.txt_id_pegawai);
            this.groupBox4.Controls.Add(this.txt_id_transaksi);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(13, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 226);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ubah.Image = ((System.Drawing.Image)(resources.GetObject("btn_ubah.Image")));
            this.btn_ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ubah.Location = new System.Drawing.Point(180, 174);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(83, 46);
            this.btn_ubah.TabIndex = 10;
            this.btn_ubah.Text = "Update";
            this.btn_ubah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // txt_dtl_transaksi
            // 
            this.txt_dtl_transaksi.Location = new System.Drawing.Point(100, 15);
            this.txt_dtl_transaksi.Name = "txt_dtl_transaksi";
            this.txt_dtl_transaksi.ReadOnly = true;
            this.txt_dtl_transaksi.Size = new System.Drawing.Size(163, 20);
            this.txt_dtl_transaksi.TabIndex = 11;
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hapus.Image = ((System.Drawing.Image)(resources.GetObject("btn_hapus.Image")));
            this.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hapus.Location = new System.Drawing.Point(98, 176);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 46);
            this.btn_hapus.TabIndex = 11;
            this.btn_hapus.Text = "Delete";
            this.btn_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Order ID : ";
            // 
            // dtp_tgl_transaksi
            // 
            this.dtp_tgl_transaksi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_tgl_transaksi.Location = new System.Drawing.Point(98, 68);
            this.dtp_tgl_transaksi.Name = "dtp_tgl_transaksi";
            this.dtp_tgl_transaksi.Size = new System.Drawing.Size(165, 20);
            this.dtp_tgl_transaksi.TabIndex = 9;
            // 
            // txt_jumlah
            // 
            this.txt_jumlah.Location = new System.Drawing.Point(98, 149);
            this.txt_jumlah.Name = "txt_jumlah";
            this.txt_jumlah.Size = new System.Drawing.Size(165, 20);
            this.txt_jumlah.TabIndex = 8;
            // 
            // txt_id_game
            // 
            this.txt_id_game.Location = new System.Drawing.Point(98, 123);
            this.txt_id_game.Name = "txt_id_game";
            this.txt_id_game.Size = new System.Drawing.Size(165, 20);
            this.txt_id_game.TabIndex = 7;
            // 
            // txt_id_pegawai
            // 
            this.txt_id_pegawai.Location = new System.Drawing.Point(98, 94);
            this.txt_id_pegawai.Name = "txt_id_pegawai";
            this.txt_id_pegawai.ReadOnly = true;
            this.txt_id_pegawai.Size = new System.Drawing.Size(165, 20);
            this.txt_id_pegawai.TabIndex = 6;
            // 
            // txt_id_transaksi
            // 
            this.txt_id_transaksi.Location = new System.Drawing.Point(100, 41);
            this.txt_id_transaksi.Name = "txt_id_transaksi";
            this.txt_id_transaksi.ReadOnly = true;
            this.txt_id_transaksi.Size = new System.Drawing.Size(163, 20);
            this.txt_id_transaksi.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Amount : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Games ID : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Transaction ID : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Transaction Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employee ID : ";
            // 
            // Frm_dtl_transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(880, 431);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_dtl_transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Detail";
            this.Load += new System.EventHandler(this.Frm_dtl_transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_transaksi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.ComboBox cmb_cari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_kembali_tgl;
        private System.Windows.Forms.Button btn_cari_tgl;
        private System.Windows.Forms.DateTimePicker dtp_akhir;
        private System.Windows.Forms.DateTimePicker dtp_awal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtp_tgl_transaksi;
        private System.Windows.Forms.TextBox txt_jumlah;
        private System.Windows.Forms.TextBox txt_id_game;
        private System.Windows.Forms.TextBox txt_id_pegawai;
        private System.Windows.Forms.TextBox txt_id_transaksi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_dtl_transaksi;
        private System.Windows.Forms.Label label10;
    }
}