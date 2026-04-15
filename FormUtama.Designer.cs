namespace Manajemen_Distribusi_Buah
{
    partial class FormUtama
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
            this.btnpetani = new System.Windows.Forms.Button();
            this.btnlaporan = new System.Windows.Forms.Button();
            this.btnpanen = new System.Windows.Forms.Button();
            this.btnmitra = new System.Windows.Forms.Button();
            this.btndistribusi = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistem Informasi Manajemen Distribusi Buah";
            // 
            // btnpetani
            // 
            this.btnpetani.Location = new System.Drawing.Point(142, 210);
            this.btnpetani.Name = "btnpetani";
            this.btnpetani.Size = new System.Drawing.Size(120, 32);
            this.btnpetani.TabIndex = 1;
            this.btnpetani.Text = "Kelola Data Petani";
            this.btnpetani.UseVisualStyleBackColor = true;
            // 
            // btnlaporan
            // 
            this.btnlaporan.Location = new System.Drawing.Point(421, 297);
            this.btnlaporan.Name = "btnlaporan";
            this.btnlaporan.Size = new System.Drawing.Size(149, 32);
            this.btnlaporan.TabIndex = 2;
            this.btnlaporan.Text = "Laporan dan Rekap Besar";
            this.btnlaporan.UseVisualStyleBackColor = true;
            // 
            // btnpanen
            // 
            this.btnpanen.Location = new System.Drawing.Point(513, 210);
            this.btnpanen.Name = "btnpanen";
            this.btnpanen.Size = new System.Drawing.Size(120, 32);
            this.btnpanen.TabIndex = 3;
            this.btnpanen.Text = "Input Hasil Panen";
            this.btnpanen.UseVisualStyleBackColor = true;
            // 
            // btnmitra
            // 
            this.btnmitra.Location = new System.Drawing.Point(323, 210);
            this.btnmitra.Name = "btnmitra";
            this.btnmitra.Size = new System.Drawing.Size(120, 32);
            this.btnmitra.TabIndex = 4;
            this.btnmitra.Text = "Kelola Data Mitra";
            this.btnmitra.UseVisualStyleBackColor = true;
            // 
            // btndistribusi
            // 
            this.btndistribusi.Location = new System.Drawing.Point(212, 297);
            this.btndistribusi.Name = "btndistribusi";
            this.btndistribusi.Size = new System.Drawing.Size(149, 32);
            this.btndistribusi.TabIndex = 5;
            this.btndistribusi.Text = "Catat Transaksi Distribusi";
            this.btndistribusi.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Red;
            this.btnlogout.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnlogout.Location = new System.Drawing.Point(338, 394);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(96, 32);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selamat Datang Di Sistem Informasi Manajemen Distribusi Buah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apa Agenda Kita Hari Ini?";
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btndistribusi);
            this.Controls.Add(this.btnmitra);
            this.Controls.Add(this.btnpanen);
            this.Controls.Add(this.btnlaporan);
            this.Controls.Add(this.btnpetani);
            this.Controls.Add(this.label1);
            this.Name = "FormUtama";
            this.Text = "FormUtama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpetani;
        private System.Windows.Forms.Button btnlaporan;
        private System.Windows.Forms.Button btnpanen;
        private System.Windows.Forms.Button btnmitra;
        private System.Windows.Forms.Button btndistribusi;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}