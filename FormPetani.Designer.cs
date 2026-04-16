namespace Manajemen_Distribusi_Buah
{
    partial class FormPetani
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btntampilkan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.btncari = new System.Windows.Forms.Button();
            this.dgvpetani = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpetani)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Petani";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Petani";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(197, 111);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(161, 20);
            this.txtid.TabIndex = 3;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(197, 150);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(161, 20);
            this.txtnama.TabIndex = 4;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(197, 189);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(161, 20);
            this.txtalamat.TabIndex = 5;
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.Lime;
            this.btnsimpan.Location = new System.Drawing.Point(199, 282);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(109, 31);
            this.btnsimpan.TabIndex = 6;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnubah
            // 
            this.btnubah.BackColor = System.Drawing.Color.Silver;
            this.btnubah.Location = new System.Drawing.Point(345, 282);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(109, 31);
            this.btnubah.TabIndex = 7;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = false;
            this.btnubah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.Red;
            this.btnhapus.Location = new System.Drawing.Point(487, 282);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(109, 31);
            this.btnhapus.TabIndex = 8;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btntampilkan
            // 
            this.btntampilkan.BackColor = System.Drawing.Color.Yellow;
            this.btntampilkan.Location = new System.Drawing.Point(345, 359);
            this.btntampilkan.Name = "btntampilkan";
            this.btntampilkan.Size = new System.Drawing.Size(109, 31);
            this.btntampilkan.TabIndex = 9;
            this.btntampilkan.Text = "Tampilkan Data";
            this.btntampilkan.UseVisualStyleBackColor = false;
            this.btntampilkan.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cari Nama";
            // 
            // txtcari
            // 
            this.txtcari.Location = new System.Drawing.Point(501, 65);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(148, 20);
            this.txtcari.TabIndex = 11;
            // 
            // btncari
            // 
            this.btncari.Location = new System.Drawing.Point(681, 66);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(56, 20);
            this.btncari.TabIndex = 12;
            this.btncari.Text = "Search";
            this.btncari.UseVisualStyleBackColor = true;
            this.btncari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // dgvpetani
            // 
            this.dgvpetani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpetani.Location = new System.Drawing.Point(429, 111);
            this.dgvpetani.Name = "dgvpetani";
            this.dgvpetani.Size = new System.Drawing.Size(308, 103);
            this.dgvpetani.TabIndex = 13;
            this.dgvpetani.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPetani_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Selamat Datang Di Form Petani!\r\n";
            // 
            // FormPetani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvpetani);
            this.Controls.Add(this.btncari);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btntampilkan);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPetani";
            this.Text = "FormPetani";
            this.Load += new System.EventHandler(this.FormPetani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpetani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btntampilkan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.DataGridView dgvpetani;
        private System.Windows.Forms.Label label5;
    }
}