using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Manajemen_Distribusi_Buah
{
    public partial class FormUtama : Form
    {
        private readonly string connectionString = "Data Source=MSI\\UNKNOWNMEMBER;Initial Catalog=ManajemenBuah;Integrated Security=True";

        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            LoadChartData();
        }

        // ==============================================================
        // FUNGSI UNTUK MENAMPILKAN GRAFIK DISTRIBUSI
        // ==============================================================
        private void LoadChartData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query untuk mengambil total distribusi per jenis buah
                    string query = @"
                        SELECT b.nama_buah, SUM(d.qty_kg) as TotalQty
                        FROM Distribusi d
                        JOIN Hasil_Panen hp ON d.id_panen = hp.id_panen
                        JOIN Buah b ON hp.id_buah = b.id_buah
                        GROUP BY b.nama_buah";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Bersihkan data grafik bawaan
                            chartDistribusi.Series.Clear();

                            // Buat Series baru (Bisa ubah 'Column' menjadi 'Pie' jika ingin grafik bundar)
                            Series series = new Series("Total Distribusi (Kg)");
                            series.ChartType = SeriesChartType.Column;
                            chartDistribusi.Series.Add(series);

                            // Masukkan data dari database ke dalam grafik
                            while (reader.Read())
                            {
                                string namaBuah = reader["nama_buah"].ToString();
                                double totalQty = Convert.ToDouble(reader["TotalQty"]);

                                chartDistribusi.Series["Total Distribusi (Kg)"].Points.AddXY(namaBuah, totalQty);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat grafik dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==============================================================
        // NAVIGASI TOMBOL
        // ==============================================================

        private void btnpetani_Click(object sender, EventArgs e)
        {
            FormPetani petani = new FormPetani();
            petani.ShowDialog();
        }

        private void btnmitra_Click(object sender, EventArgs e)
        {
            FormMitra mitra = new FormMitra();
            mitra.ShowDialog();
        }

        private void btnpanen_Click(object sender, EventArgs e)
        {
            FormPanen panen = new FormPanen();
            panen.ShowDialog();
        }

        private void btndistribusi_Click(object sender, EventArgs e)
        {
            FormDistribusi distribusi = new FormDistribusi();
            distribusi.ShowDialog();
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            FormLaporan laporan = new FormLaporan();
            laporan.ShowDialog();
        }

        private void btnbuah_Click(object sender, EventArgs e)
        {
            FormBuah fbuah = new FormBuah();
            fbuah.ShowDialog();
        }

        private void btnBuah_Click_1(object sender, EventArgs e)
        {
            FormBuah fbuah = new FormBuah();
            fbuah.ShowDialog();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }

        private void FormUtama_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Biarkan kosong, event klik pada grafik biasanya tidak diperlukan
        }
    }
}