using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


//DONEEEEEE //DONEEEEEE//DONEEEEEE//DONEEEEEE//DONEEEEEE//DONEEEEEE

namespace Project_Perpus_Nama_Kelas
{
    public partial class FormPengembalian : Form
    {
        string database = ("server = localhost; uid = root; database=db_perpustakaan_nazran_xirpl1; pwd='';");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public FormPengembalian()
        {
            InitializeComponent();
        }

        private void txtNama_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void lblKembali_Click(object sender, System.EventArgs e)
        {

        }

        private void lblDenda_Click(object sender, System.EventArgs e)
        {

        }

        private void cmbPeminjaman_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public bool konek()
        {
            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal terhubung ke database mysql!\n\nDetail Error: " + ex.Message,
                                "Koneksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void disconek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Close();
        }

        private void FormPengembalian_Load(object sender, EventArgs e)
        {
            baca();
            string query = "SELECT id_peminjaman FROM peminjaman";

            using (MySqlConnection conn = new MySqlConnection(database))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbTransaksi.DataSource = dt;
                    cmbTransaksi.DisplayMember = "id_peminjaman";
                    cmbTransaksi.ValueMember = "id_peminjaman";

                    cmbTransaksi.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal konek ke database XAMPP: " + ex.Message, "Error Konek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //BACAAA //BACAAA //BACAAA //BACAAA //BACAAA //BACAAA //BACAAA

        public DataTable baca()
        {
            string strQuery = "SELECT * FROM pengembalian ";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(strQuery, koneksi);
                adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            disconek();
            return dt;
        }

        //INSERTT  //INSERTT  //INSERTT  //INSERTT  //INSERTT  //INSERTT

        public void queryInsert(string query)
        {
            koneksi = new MySqlConnection(database);
            if (string.IsNullOrWhiteSpace(cmbTransaksi.Text) ||
                string.IsNullOrWhiteSpace(dtpJatuhTempo.Text) ||
                string.IsNullOrWhiteSpace(dtpKembali.Text))
            {
                MessageBox.Show("Semua Kolom Wajib DIISII!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();

                txtID.Clear();
                cmbTransaksi.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
                MessageBox.Show("INSERT Data Berhasil");
                baca();
            }
        }

        //DELETEEE //DELETEEE //DELETEEE //DELETEEE //DELETEEE //DELETEEE

        public void queryDelete()
        {

            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus pesan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            if (pesan == DialogResult.Yes)
            {
                try
                {
                    koneksi = new MySqlConnection(database);
                    koneksi.Open();
                    string strDelete = "DELETE FROM pengembalian WHERE id_pengembalian ='" + txtID.Text + "'";
                    cmd = new MySqlCommand(strDelete, koneksi);
                    cmd.ExecuteNonQuery();
                    koneksi.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Delete Sukses", "Konfirmasi");
                    baca();
                }
            }
        }

        //UPDATE  //UPDATE  //UPDATE  //UPDATE  //UPDATE  //UPDATE  //UPDATE

        public void queryUpdate()
        {
            if (string.IsNullOrWhiteSpace(cmbTransaksi.Text) ||
                string.IsNullOrWhiteSpace(dtpJatuhTempo.Text) ||
                string.IsNullOrWhiteSpace(dtpKembali.Text)||
                string.IsNullOrWhiteSpace(txtID.Text))

            {
                MessageBox.Show("Semua Kolom Wajib DIISII!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();
                string strUpdate = "UPDATE pengembalian SET id_peminjaman  = '" + txtID.Text + "',tanggal_kembali = '" + dtpKembali.Value.ToString("yyyy-MM-dd") +  "',denda = '" + txtDenda.Text + "' WHERE id_pengembalian = '" + txtID.Text + "'";
                cmd = new MySqlCommand(strUpdate, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Update Sukses", "Informasi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baca();
            }
        }

        private void cmbTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTransaksi.SelectedIndex != -1 && cmbTransaksi.SelectedItem is DataRowView row)
            {
                int idPeminjaman = Convert.ToInt32(row["id_peminjaman"]);

                string query = "SELECT tanggal_jatuh_tempo FROM peminjaman WHERE id_peminjaman = @id";

                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=db_perpustakaan_nazran_xirpl1;uid=root;pwd="))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idPeminjaman);
                        try
                        {
                            conn.Open();
                            object result = cmd.ExecuteScalar();

                            if (result != null && result != DBNull.Value)
                            {
                                // Otomatis isi tanggal jatuh tempo ke DateTimePicker
                                dtpJatuhTempo.Value = Convert.ToDateTime(result);
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


        // 5. Rumus Perhitungan Denda Otomatis
        private void HitungDendaOtomatis(DateTime jatuhTempo)
        {
            int tarifDendaPerHari = 1000; // Tentukan tarif denda per hari (misal Rp 1.000)

            // Tanggal pengembalian adalah tanggal hari ini (dari DateTimePicker pengembalian)
            DateTime tanggalKembali = dtpKembali.Value.Date;

            // Hitung selisih hari
            TimeSpan selisih = tanggalKembali - jatuhTempo.Date;
            int hariTerlambat = selisih.Days;

            int totalDenda = 0;

            // Jika hari terlambat lebih dari 0 (artinya telat)
            if (hariTerlambat > 0)
            {
                totalDenda = hariTerlambat * tarifDendaPerHari;
            }

            // Tampilkan hasil denda ke TextBox
            txtDenda.Text = totalDenda.ToString();
        }

       

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            queryInsert("INSERT into pengembalian values (0,'" + cmbTransaksi.Text + "','" + dtpKembali.Value.ToString("yyyy-MM-dd") + "','" + txtDenda.Text + "')");
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            queryUpdate();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            queryDelete();
        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            cmbTransaksi.SelectedIndex = -1;
            txtDenda.Clear();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                txtID.Text = row.Cells["id_pengembalian"].Value.ToString();
                txtDenda.Text = row.Cells["denda"].Value.ToString();
                cmbTransaksi.Text = row.Cells["id_peminjaman"].Value.ToString();
                dtpKembali.Text = row.Cells["tanggal_kembali"].Value.ToString();
            }
        }

        private void btnHitungDenda_Click(object sender, EventArgs e)
        {
            // Validasi: Pastikan petugas sudah memilih transaksi di ComboBox
            if (cmbTransaksi.SelectedIndex == -1)
            {
                MessageBox.Show("Silakan pilih transaksi peminjaman terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tarifDendaPerHari = 1000; // Tentukan tarif denda per hari (misal Rp 1.000)

            DateTime jatuhTempo = dtpJatuhTempo.Value.Date;
            DateTime tanggalKembali = dtpKembali.Value.Date;

            // Hitung selisih hari
            TimeSpan selisih = tanggalKembali - jatuhTempo;
            int hariTerlambat = selisih.Days;

            int totalDenda = 0;

            // Jika telat lebih dari 0 hari
            if (hariTerlambat > 0)
            {
                totalDenda = hariTerlambat * tarifDendaPerHari;
            }

            // Masukkan hasil ke TextBox Denda
            txtDenda.Text = totalDenda.ToString();
        }
    }
}
