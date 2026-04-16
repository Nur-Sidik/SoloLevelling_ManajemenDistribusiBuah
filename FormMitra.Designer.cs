namespace Manajemen_Distribusi_Buah
{
    partial class FormMitra
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
            this.dgvmitra = new System.Windows.Forms.DataGridView();
            this.btncari = new System.Windows.Forms.Button();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btntampilkan = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.txttelp = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmitra)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 62);
            this.label5.TabIndex = 29;
            this.label5.Text = "Selamat Datang Di Form Mitra!\r\n\r\n";
            // 
            // dgvmitra
            // 
            this.dgvmitra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmitra.Location = new System.Drawing.Point(446, 125);
            this.dgvmitra.Name = "dgvmitra";
            this.dgvmitra.Size = new System.Drawing.Size(308, 103);
            this.dgvmitra.TabIndex = 28;
            this.dgvmitra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMitra_CellClick);
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
            this.btntampilkan.Location = new System.Drawing.Point(362, 373);
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
            this.btnhapus.Location = new System.Drawing.Point(504, 296);
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
            this.btnubah.Location = new System.Drawing.Point(362, 296);
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
            this.btnsimpan.Location = new System.Drawing.Point(216, 296);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(109, 31);
            this.btnsimpan.TabIndex = 21;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txttelp
            // 
            this.txttelp.Location = new System.Drawing.Point(214, 203);
            this.txttelp.Multiline = true;
            this.txttelp.Name = "txttelp";
            this.txttelp.Size = new System.Drawing.Size(161, 20);
            this.txttelp.TabIndex = 20;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(214, 164);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(161, 20);
            this.txtnama.TabIndex = 19;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(214, 125);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(161, 20);
            this.txtid.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "No. Telp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nama Mitra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Mitra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Kategori";
            // 
            // cmbkategori
            // 
            this.cmbkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Items.AddRange(new object[] {
            "Hotel",
            "Resto",
            "RM",
            "UMKM"});
            this.cmbkategori.Location = new System.Drawing.Point(214, 243);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(161, 21);
            this.cmbkategori.TabIndex = 31;
            // 
            // FormMitra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvmitra);
            this.Controls.Add(this.btncari);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btntampilkan);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.txttelp);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMitra";
            this.Text = "FormMitra";
            this.Load += new System.EventHandler(this.FormMitra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmitra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvmitra;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntampilkan;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.TextBox txttelp;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbkategori;
    }
}