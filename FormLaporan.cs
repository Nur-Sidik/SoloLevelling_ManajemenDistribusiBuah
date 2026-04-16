using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            HitungRingkasan();
            TampilRiwayatLengkap();
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
                    string query = @"SELECT d.tgl_distribusi AS 'Tanggal', 
                                            p.nama_petani AS 'Asal Petani',
                                            hp.jenis_buah AS 'Jenis Buah', 
                                            m.nama_mitra AS 'Tujuan Mitra',
                                            d.qty_kg AS 'Jumlah (Kg)'
                                     FROM Distribusi d
                                     JOIN Hasil_Panen hp ON d.id_panen = hp.id_panen
                                     JOIN Petani p ON hp.id_petani = p.id_petani
                                     JOIN Mitra_Pembeli m ON d.id_mitra = m.id_mitra
                                     ORDER BY d.tgl_distribusi DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvlaporan.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat riwayat: " + ex.Message);
                }
            }
        }
    }
}
