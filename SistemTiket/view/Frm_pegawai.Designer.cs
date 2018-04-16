namespace SistemTiket.view
{
    partial class Frm_pegawai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_pegawai));
            this.dgv_pegawai = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.txt_passwords = new System.Windows.Forms.TextBox();
            this.txt_nama_pegawai = new System.Windows.Forms.TextBox();
            this.txt_id_pegawai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.cmb_cari = new System.Windows.Forms.ComboBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pegawai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_pegawai
            // 
            this.dgv_pegawai.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_pegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pegawai.Location = new System.Drawing.Point(18, 17);
            this.dgv_pegawai.Name = "dgv_pegawai";
            this.dgv_pegawai.ReadOnly = true;
            this.dgv_pegawai.Size = new System.Drawing.Size(592, 210);
            this.dgv_pegawai.TabIndex = 1;
            this.dgv_pegawai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_pegawai_KeyUp);
            this.dgv_pegawai.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_pegawai_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_status);
            this.groupBox1.Controls.Add(this.txt_passwords);
            this.groupBox1.Controls.Add(this.txt_nama_pegawai);
            this.groupBox1.Controls.Add(this.txt_id_pegawai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(98, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Kasir",
            "Supervisior"});
            this.cmb_status.Location = new System.Drawing.Point(133, 113);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(121, 26);
            this.cmb_status.TabIndex = 8;
            // 
            // txt_passwords
            // 
            this.txt_passwords.Location = new System.Drawing.Point(133, 150);
            this.txt_passwords.Name = "txt_passwords";
            this.txt_passwords.Size = new System.Drawing.Size(213, 26);
            this.txt_passwords.TabIndex = 7;
            // 
            // txt_nama_pegawai
            // 
            this.txt_nama_pegawai.Location = new System.Drawing.Point(133, 74);
            this.txt_nama_pegawai.Name = "txt_nama_pegawai";
            this.txt_nama_pegawai.Size = new System.Drawing.Size(213, 26);
            this.txt_nama_pegawai.TabIndex = 4;
            // 
            // txt_id_pegawai
            // 
            this.txt_id_pegawai.Location = new System.Drawing.Point(133, 37);
            this.txt_id_pegawai.Name = "txt_id_pegawai";
            this.txt_id_pegawai.Size = new System.Drawing.Size(213, 26);
            this.txt_id_pegawai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_ubah);
            this.groupBox2.Controls.Add(this.btn_tambah);
            this.groupBox2.Location = new System.Drawing.Point(460, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 193);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(16, 134);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 46);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ubah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ubah.Image = ((System.Drawing.Image)(resources.GetObject("btn_ubah.Image")));
            this.btn_ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ubah.Location = new System.Drawing.Point(16, 80);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(91, 43);
            this.btn_ubah.TabIndex = 1;
            this.btn_ubah.Text = "Update";
            this.btn_ubah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_tambah.Image = ((System.Drawing.Image)(resources.GetObject("btn_tambah.Image")));
            this.btn_tambah.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_tambah.Location = new System.Drawing.Point(16, 26);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(91, 41);
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
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(591, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 193);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kembali.Image = ((System.Drawing.Image)(resources.GetObject("btn_kembali.Image")));
            this.btn_kembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kembali.Location = new System.Drawing.Point(126, 118);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(103, 59);
            this.btn_kembali.TabIndex = 11;
            this.btn_kembali.Text = "Back";
            this.btn_kembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kembali.UseVisualStyleBackColor = false;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // cmb_cari
            // 
            this.cmb_cari.FormattingEnabled = true;
            this.cmb_cari.Items.AddRange(new object[] {
            "Employee ID",
            "User Name"});
            this.cmb_cari.Location = new System.Drawing.Point(59, 50);
            this.cmb_cari.Name = "cmb_cari";
            this.cmb_cari.Size = new System.Drawing.Size(121, 23);
            this.cmb_cari.TabIndex = 10;
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cari.Image = ((System.Drawing.Image)(resources.GetObject("btn_cari.Image")));
            this.btn_cari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cari.Location = new System.Drawing.Point(8, 117);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(105, 59);
            this.btn_cari.TabIndex = 3;
            this.btn_cari.Text = "Search";
            this.btn_cari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cari.UseVisualStyleBackColor = false;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // txt_cari
            // 
            this.txt_cari.Location = new System.Drawing.Point(24, 85);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(196, 23);
            this.txt_cari.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Find Employee :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Password :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_pegawai);
            this.groupBox4.Location = new System.Drawing.Point(129, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(627, 238);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Employee Data Table";
            // 
            // Frm_pegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 449);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_pegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dataset";
            this.Load += new System.EventHandler(this.Frm_pegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pegawai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pegawai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nama_pegawai;
        private System.Windows.Forms.TextBox txt_id_pegawai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.TextBox txt_passwords;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_cari;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;

    }
}