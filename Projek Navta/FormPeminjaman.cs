using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

//DONE : Semua CRUD Sudah DI TES

namespace Project_Perpus_Nama_Kelas
{

   
    public partial class FormPeminjaman : Form
    {
        string database = ("server = localhost; uid = root; database=db_perpustakaan_nazran_xirpl1; pwd='';");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;

        public FormPeminjaman()
        {
            InitializeComponent();
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

        //BACAAA

        public DataTable baca()
        {
            string strQuery = "SELECT * FROM peminjaman ";
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

        public DataTable baca2()
        {
            string strQuery = "SELECT * FROM detail_peminjaman ";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(strQuery, koneksi);
                adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
                dgvDetail.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            disconek();
            return dt;
        }

        public DataTable baca3()
        {
            string strQuery = "SELECT * FROM buku ";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(strQuery, koneksi);
                adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
                dgvBuku.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            disconek();
            return dt;
        }

        //INSERTT

        public void queryInsert(string query)
        {
            koneksi = new MySqlConnection(database);
            if (string.IsNullOrWhiteSpace(txtKodeTransaksi.Text) ||
                string.IsNullOrWhiteSpace(cmbStatus.Text) ||
                string.IsNullOrWhiteSpace(cmbAnggota.Text))
            {
                MessageBox.Show("Semua Kolom Wajib DIISII!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();

                txtKodeTransaksi.Clear();
                txtID.Clear();
                cmbAnggota.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;

                LoadComboBoxData();
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
                baca2();
                baca3();
            }
        }


        public void queryInsertDetailPeminjaman(string query)
        {
            koneksi = new MySqlConnection(database);
            if (string.IsNullOrWhiteSpace(cmbJudul.Text)||
                string.IsNullOrWhiteSpace(cmbIDPeminjaman.Text)||
                 string.IsNullOrWhiteSpace(nudJumlah.Text))
            {
                MessageBox.Show("Semua Kolom Wajib DIISII!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();

                txtKodeTransaksi.Clear();
                txtID.Clear();
                cmbAnggota.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;

                LoadComboBoxData() ;
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
                baca2();
                baca3();
            }
        }


        //DELETEEE

        public void queryDelete()
        {

            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus pesan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            if (pesan == DialogResult.Yes)
            {
                try
                {
                    koneksi = new MySqlConnection(database);
                    koneksi.Open();
                    string strDelete = "DELETE FROM peminjaman WHERE id_peminjaman ='" + txtID.Text + "'";
                    cmd = new MySqlCommand(strDelete, koneksi);
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    txtID.Clear();
                    txtKodeTransaksi.Clear();
                    cmbStatus.SelectedIndex = -1;
                    cmbAnggota.SelectedIndex = -1;

                    LoadComboBoxData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Delete Sukses", "Konfirmasi");
                    baca();
                    baca2();
                    baca3();
                }
            }
        }


        //DELETEEE

        public void queryDeleteDetailPeminjaman()
        {

            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus pesan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            if (pesan == DialogResult.Yes)
            {
                try
                {
                    koneksi = new MySqlConnection(database);
                    koneksi.Open();
                    string strDelete = "DELETE FROM detail_peminjaman WHERE id_detail ='" + txtIDDetail.Text + "'";
                    cmd = new MySqlCommand(strDelete, koneksi);
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    txtID.Clear();
                    txtKodeTransaksi.Clear();
                    cmbStatus.SelectedIndex = -1;
                    cmbAnggota.SelectedIndex = -1;

                    LoadComboBoxData() ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Delete Sukses", "Konfirmasi");
                    baca();
                    baca2();
                    baca3();
                }
            }
        }

        //UPDATE

        public void queryUpdate()
        {
            if (string.IsNullOrWhiteSpace(txtKodeTransaksi.Text) ||
                string.IsNullOrWhiteSpace(cmbAnggota.Text) ||
                string.IsNullOrWhiteSpace(cmbStatus.Text) ||
                string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Semua Kolom (Name,Address,Photo) Wajib DIISII!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();
                string strUpdate = "UPDATE peminjaman SET kode_transaksi = '" + txtKodeTransaksi.Text + "', id_anggota = '" + cmbAnggota.Text + "', tanggal_pinjam = '" + dtpPinjam.Value.ToString("yyyy-MM-dd") + "', tanggal_jatuh_tempo = '" + dtpJatuhTempo.Value.ToString("yyyy-MM-dd") + "', status = '" +cmbStatus.Text+ "' WHERE id_peminjaman = '" + txtID.Text + "'";
                cmd = new MySqlCommand(strUpdate, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Update Sukses", "Informasi", MessageBoxButtons.OK);
                LoadComboBoxData();
                txtID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baca();
                baca2();
                baca3();
            }
        }

        //UPDATE

        public void queryUpdateDetailPeminjaman()
        {
            if (string.IsNullOrWhiteSpace(cmbJudul.Text) ||
                string.IsNullOrWhiteSpace(cmbIDPeminjaman.Text) ||
                string.IsNullOrWhiteSpace(txtIDDetail.Text)||
                string.IsNullOrWhiteSpace(nudJumlah.Text))
            {
                MessageBox.Show("Semua Kolom Wajib DIISII!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();
                string strUpdate = "UPDATE detail_peminjaman SET id_peminjaman = '" + cmbIDPeminjaman.Text + "', id_buku = '" + cmbJudul.Text + "', jumlah = '" + nudJumlah.Value.ToString() + "' WHERE id_detail = '" + txtIDDetail.Text + "'";
                cmd = new MySqlCommand(strUpdate, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Update Sukses", "Informasi", MessageBoxButtons.OK);
                LoadComboBoxData();
                txtIDDetail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baca();
                baca2();
                baca3();
            }
        }

        private void FormPeminjaman_Load(object sender, System.EventArgs e)
        {
            baca();
            baca2();
            baca3();

            LoadComboBoxData();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            queryInsert("INSERT into peminjaman Values (0,'" + txtKodeTransaksi.Text + "','" + cmbAnggota.Text + "','"+dtpPinjam.Value.ToString("yyyy-MM-dd")+"','"+dtpJatuhTempo.Value.ToString("yyyy-MM-dd")+ "','" + cmbStatus.Text+ "')");
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
            txtKodeTransaksi.Clear();
            cmbStatus.SelectedIndex = -1;
            cmbAnggota.SelectedIndex = -1;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                txtID.Text = row.Cells["id_peminjaman"].Value.ToString();
                txtKodeTransaksi.Text = row.Cells["kode_transaksi"].Value.ToString();
                cmbAnggota.Text = row.Cells["id_anggota"].Value.ToString();
                dtpPinjam.Text = row.Cells["tanggal_pinjam"].Value.ToString();
                dtpJatuhTempo.Text = row.Cells["tanggal_jatuh_tempo"].Value.ToString();
                cmbStatus.Text = row.Cells["status"].Value.ToString();
            }
        }

        private void lblJudul_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAnggota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxData()
        {
            // --- 1. LOAD COMBOBOX ANGGOTA ---
            cmbAnggota.DataSource = null;
            cmbAnggota.Items.Clear();
            baca();
            baca2();
            baca3();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(database))
                {
                    conn.Open();
                    string query = "SELECT id_anggota, nama FROM anggota";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dtAnggota = new DataTable();
                    da.Fill(dtAnggota);

                    cmbAnggota.DataSource = dtAnggota;
                    cmbAnggota.DisplayMember = "id_anggota";     // Kolom yang tampil
                    cmbAnggota.ValueMember = "id_anggota"; // ID di baliknya
                    cmbAnggota.SelectedIndex = -1;         // Biar kosong/tidak otomatis milih baris pertama
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Anggota: " + ex.Message);
            }

            // --- 2. LOAD COMBOBOX BUKU ---
            cmbJudul.DataSource = null;
            cmbJudul.Items.Clear();
            baca();
            baca2();
            baca3();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(database))
                {
                    conn.Open();
                    string query = "SELECT id_buku, judul FROM buku";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dtBuku = new DataTable();
                    da.Fill(dtBuku);

                    cmbJudul.DataSource = dtBuku;
                    cmbJudul.DisplayMember = "id_buku";     // Kolom yang tampil
                    cmbJudul.ValueMember = "id_buku";     // ID di baliknya
                    cmbJudul.SelectedIndex = -1;          // Biar kosong dulu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Buku: " + ex.Message);
            }


            // --- 3. LOAD COMBOBOX PEMINJAMAN ---
            cmbIDPeminjaman.DataSource = null;
            cmbIDPeminjaman.Items.Clear();
            baca();
            baca2();
            baca3();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(database))
                {
                    conn.Open();
                    string query = "SELECT id_peminjaman FROM peminjaman";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dtBuku = new DataTable();
                    da.Fill(dtBuku);

                    cmbIDPeminjaman.DataSource = dtBuku;
                    cmbIDPeminjaman.DisplayMember = "id_peminjaman";     // Kolom yang tampil
                    cmbIDPeminjaman.ValueMember = "id_peminjaman";     // ID di baliknya
                    cmbIDPeminjaman.SelectedIndex = -1;          // Biar kosong dulu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Buku: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queryInsertDetailPeminjaman("INSERT into detail_peminjaman values (0,'" + cmbIDPeminjaman.Text + "','" + cmbJudul.Text + "','" + nudJumlah.Value.ToString() + "')");
        }

        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            queryDeleteDetailPeminjaman();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            queryUpdateDetailPeminjaman();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtIDDetail.Clear();
            cmbJudul.SelectedIndex = -1;
            cmbIDPeminjaman.SelectedIndex = -1;
            nudJumlah.Value = 0;
        }

        private void lblJatuhTempo_Click(object sender, EventArgs e)
        {

        }

        public void Search(string nama)
        {
            string strQuery = "SELECT * FROM peminjaman WHERE id_anggota LIKE '%" + nama + "%'";
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
            finally
            {
                disconek();
            }
        }

        public void SearchIdPeminjaman(string nama)
        {
            string strQuery = "SELECT * FROM detail_peminjaman WHERE id_peminjaman LIKE '%" + nama + "%'";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(strQuery, koneksi);
                adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
                dgvDetail.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                disconek();
            }
        }

        public void SearchBuku(string nama)
        {
            string strQuery = "SELECT * FROM buku WHERE judul LIKE '%" + nama + "%'";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(strQuery, koneksi);
                adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
                dgvBuku.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                disconek();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchIdPeminjaman(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SearchBuku(textBox3.Text);
        }
    }
}
