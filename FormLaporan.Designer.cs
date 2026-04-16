namespace Manajemen_Distribusi_Buah
{
    partial class FormLaporan
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
            this.lbltotaldistribusi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvlaporan = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.lbltotalpesanan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbljumlah = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotaldistribusi
            // 
            this.lbltotaldistribusi.AutoSize = true;
            this.lbltotaldistribusi.Location = new System.Drawing.Point(332, 173);
            this.lbltotaldistribusi.Name = "lbltotaldistribusi";
            this.lbltotaldistribusi.Size = new System.Drawing.Size(13, 13);
            this.lbltotaldistribusi.TabIndex = 67;
            this.lbltotaldistribusi.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 62);
            this.label5.TabIndex = 66;
            this.label5.Text = "Selamat Datang Di Form Laporan!\r\n\r\n";
            // 
            // dgvlaporan
            // 
            this.dgvlaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlaporan.Location = new System.Drawing.Point(132, 252);
            this.dgvlaporan.Name = "dgvlaporan";
            this.dgvlaporan.Size = new System.Drawing.Size(569, 157);
            this.dgvlaporan.TabIndex = 65;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnrefresh.Location = new System.Drawing.Point(355, 206);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(109, 31);
            this.btnrefresh.TabIndex = 58;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            // 
            // lbltotalpesanan
            // 
            this.lbltotalpesanan.AutoSize = true;
            this.lbltotalpesanan.Location = new System.Drawing.Point(332, 112);
            this.lbltotalpesanan.Name = "lbltotalpesanan";
            this.lbltotalpesanan.Size = new System.Drawing.Size(13, 13);
            this.lbltotalpesanan.TabIndex = 54;
            this.lbltotalpesanan.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Total Buah Dipanen (Kg)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Total Buah Di Distribusikan (Kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Jumlah Transaksi";
            // 
            // lbljumlah
            // 
            this.lbljumlah.AutoSize = true;
            this.lbljumlah.Location = new System.Drawing.Point(635, 112);
            this.lbljumlah.Name = "lbljumlah";
            this.lbljumlah.Size = new System.Drawing.Size(13, 13);
            this.lbljumlah.TabIndex = 71;
            this.lbljumlah.Text = "0";
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbljumlah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltotaldistribusi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvlaporan);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.lbltotalpesanan);
            this.Name = "FormLaporan";
            this.Text = "FormLaporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltotaldistribusi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvlaporan;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label lbltotalpesanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbljumlah;
    }
}