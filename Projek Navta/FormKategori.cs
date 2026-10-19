using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_Perpus_Nama_Kelas
{


    //SUDAH DI TES FAHMI
    public partial class FormKategori : Form
    {
        string database = ("server = localhost; uid = root; database=db_perpustakaan_nazran_xirpl1; pwd='';");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public FormKategori()
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

        //BACAAA //BACAAA //BACAAA //BACAAA //BACAAA //BACAAA //BACAAA

        public DataTable baca()
        {
            string strQuery = "SELECT * FROM kategori ";
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
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Semua Kolom Wajib DIISII!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();

                txtNama.Clear();
                txtID.Clear();
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
                    string strDelete = "DELETE FROM kategori WHERE id_kategori ='" + txtID.Text + "'";
                    cmd = new MySqlCommand(strDelete, koneksi);
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    txtID.Clear() ;
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
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Semua Kolom (Name,Address,Photo) Wajib DIISII!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();
                string strUpdate = "UPDATE kategori SET nama_kategori = '" + txtNama.Text + "' WHERE id_kategori = '" + txtID.Text + "'";
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            queryInsert("INSERT into kategori VALUES (0,'" + txtNama.Text + "')");
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
            txtNama.Clear();
            txtID.Clear();

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                txtID.Text = row.Cells["id_kategori"].Value.ToString();
                txtNama.Text = row.Cells["nama_kategori"].Value.ToString();
            }
        }

        private void FormKategori_Load(object sender, EventArgs e)
        {
            baca();
        }
    }
}
