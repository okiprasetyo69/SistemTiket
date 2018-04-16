namespace SistemTiket.view
{
    partial class Frm_tmbh_transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_tmbh_transaksi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_batal = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.txt_jumlah = new System.Windows.Forms.TextBox();
            this.txt_id_game = new System.Windows.Forms.TextBox();
            this.txt_id_pegawai = new System.Windows.Forms.TextBox();
            this.dtp_transaksi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id_transaksi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_id_transaksi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_jumlah);
            this.groupBox1.Controls.Add(this.txt_id_game);
            this.groupBox1.Controls.Add(this.txt_id_pegawai);
            this.groupBox1.Controls.Add(this.dtp_transaksi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_batal);
            this.groupBox2.Controls.Add(this.btn_simpan);
            this.groupBox2.Location = new System.Drawing.Point(53, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 73);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // btn_batal
            // 
            this.btn_batal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_batal.Image = ((System.Drawing.Image)(resources.GetObject("btn_batal.Image")));
            this.btn_batal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_batal.Location = new System.Drawing.Point(97, 19);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(78, 41);
            this.btn_batal.TabIndex = 1;
            this.btn_batal.Text = "Cancel";
            this.btn_batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_batal.UseVisualStyleBackColor = false;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_simpan.Image = ((System.Drawing.Image)(resources.GetObject("btn_simpan.Image")));
            this.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_simpan.Location = new System.Drawing.Point(16, 19);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 41);
            this.btn_simpan.TabIndex = 0;
            this.btn_simpan.Text = "Save";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // txt_jumlah
            // 
            this.txt_jumlah.Location = new System.Drawing.Point(129, 130);
            this.txt_jumlah.Name = "txt_jumlah";
            this.txt_jumlah.Size = new System.Drawing.Size(133, 20);
            this.txt_jumlah.TabIndex = 7;
            // 
            // txt_id_game
            // 
            this.txt_id_game.Location = new System.Drawing.Point(129, 104);
            this.txt_id_game.Name = "txt_id_game";
            this.txt_id_game.Size = new System.Drawing.Size(133, 20);
            this.txt_id_game.TabIndex = 6;
            // 
            // txt_id_pegawai
            // 
            this.txt_id_pegawai.Location = new System.Drawing.Point(129, 78);
            this.txt_id_pegawai.Name = "txt_id_pegawai";
            this.txt_id_pegawai.ReadOnly = true;
            this.txt_id_pegawai.Size = new System.Drawing.Size(133, 20);
            this.txt_id_pegawai.TabIndex = 5;
            // 
            // dtp_transaksi
            // 
            this.dtp_transaksi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_transaksi.Location = new System.Drawing.Point(129, 50);
            this.dtp_transaksi.Name = "dtp_transaksi";
            this.dtp_transaksi.Size = new System.Drawing.Size(133, 20);
            this.dtp_transaksi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Games ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Transaction ID :";
            // 
            // txt_id_transaksi
            // 
            this.txt_id_transaksi.Location = new System.Drawing.Point(129, 25);
            this.txt_id_transaksi.Name = "txt_id_transaksi";
            this.txt_id_transaksi.ReadOnly = true;
            this.txt_id_transaksi.Size = new System.Drawing.Size(133, 20);
            this.txt_id_transaksi.TabIndex = 10;
            // 
            // Frm_tmbh_transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(361, 302);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_tmbh_transaksi";
            this.Text = "Add Ticket";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.TextBox txt_jumlah;
        private System.Windows.Forms.TextBox txt_id_game;
        private System.Windows.Forms.TextBox txt_id_pegawai;
        private System.Windows.Forms.DateTimePicker dtp_transaksi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_transaksi;
        private System.Windows.Forms.Label label5;
    }
}