using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


//DONE : Semua CRUD Sudah DI TES FAHMI

namespace Project_Perpus_Nama_Kelas
{
    public partial class FormAnggota : Form
    {
        string database = ("server = localhost; uid = root; database=db_perpustakaan_nazran_xirpl1; pwd='';");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public FormAnggota()
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
            string strQuery = "SELECT * FROM anggota ";
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

        //INSERTT

        public void queryInsert(string query)
        {
            koneksi = new MySqlConnection(database);
            if (string.IsNullOrWhiteSpace(txtKode.Text) ||
                string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtTelepon.Text)||
                string.IsNullOrWhiteSpace(dtpDaftar.Text) ||
                string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                MessageBox.Show("Semua Kolom Wajib DIISII!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();

                txtKode.Clear();
                txtNama.Clear();
                txtTelepon.Clear();
                txtAlamat.Clear();
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
                    string strDelete = "DELETE FROM anggota WHERE id_anggota ='" + txtID.Text + "'";
                    cmd = new MySqlCommand(strDelete, koneksi);
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    txtID.Clear();
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

        //UPDATE

        public void queryUpdate()
        {
            if (string.IsNullOrWhiteSpace(txtKode.Text) ||
                string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtTelepon.Text) ||
                string.IsNullOrWhiteSpace(dtpDaftar.Text) ||
                string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                MessageBox.Show("Semua Kolom (Name,Address,Photo) Wajib DIISII!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();
                string strUpdate = "UPDATE anggota SET kode_anggota = '" + txtKode.Text + "', nama = '" + txtNama.Text + "', alamat = '" + txtAlamat.Text + "', no_telepon = '" + txtTelepon.Text + "',tanggal_daftar = '" + dtpDaftar.Value.ToString("yyyy-MM-dd") +"' WHERE id_anggota = '" + txtID.Text + "'";
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

        private void btnSimpan_Click(object sender, System.EventArgs e)
        {
            queryInsert("INSERT INTO anggota Values (0,'" + txtKode.Text + "','" + txtNama.Text + "','"+txtAlamat.Text+"','"+txtTelepon.Text+"','" + dtpDaftar.Value.ToString("yyyy-MM-dd") + "')");
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            queryUpdate();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            queryDelete();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                txtID.Text = row.Cells["id_anggota"].Value.ToString();
                txtKode.Text = row.Cells["kode_anggota"].Value.ToString();
                txtNama.Text = row.Cells["nama"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value.ToString();
                txtTelepon.Text = row.Cells["no_telepon"].Value.ToString();
                dtpDaftar.Text = row.Cells["tanggal_daftar"].Value.ToString();
            }
        }

        private void FormAnggota_Load(object sender, EventArgs e)
        {
            baca();
        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            txtKode.Clear();
            txtNama.Clear();
            txtTelepon.Clear();
            txtAlamat.Clear();
            txtID.Clear();
        }
    }
}
