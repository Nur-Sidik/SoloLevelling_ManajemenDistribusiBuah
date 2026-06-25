using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO; // Wajib untuk MemoryStream Foto
using System.Windows.Forms;

namespace Manajemen_Distribusi_Buah
{
    public partial class FormBuah : Form
    {
        private BindingSource bindingSourceBuah = new BindingSource();
        private DataTable dtBuah = new DataTable();
        private readonly string connectionString = "Data Source=MSI\\UNKNOWNMEMBER;Initial Catalog=ManajemenBuah;Integrated Security=True";

        public FormBuah()
        {
            InitializeComponent();
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
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vw_Buah", conn);
                    dtBuah = new DataTable();
                    da.Fill(dtBuah);
                    dtBuah.Columns["ID"].AllowDBNull = true;

                    bindingSourceBuah.DataSource = dtBuah;
                    dgvbuah.DataSource = bindingSourceBuah;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data buah: " + ex.Message);
                }
            }
        }

        // --- HELPER FOTO ---
        private byte[] ImageToByteArray(Image img)
        {
            if (img == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] data)
        {
            if (data == null || data.Length == 0) return null;
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        // --- EVENT HANDLER ---
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pbFotoBuah.Image = Image.FromFile(opf.FileName);
                pbFotoBuah.SizeMode = PictureBoxSizeMode.Zoom;
            }
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

                    // Memasukkan Foto ke Database
                    byte[] fotoData = ImageToByteArray(pbFotoBuah.Image);
                    if (fotoData != null) cmd.Parameters.AddWithValue("@foto", fotoData);
                    else cmd.Parameters.Add("@foto", SqlDbType.VarBinary, -1).Value = DBNull.Value;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data buah berhasil ditambahkan!");
                    btnreset_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show("Error Simpan: " + ex.Message); }
            }
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            if (bindingSourceBuah.Current == null) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    DataRowView row = (DataRowView)bindingSourceBuah.Current;
                    int idBuah = Convert.ToInt32(row["ID"]);

                    SqlCommand cmd = new SqlCommand("sp_UpdateBuah", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", idBuah);
                    cmd.Parameters.AddWithValue("@nama", txtnama.Text);
                    cmd.Parameters.AddWithValue("@jenis", cmbjenis.Text);
                    cmd.Parameters.AddWithValue("@harga", decimal.Parse(txtharga.Text));

                    byte[] fotoData = ImageToByteArray(pbFotoBuah.Image);
                    if (fotoData != null) cmd.Parameters.AddWithValue("@foto", fotoData);
                    else cmd.Parameters.Add("@foto", SqlDbType.VarBinary, -1).Value = DBNull.Value;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data buah berhasil diperbarui!");
                    LoadData();
                }
                catch (Exception ex) { MessageBox.Show("Gagal Update: " + ex.Message); }
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (bindingSourceBuah.Current == null) return;
            DialogResult dr = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        DataRowView row = (DataRowView)bindingSourceBuah.Current;
                        int idBuah = Convert.ToInt32(row["ID"]);

                        SqlCommand cmd = new SqlCommand("sp_DeleteBuah", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", idBuah);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil dihapus!");
                        btnreset_Click(sender, e);
                    }
                    catch (Exception ex) { MessageBox.Show("Gagal Hapus: " + ex.Message); }
                }
            }
        }

        private void dgvbuah_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvbuah.Rows[e.RowIndex];
                txtnama.Text = row.Cells["Nama Buah"].Value.ToString();
                cmbjenis.Text = row.Cells["Jenis"].Value.ToString();
                txtharga.Text = row.Cells["Harga/Kg"].Value.ToString();

                // PENGAMANAN ANTI-CRASH: Cek apakah kolom Foto benar-benar ada di tabel
                if (dgvbuah.Columns.Contains("Foto") && row.Cells["Foto"].Value != DBNull.Value)
                {
                    pbFotoBuah.Image = ByteArrayToImage((byte[])row.Cells["Foto"].Value);
                    pbFotoBuah.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pbFotoBuah.Image = null; // Kosongkan jika tidak ada foto / kolom tidak ada
                }
            }
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_SearchBuah", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cari", txtcari.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    bindingSourceBuah.DataSource = dt;
                    dgvbuah.DataSource = bindingSourceBuah;
                }
                catch (Exception ex) { MessageBox.Show("Pencarian Gagal: " + ex.Message); }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtnama.Clear();
            txtcari.Clear();
            txtharga.Clear();
            cmbjenis.SelectedIndex = -1;
            pbFotoBuah.Image = null;
            LoadData();
        }

        // Kosongkan fungsi yang tidak perlu agar rapi
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtnama_TextChanged(object sender, EventArgs e) { }
        private void txtharga_TextChanged(object sender, EventArgs e) { }
        private void cmbjenis_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtcari_TextChanged(object sender, EventArgs e) { }
    }
}