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
    public partial class FormBuah : Form
    {
        private BindingSource bindingSourceBuah = new BindingSource();
        private DataTable dtBuah = new DataTable();
        private readonly SqlConnection conn;
        private readonly string connectionString = "Data Source=MSI\\UNKNOWNMEMBER;Initial Catalog=ManajemenBuah;Integrated Security=True";

        public FormBuah()
        {
            conn = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncari_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Memanggil Stored Procedure untuk pencarian
                    SqlCommand cmd = new SqlCommand("sp_SearchBuah", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parameter '@cari' harus sama dengan yang ada di SQL Server
                    cmd.Parameters.AddWithValue("@cari", txtcari.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Tampilkan hasil ke DataGridView melalui BindingSource
                    bindingSourceBuah.DataSource = dt;
                    dgvbuah.DataSource = bindingSourceBuah;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Data buah tidak ditemukan.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pencarian Gagal: " + ex.Message);
                }
            }
        }

        private void FormBuah_Load(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = bindingSourceBuah;
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Memanggil VIEW untuk keamanan sesuai instruksi dosen
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vw_Buah", conn);
                    dtBuah = new DataTable();
                    da.Fill(dtBuah);

                    // Hubungkan data ke BindingSource agar navigator berfungsi
                    bindingSourceBuah.DataSource = dtBuah;
                    dgvbuah.DataSource = bindingSourceBuah;

                    BindControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data buah: " + ex.Message);
                }
            }
        }

        private void BindControls()
        {
            txtnama.DataBindings.Clear();
            cmbjenis.DataBindings.Clear();
            txtharga.DataBindings.Clear();

            txtnama.DataBindings.Add("Text", bindingSourceBuah, "Nama Buah");
            cmbjenis.DataBindings.Add("Text", bindingSourceBuah, "Jenis");
            txtharga.DataBindings.Add("Text", bindingSourceBuah, "Harga/Kg");
        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbjenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertBuah", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nama", txtnama.Text);
                    cmd.Parameters.AddWithValue("@jenis", cmbjenis.Text);
                    cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtharga.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data buah berhasil ditambahkan!");
                    LoadData();
                }
                catch (Exception ex) { MessageBox.Show("Error Simpan: " + ex.Message); }
            }
        }


    
}
