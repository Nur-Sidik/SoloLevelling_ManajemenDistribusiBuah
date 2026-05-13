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
    }
}
