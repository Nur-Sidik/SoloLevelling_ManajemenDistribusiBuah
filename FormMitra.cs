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
    public partial class FormMitra : Form
    {

        private readonly SqlConnection conn;
        private readonly string connectionString = "Data Source=MSI\\UNKNOWNMEMBER;Initial Catalog=ManajemenBuah;Integrated Security=True";

        public FormMitra()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void FormMitra_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_mitra AS 'ID', nama_mitra AS 'Nama Mitra', no_mitra AS 'No. Mitra', kategori AS 'Kategori' FROM Mitra_Pembeli";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvmitra.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtnama.Text == "" || txttelp.Text == "" || cmbkategori.Text == "")
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Mitra_Pembeli (nama_mitra, no_mitra, kategori) VALUES (@nama, @no, @kategori)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", txtnama.Text);
                        cmd.Parameters.AddWithValue("@no", txttelp.Text);
                        cmd.Parameters.AddWithValue("@kategori", cmbkategori.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data Mitra berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error (Mungkin No Mitra sudah ada): " + ex.Message);
                }
            }
        }

        private void dgvMitra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvmitra.Rows[e.RowIndex];
                txtid.Text = row.Cells["ID"].Value.ToString();
                txtnama.Text = row.Cells["Nama Mitra"].Value.ToString();
                txttelp.Text = row.Cells["No. Mitra"].Value.ToString();
                cmbkategori.Text = row.Cells["Kategori"].Value.ToString();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Pilih data yang akan diubah dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialog = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Mitra_Pembeli SET nama_mitra = @nama, no_mitra = @no, kategori = @kategori WHERE id_mitra = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nama", txtnama.Text);
                            cmd.Parameters.AddWithValue("@no", txttelp.Text);
                            cmd.Parameters.AddWithValue("@kategori", cmbkategori.Text);
                            cmd.Parameters.AddWithValue("@id", txtid.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "") return;

            DialogResult dialog = MessageBox.Show("Apakah Anda yakin ingin menghapus mitra ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Mitra_Pembeli WHERE id_mitra = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", txtid.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_mitra AS 'ID', nama_mitra AS 'Nama Mitra', no_mitra AS 'No. Mitra', kategori AS 'Kategori' FROM Mitra_Pembeli WHERE nama_mitra LIKE @cari";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cari", "%" + txtcari.Text + "%");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvmitra.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
