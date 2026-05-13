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


}
