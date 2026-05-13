using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manajemen_Distribusi_Buah
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {

        }

        private void btnpetani_Click(object sender, EventArgs e)
        {
            FormPetani petani = new FormPetani();
            petani.ShowDialog();
        }

        private void btnmitra_Click(object sender, EventArgs e)
        {
            FormMitra mitra = new FormMitra();
            mitra.ShowDialog();
        }

        private void btnpanen_Click(object sender, EventArgs e)
        {
            FormPanen panen = new FormPanen();
            panen.ShowDialog();
        }

        private void btndistribusi_Click(object sender, EventArgs e)
        {
            FormDistribusi distribusi = new FormDistribusi();
            distribusi.ShowDialog();
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            FormLaporan laporan = new FormLaporan();
            laporan.ShowDialog();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btnbuah_Click(object sender, EventArgs e)
        {
            FormBuah fbuah = new FormBuah();
            fbuah.ShowDialog();
        }

        private void FormUtama_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
