using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manajemen_Distribusi_Buah
{
    public partial class FormDistribusi : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString = "Data Source=MSI\\UNKNOWNMEMBER;Initial Catalog=ManajemenBuah;Integrated Security=True";

        public FormDistribusi()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormDistribusi_Load(object sender, EventArgs e)
        {
            LoadComboPanen();
            LoadComboMitra();
            LoadData();
        }

        private void LoadComboPanen()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_panen, jenis_buah + ' (Sisa: ' + CAST(stok_tersisa AS VARCHAR) + ' kg)' AS info FROM Hasil_Panen WHERE stok_tersisa > 0";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbpanen.DataSource = dt;
                    cmbpanen.DisplayMember = "info";
                    cmbpanen.ValueMember = "id_panen";
                    cmbpanen.SelectedIndex = -1;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void LoadComboMitra()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT id_mitra, nama_mitra FROM Mitra_Pembeli", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbmitra.DataSource = dt;
                    cmbmitra.DisplayMember = "nama_mitra";
                    cmbmitra.ValueMember = "id_mitra";
                    cmbmitra.SelectedIndex = -1;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT d.id_distribusi AS 'ID', p.jenis_buah AS 'Buah', m.nama_mitra AS 'Mitra', 
                                     d.tgl_distribusi AS 'Tanggal', d.qty_kg AS 'Qty (Kg)'
                                     FROM Distribusi d
                                     JOIN Hasil_Panen p ON d.id_panen = p.id_panen
                                     JOIN Mitra_Pembeli m ON d.id_mitra = m.id_mitra";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvdistribusi.DataSource = dt;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbpanen.SelectedValue == null || cmbmitra.SelectedValue == null || txtqty.Text == "")
            {
                MessageBox.Show("Lengkapi data!"); return;
            }

            double qtyInput = Convert.ToDouble(txtqty.Text);
            int idPanen = (int)cmbpanen.SelectedValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmdCek = new SqlCommand("SELECT stok_tersisa FROM Hasil_Panen WHERE id_panen = @id", conn);
                    cmdCek.Parameters.AddWithValue("@id", idPanen);
                    double stokSkrg = Convert.ToDouble(cmdCek.ExecuteScalar());

                    if (qtyInput > stokSkrg)
                    {
                        MessageBox.Show("Gagal! Stok tidak mencukupi. Stok tersedia: " + stokSkrg + " kg", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    string qInsert = "INSERT INTO Distribusi (id_panen, id_mitra, tgl_distribusi, qty_kg) VALUES (@idp, @idm, @tgl, @qty)";
                    SqlCommand cmdIns = new SqlCommand(qInsert, conn);
                    cmdIns.Parameters.AddWithValue("@idp", idPanen);
                    cmdIns.Parameters.AddWithValue("@idm", cmbmitra.SelectedValue);
                    cmdIns.Parameters.AddWithValue("@tgl", dtpdistribusi.Value);
                    cmdIns.Parameters.AddWithValue("@qty", qtyInput);
                    cmdIns.ExecuteNonQuery();

                    string qUpdate = "UPDATE Hasil_Panen SET stok_tersisa = stok_tersisa - @qty WHERE id_panen = @idp";
                    SqlCommand cmdUpd = new SqlCommand(qUpdate, conn);
                    cmdUpd.Parameters.AddWithValue("@qty", qtyInput);
                    cmdUpd.Parameters.AddWithValue("@idp", idPanen);
                    cmdUpd.ExecuteNonQuery();

                    MessageBox.Show("Distribusi Berhasil! Stok sudah terpotong otomatis.", "Sukses");
                    txtqty.Clear();
                    LoadComboPanen();
                    LoadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if (dgvdistribusi.CurrentRow == null)
            {
                MessageBox.Show("Pilih transaksi di tabel dulu!"); return;
            }

            string id = dgvdistribusi.CurrentRow.Cells["ID"].Value.ToString();
            string buah = dgvdistribusi.CurrentRow.Cells["Buah"].Value.ToString();
            string mitra = dgvdistribusi.CurrentRow.Cells["Mitra"].Value.ToString();
            string tgl = dgvdistribusi.CurrentRow.Cells["Tanggal"].Value.ToString();
            string qty = dgvdistribusi.CurrentRow.Cells["Qty (Kg)"].Value.ToString();

            string nota = "======== NOTA DISTRIBUSI BUAH ========\n\n" +
                          "ID Transaksi : " + id + "\n" +
                          "Tanggal      : " + tgl + "\n" +
                          "Mitra Tujuan : " + mitra + "\n" +
                          "--------------------------------------\n" +
                          "Jenis Buah   : " + buah + "\n" +
                          "Jumlah Kirim : " + qty + " kg\n" +
                          "--------------------------------------\n" +
                          "Status       : LUNAS / TERKIRIM\n\n" +
                          "Terima kasih atas kerjasamanya!";

            MessageBox.Show(nota, "Invoice #" + id, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTampil_Click(object sender, EventArgs e) { LoadData(); }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            
        }
    }
}
