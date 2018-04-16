namespace SistemTiket.view
{
    partial class Frm_games
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_games));
            this.dgv_games = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_nama_games = new System.Windows.Forms.TextBox();
            this.txt_id_games = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.cmb_cari = new System.Windows.Forms.ComboBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_games)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_games
            // 
            this.dgv_games.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_games.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_games.Location = new System.Drawing.Point(21, 20);
            this.dgv_games.Name = "dgv_games";
            this.dgv_games.ReadOnly = true;
            this.dgv_games.Size = new System.Drawing.Size(473, 189);
            this.dgv_games.TabIndex = 1;
            this.dgv_games.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_games_KeyUp);
            this.dgv_games.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_games_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_harga);
            this.groupBox1.Controls.Add(this.txt_nama_games);
            this.groupBox1.Controls.Add(this.txt_id_games);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Games";
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(169, 102);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(214, 26);
            this.txt_harga.TabIndex = 5;
            // 
            // txt_nama_games
            // 
            this.txt_nama_games.Location = new System.Drawing.Point(169, 65);
            this.txt_nama_games.Name = "txt_nama_games";
            this.txt_nama_games.Size = new System.Drawing.Size(214, 26);
            this.txt_nama_games.TabIndex = 4;
            // 
            // txt_id_games
            // 
            this.txt_id_games.Location = new System.Drawing.Point(169, 26);
            this.txt_id_games.Name = "txt_id_games";
            this.txt_id_games.Size = new System.Drawing.Size(214, 26);
            this.txt_id_games.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Games Category :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Games ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_hapus);
            this.groupBox2.Controls.Add(this.btn_ubah);
            this.groupBox2.Controls.Add(this.btn_tambah);
            this.groupBox2.Location = new System.Drawing.Point(441, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 181);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hapus.Image = ((System.Drawing.Image)(resources.GetObject("btn_hapus.Image")));
            this.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hapus.Location = new System.Drawing.Point(11, 131);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(91, 44);
            this.btn_hapus.TabIndex = 2;
            this.btn_hapus.Text = "Delete";
            this.btn_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ubah.Image = ((System.Drawing.Image)(resources.GetObject("btn_ubah.Image")));
            this.btn_ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ubah.Location = new System.Drawing.Point(11, 76);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(91, 49);
            this.btn_ubah.TabIndex = 1;
            this.btn_ubah.Text = "Update";
            this.btn_ubah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tambah.Image = ((System.Drawing.Image)(resources.GetObject("btn_tambah.Image")));
            this.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tambah.Location = new System.Drawing.Point(11, 19);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(93, 50);
            this.btn_tambah.TabIndex = 0;
            this.btn_tambah.Text = "Add Data";
            this.btn_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_kembali);
            this.groupBox3.Controls.Add(this.cmb_cari);
            this.groupBox3.Controls.Add(this.btn_cari);
            this.groupBox3.Controls.Add(this.txt_cari);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(584, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 181);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kembali.Image = ((System.Drawing.Image)(resources.GetObject("btn_kembali.Image")));
            this.btn_kembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kembali.Location = new System.Drawing.Point(118, 124);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(98, 51);
            this.btn_kembali.TabIndex = 8;
            this.btn_kembali.Text = "Back";
            this.btn_kembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kembali.UseVisualStyleBackColor = false;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // cmb_cari
            // 
            this.cmb_cari.FormattingEnabled = true;
            this.cmb_cari.Items.AddRange(new object[] {
            "Games ID",
            "Games Category"});
            this.cmb_cari.Location = new System.Drawing.Point(35, 59);
            this.cmb_cari.Name = "cmb_cari";
            this.cmb_cari.Size = new System.Drawing.Size(161, 24);
            this.cmb_cari.TabIndex = 7;
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cari.Image = ((System.Drawing.Image)(resources.GetObject("btn_cari.Image")));
            this.btn_cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cari.Location = new System.Drawing.Point(16, 124);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(96, 51);
            this.btn_cari.TabIndex = 3;
            this.btn_cari.Text = "Search";
            this.btn_cari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cari.UseVisualStyleBackColor = false;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // txt_cari
            // 
            this.txt_cari.Location = new System.Drawing.Point(16, 89);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(200, 22);
            this.txt_cari.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Find Games";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_games);
            this.groupBox4.Location = new System.Drawing.Point(142, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(516, 229);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Games Data Table";
            // 
            // Frm_games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 453);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_games";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games Dataset";
            this.Load += new System.EventHandler(this.Frm_games_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_games)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_games;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_nama_games;
        private System.Windows.Forms.TextBox txt_id_games;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_cari;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}