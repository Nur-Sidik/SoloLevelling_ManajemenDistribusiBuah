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


        }
    }
}
