namespace Manajemen_Distribusi_Buah
{
    partial class FormPanen
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvpanen = new System.Windows.Forms.DataGridView();
            this.btncari = new System.Windows.Forms.Button();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btntampilkan = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.txtbuah = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbpetani = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtppanen = new System.Windows.Forms.DateTimePicker();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpanen)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 31);
            this.label5.TabIndex = 29;
            this.label5.Text = "Selamat Datang Di Form Panen!\r\n";
            // 
            // dgvpanen
            // 
            this.dgvpanen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpanen.Location = new System.Drawing.Point(446, 125);
            this.dgvpanen.Name = "dgvpanen";
            this.dgvpanen.Size = new System.Drawing.Size(308, 103);
            this.dgvpanen.TabIndex = 28;
            this.dgvpanen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPanen_CellClick);
            // 
            // btncari
            // 
            this.btncari.Location = new System.Drawing.Point(698, 80);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(56, 20);
            this.btncari.TabIndex = 27;
            this.btncari.Text = "Search";
            this.btncari.UseVisualStyleBackColor = true;
            this.btncari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtcari
            // 
            this.txtcari.Location = new System.Drawing.Point(518, 79);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(148, 20);
            this.txtcari.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cari Nama";
            // 
            // btntampilkan
            // 
            this.btntampilkan.BackColor = System.Drawing.Color.Yellow;
            this.btntampilkan.Location = new System.Drawing.Point(359, 397);
            this.btntampilkan.Name = "btntampilkan";
            this.btntampilkan.Size = new System.Drawing.Size(109, 31);
            this.btntampilkan.TabIndex = 24;
            this.btntampilkan.Text = "Tampilkan Data";
            this.btntampilkan.UseVisualStyleBackColor = false;
            this.btntampilkan.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.Red;
            this.btnhapus.Location = new System.Drawing.Point(501, 320);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(109, 31);
            this.btnhapus.TabIndex = 23;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnubah
            // 
            this.btnubah.BackColor = System.Drawing.Color.Silver;
            this.btnubah.Location = new System.Drawing.Point(359, 320);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(109, 31);
            this.btnubah.TabIndex = 22;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = false;
            this.btnubah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.Lime;
            this.btnsimpan.Location = new System.Drawing.Point(213, 320);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(109, 31);
            this.btnsimpan.TabIndex = 21;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtbuah
            // 
            this.txtbuah.Location = new System.Drawing.Point(211, 189);
            this.txtbuah.Multiline = true;
            this.txtbuah.Name = "txtbuah";
            this.txtbuah.Size = new System.Drawing.Size(161, 20);
            this.txtbuah.TabIndex = 20;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(211, 111);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(161, 20);
            this.txtid.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID Buah";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nama Petani";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Panen";
            // 
            // cmbpetani
            // 
            this.cmbpetani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpetani.FormattingEnabled = true;
            this.cmbpetani.Location = new System.Drawing.Point(213, 150);
            this.cmbpetani.Name = "cmbpetani";
            this.cmbpetani.Size = new System.Drawing.Size(161, 21);
            this.cmbpetani.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tanggal Panen";
            // 
            // dtppanen
            // 
            this.dtppanen.Location = new System.Drawing.Point(219, 237);
            this.dtppanen.Name = "dtppanen";
            this.dtppanen.Size = new System.Drawing.Size(149, 20);
            this.dtppanen.TabIndex = 32;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(213, 274);
            this.txtstok.Multiline = true;
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(161, 20);
            this.txtstok.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Stok Tersisa";
            // 
            // FormPanen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtppanen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbpetani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvpanen);
            this.Controls.Add(this.btncari);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btntampilkan);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.txtbuah);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPanen";
            this.Text = "FormPanen";
            this.Load += new System.EventHandler(this.FormPanen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpanen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvpanen;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntampilkan;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.TextBox txtbuah;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbpetani;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtppanen;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.Label label7;
    }
}