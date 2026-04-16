namespace Manajemen_Distribusi_Buah
{
    partial class FormDistribusi
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvdistribusi = new System.Windows.Forms.DataGridView();
            this.btncari = new System.Windows.Forms.Button();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btntampilkan = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbpanen = new System.Windows.Forms.ComboBox();
            this.cmbmitra = new System.Windows.Forms.ComboBox();
            this.dtpdistribusi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdistribusi)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Jumlah (Kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 62);
            this.label5.TabIndex = 46;
            this.label5.Text = "Selamat Datang Di Form Distribusi!\r\n\r\n";
            // 
            // dgvdistribusi
            // 
            this.dgvdistribusi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdistribusi.Location = new System.Drawing.Point(446, 125);
            this.dgvdistribusi.Name = "dgvdistribusi";
            this.dgvdistribusi.Size = new System.Drawing.Size(308, 103);
            this.dgvdistribusi.TabIndex = 45;
            // 
            // btncari
            // 
            this.btncari.Location = new System.Drawing.Point(698, 80);
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(56, 20);
            this.btncari.TabIndex = 44;
            this.btncari.Text = "Search";
            this.btncari.UseVisualStyleBackColor = true;
            // 
            // txtcari
            // 
            this.txtcari.Location = new System.Drawing.Point(518, 79);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(148, 20);
            this.txtcari.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cari Nama";
            // 
            // btntampilkan
            // 
            this.btntampilkan.BackColor = System.Drawing.Color.Yellow;
            this.btntampilkan.Location = new System.Drawing.Point(367, 407);
            this.btntampilkan.Name = "btntampilkan";
            this.btntampilkan.Size = new System.Drawing.Size(109, 31);
            this.btntampilkan.TabIndex = 41;
            this.btntampilkan.Text = "Tampilkan Data";
            this.btntampilkan.UseVisualStyleBackColor = false;
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.Red;
            this.btnhapus.Location = new System.Drawing.Point(509, 330);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(109, 31);
            this.btnhapus.TabIndex = 40;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            // 
            // btnubah
            // 
            this.btnubah.BackColor = System.Drawing.Color.Silver;
            this.btnubah.Location = new System.Drawing.Point(367, 330);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(109, 31);
            this.btnubah.TabIndex = 39;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = false;
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.Lime;
            this.btnsimpan.Location = new System.Drawing.Point(221, 330);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(109, 31);
            this.btnsimpan.TabIndex = 38;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(214, 125);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(161, 20);
            this.txtid.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Pilih Mitra";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Pilih Buah/Stok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID Distribusi";
            // 
            // cmbpanen
            // 
            this.cmbpanen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpanen.FormattingEnabled = true;
            this.cmbpanen.Location = new System.Drawing.Point(216, 164);
            this.cmbpanen.Name = "cmbpanen";
            this.cmbpanen.Size = new System.Drawing.Size(159, 21);
            this.cmbpanen.TabIndex = 49;
            // 
            // cmbmitra
            // 
            this.cmbmitra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmitra.FormattingEnabled = true;
            this.cmbmitra.Location = new System.Drawing.Point(216, 206);
            this.cmbmitra.Name = "cmbmitra";
            this.cmbmitra.Size = new System.Drawing.Size(159, 21);
            this.cmbmitra.TabIndex = 50;
            // 
            // dtpdistribusi
            // 
            this.dtpdistribusi.Location = new System.Drawing.Point(223, 245);
            this.dtpdistribusi.Name = "dtpdistribusi";
            this.dtpdistribusi.Size = new System.Drawing.Size(149, 20);
            this.dtpdistribusi.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Tanggal Kirim";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(214, 289);
            this.txtqty.Name = "txtqty";
            this.txtqty.ReadOnly = true;
            this.txtqty.Size = new System.Drawing.Size(161, 20);
            this.txtqty.TabIndex = 53;
            // 
            // FormDistribusi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.dtpdistribusi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbmitra);
            this.Controls.Add(this.cmbpanen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvdistribusi);
            this.Controls.Add(this.btncari);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btntampilkan);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDistribusi";
            this.Text = "FormDistribusi";
            this.Load += new System.EventHandler(this.FormDistribusi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdistribusi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvdistribusi;
        private System.Windows.Forms.Button btncari;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntampilkan;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbpanen;
        private System.Windows.Forms.ComboBox cmbmitra;
        private System.Windows.Forms.DateTimePicker dtpdistribusi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtqty;
    }
}