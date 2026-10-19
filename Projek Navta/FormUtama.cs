using System.Windows.Forms;

namespace Project_Perpus_Nama_Kelas
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
            label1.AutoSize = false;
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            label1.Left = (this.ClientSize.Width / label1.Width)/2;
        }


        private void mnuAnggota_Click(object sender, System.EventArgs e)
        {
            FormAnggota fr = new FormAnggota();
            fr.ShowDialog();
        }

        private void mnuKategori_Click(object sender, System.EventArgs e)
        {
            FormKategori fr = new FormKategori();
            fr.ShowDialog();
        }

        private void mnuBuku_Click(object sender, System.EventArgs e)
        {
            FormBuku fr = new FormBuku();
            fr.ShowDialog();
        }

        private void mnuPeminjaman_Click(object sender, System.EventArgs e)
        {
            FormPeminjaman fr = new FormPeminjaman();
            fr.ShowDialog();
        }

        private void mnuPengembalian_Click(object sender, System.EventArgs e)
        {
            FormPengembalian fr = new FormPengembalian();
            fr.ShowDialog();
        }
    }
}
