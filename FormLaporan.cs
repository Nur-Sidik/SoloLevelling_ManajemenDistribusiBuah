using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Manajemen_Distribusi_Buah
{
    public partial class FormLaporan : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString = "Data Source=MSI\\UNKNOWNMEMBER;Initial Catalog=ManajemenBuah;Integrated Security=True";

        public FormLaporan()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            HitungRingkasan();
            TampilRiwayatLengkap();

            // PENGAMANAN: Mencegah aplikasi crash jika Crystal Report belum terhubung sempurna
            try
            {
                LaporanDistribusi rpt = new LaporanDistribusi();
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                // Cuma kasih tau pesan, tapi form tidak akan mati (GridView tetap aman)
                MessageBox.Show("Report Viewer belum siap, namun data tabel berhasil dimuat.\nInfo detail: " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HitungRingkasan();
            TampilRiwayatLengkap();
            MessageBox.Show("Laporan telah diperbarui!", "Informasi");
        }

        private void HitungRingkasan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT SUM(stok_tersisa) FROM Hasil_Panen", conn);
                    object result1 = cmd1.ExecuteScalar();
                    lbltotalpesanan.Text = (result1 != DBNull.Value ? result1.ToString() : "0") + " Kg";

                    SqlCommand cmd2 = new SqlCommand("SELECT SUM(qty_kg) FROM Distribusi", conn);
                    object result2 = cmd2.ExecuteScalar();
                    lbltotaldistribusi.Text = (result2 != DBNull.Value ? result2.ToString() : "0") + " Kg";

                    SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Distribusi", conn);
                    int totalData = (int)cmd3.ExecuteScalar();
                    lbljumlah.Text = totalData.ToString() + " Transaksi";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghitung ringkasan: " + ex.Message);
                }
            }
        }

        private void TampilRiwayatLengkap()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM vw_Distribusi ORDER BY Tanggal DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvlaporan.DataSource = dt;
                }
                catch (Exception ex) { MessageBox.Show("Gagal memuat riwayat: " + ex.Message); }
            }
        }

        private void label2_Click(object sender, EventArgs e) { }
    }
}