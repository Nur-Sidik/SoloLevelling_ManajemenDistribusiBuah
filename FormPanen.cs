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
    public partial class FormPanen : Form
    {

        private readonly SqlConnection conn;
        private readonly string connectionString = "Data Source=MSI\\UNKNOWNMEMBER;Initial Catalog=ManajemenBuah;Integrated Security=True";

        public FormPanen()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void FormPanen_Load(object sender, EventArgs e)
        {
            LoadComboBoxPetani(); 
            LoadData();
        }

        private void LoadComboBoxPetani()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_petani, nama_petani FROM Petani";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            cmbpetani.DataSource = dt;
                            cmbpetani.DisplayMember = "nama_petani";
                            cmbpetani.ValueMember = "id_petani"; 
                            cmbpetani.SelectedIndex = -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data petani: " + ex.Message);
                }
            }
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
                    string query = @"SELECT hp.id_panen AS 'ID', 
                                            p.nama_petani AS 'Nama Petani', 
                                            hp.jenis_buah AS 'Jenis Buah', 
                                            hp.tgl_panen AS 'Tanggal Panen', 
                                            hp.stok_tersisa AS 'Stok (Kg)' 
                                     FROM Hasil_Panen hp 
                                     JOIN Petani p ON hp.id_petani = p.id_petani";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dgvpanen.DataSource = dt;
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
            if (cmbpetani.SelectedValue == null || txtbuah.Text == "" || txtstok.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Hasil_Panen (id_petani, jenis_buah, tgl_panen, stok_tersisa) VALUES (@id_petani, @jenis, @tgl, @stok)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_petani", cmbpetani.SelectedValue);
                        cmd.Parameters.AddWithValue("@jenis", txtbuah.Text);
                        cmd.Parameters.AddWithValue("@tgl", dtppanen.Value.Date);
                        cmd.Parameters.AddWithValue("@stok", Convert.ToDouble(txtstok.Text));

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data Hasil Panen berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Pastikan stok diisi dengan angka! Detail: " + ex.Message);
                }
            }
        }

       
        }
    }
}
