using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Manajemen_Distribusi_Buah
{
    public partial class FormPetani : Form
    {
        private BindingSource bindingSourcePetani = new BindingSource();
        private DataTable dtPetani = new DataTable();
        private readonly SqlConnection conn;
        private readonly string connectionString = "Data Source=MSI\\UNKNOWNMEMBER;Initial Catalog=ManajemenBuah;Integrated Security=True";

        public FormPetani()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPetani_Load(object sender, EventArgs e)
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
                    string query = "SELECT * FROM vw_Petani";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    bindingSourcePetani.DataSource = dt;
                    dgvpetani.DataSource = bindingSourcePetani;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtnama.Text == "" || txtalamat.Text == "")
            {
                MessageBox.Show("Nama dan Alamat tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Petani (nama_petani, alamat) VALUES (@nama, @alamat)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", txtnama.Text);
                        cmd.Parameters.AddWithValue("@alamat", txtalamat.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvPetani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvpetani.Rows[e.RowIndex];
                txtid.Text = row.Cells["ID"].Value.ToString();
                txtnama.Text = row.Cells["Nama Petani"].Value.ToString();
                txtalamat.Text = row.Cells["Alamat"].Value.ToString();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Pilih data yang akan diubah dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtnama.Text == "" || txtalamat.Text == "")
            {
                MessageBox.Show("Nama dan Alamat tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialog = MessageBox.Show("Apakah Anda yakin ingin mengubah data ini?", "Konfirmasi Ubah", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Petani SET nama_petani = @nama, alamat = @alamat WHERE id_petani = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nama", txtnama.Text);
                            cmd.Parameters.AddWithValue("@alamat", txtalamat.Text);
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
            if (txtid.Text == "")
            {
                MessageBox.Show("Pilih data yang akan dihapus dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialog = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Petani WHERE id_petani = @id";
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
                    string query = "SELECT id_petani AS 'ID', nama_petani AS 'Nama Petani', alamat AS 'Alamat' FROM Petani WHERE nama_petani LIKE @cari";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cari", "%" + txtcari.Text + "%");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvpetani.DataSource = dt;
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
