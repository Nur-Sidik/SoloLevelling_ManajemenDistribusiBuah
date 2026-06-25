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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpetani = new System.Windows.Forms.Button();
            this.btnlaporan = new System.Windows.Forms.Button();
            this.btnpanen = new System.Windows.Forms.Button();
            this.btnmitra = new System.Windows.Forms.Button();
            this.btndistribusi = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuah = new System.Windows.Forms.Button();
            this.chartDistribusi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistribusi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistem Informasi Manajemen Distribusi Buah";
            // 
            // btnpetani
            // 
            this.btnpetani.Location = new System.Drawing.Point(166, 160);
            this.btnpetani.Name = "btnpetani";
            this.btnpetani.Size = new System.Drawing.Size(120, 32);
            this.btnpetani.TabIndex = 1;
            this.btnpetani.Text = "Kelola Data Petani";
            this.btnpetani.UseVisualStyleBackColor = true;
            this.btnpetani.Click += new System.EventHandler(this.btnpetani_Click);
            // 
            // btnlaporan
            // 
            this.btnlaporan.Location = new System.Drawing.Point(167, 258);
            this.btnlaporan.Name = "btnlaporan";
            this.btnlaporan.Size = new System.Drawing.Size(149, 32);
            this.btnlaporan.TabIndex = 2;
            this.btnlaporan.Text = "Laporan dan Rekap Besar";
            this.btnlaporan.UseVisualStyleBackColor = true;
            this.btnlaporan.Click += new System.EventHandler(this.btnlaporan_Click);
            // 
            // btnpanen
            // 
            this.btnpanen.Location = new System.Drawing.Point(166, 209);
            this.btnpanen.Name = "btnpanen";
            this.btnpanen.Size = new System.Drawing.Size(120, 32);
            this.btnpanen.TabIndex = 3;
            this.btnpanen.Text = "Input Hasil Panen";
            this.btnpanen.UseVisualStyleBackColor = true;
            this.btnpanen.Click += new System.EventHandler(this.btnpanen_Click);
            // 
            // btnmitra
            // 
            this.btnmitra.Location = new System.Drawing.Point(30, 160);
            this.btnmitra.Name = "btnmitra";
            this.btnmitra.Size = new System.Drawing.Size(120, 32);
            this.btnmitra.TabIndex = 4;
            this.btnmitra.Text = "Kelola Data Mitra";
            this.btnmitra.UseVisualStyleBackColor = true;
            this.btnmitra.Click += new System.EventHandler(this.btnmitra_Click);
            // 
            // btndistribusi
            // 
            this.btndistribusi.Location = new System.Drawing.Point(12, 258);
            this.btndistribusi.Name = "btndistribusi";
            this.btndistribusi.Size = new System.Drawing.Size(149, 32);
            this.btndistribusi.TabIndex = 5;
            this.btndistribusi.Text = "Catat Transaksi Distribusi";
            this.btndistribusi.UseVisualStyleBackColor = true;
            this.btndistribusi.Click += new System.EventHandler(this.btndistribusi_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Red;
            this.btnlogout.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnlogout.Location = new System.Drawing.Point(110, 327);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(96, 32);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selamat Datang Di Sistem Informasi Manajemen Distribusi Buah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apa Agenda Kita Hari Ini?";
            // 
            // btnBuah
            // 
            this.btnBuah.Location = new System.Drawing.Point(30, 209);
            this.btnBuah.Name = "btnBuah";
            this.btnBuah.Size = new System.Drawing.Size(120, 32);
            this.btnBuah.TabIndex = 9;
            this.btnBuah.Text = "Kelola Buah";
            this.btnBuah.UseVisualStyleBackColor = true;
            this.btnBuah.Click += new System.EventHandler(this.btnBuah_Click_1);
            // 
            // chartDistribusi
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDistribusi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDistribusi.Legends.Add(legend1);
            this.chartDistribusi.Location = new System.Drawing.Point(344, 179);
            this.chartDistribusi.Name = "chartDistribusi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDistribusi.Series.Add(series1);
            this.chartDistribusi.Size = new System.Drawing.Size(444, 259);
            this.chartDistribusi.TabIndex = 10;
            this.chartDistribusi.Text = "chart1";
            this.chartDistribusi.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartDistribusi);
            this.Controls.Add(this.btnBuah);
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
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.Click += new System.EventHandler(this.FormUtama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDistribusi)).EndInit();
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
        private System.Windows.Forms.Button btnBuah;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistribusi;
    }
}