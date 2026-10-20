using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_Perpus_Nama_Kelas
{

    //DONE SEMUA CRUDDD SUDAH DI TES FAHMI

    public partial class FormBuku : Form
    {
        string database = ("server = localhost; uid = root; database=db_perpustakaan_nazran_xirpl1; pwd='';");
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public FormBuku()
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
            string strQuery = "SELECT * FROM buku ";
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
            if (string.IsNullOrWhiteSpace(txtIsbn.Text)||
                string.IsNullOrWhiteSpace(txtJudul.Text)||
                string.IsNullOrWhiteSpace(txtPenerbit.Text)||
                string.IsNullOrWhiteSpace(txtPengarang.Text)||
                string.IsNullOrWhiteSpace(cmbKategori.Text)||
                string.IsNullOrWhiteSpace(nudStok.Text)||
                string.IsNullOrWhiteSpace(nudTahun.Text))

            {
                MessageBox.Show("Semua Kolom Wajib DIISII!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();

                txtIsbn.Clear();
                txtID.Clear();
                txtJudul.Clear();
                txtPenerbit.Clear();
                txtPengarang.Clear();
                cmbKategori.SelectedIndex = -1;
                nudTahun.Value = 2026;
                nudStok.Value = 1;
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
                    string strDelete = "DELETE FROM buku WHERE id_buku ='" + txtID.Text + "'";
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

        //UPDATE  //UPDATE  //UPDATE  //UPDATE  //UPDATE  //UPDATE  //UPDATE

        public void queryUpdate()
        {
            if (string.IsNullOrWhiteSpace(txtIsbn.Text) ||
                string.IsNullOrWhiteSpace(txtJudul.Text) ||
                string.IsNullOrWhiteSpace(txtPenerbit.Text) ||
                string.IsNullOrWhiteSpace(txtPengarang.Text) ||
                string.IsNullOrWhiteSpace(cmbKategori.Text) ||
                string.IsNullOrWhiteSpace(nudStok.Text) ||
                string.IsNullOrWhiteSpace(nudTahun.Text)||
                string.IsNullOrWhiteSpace(txtID.Text))

            {
                MessageBox.Show("Semua Kolom Wajib DIISII!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();
                string strUpdate = "UPDATE buku SET isbn = '" + txtIsbn.Text + "',judul = '" + txtJudul.Text + "',pengarang = '" + txtPengarang.Text + "',penerbit = '" + txtPenerbit.Text + "',tahun_terbit = '" + nudTahun.Value.ToString() + "',stok = '" + nudStok.Value.ToString() + "',id_kategori = '" + cmbKategori.SelectedValue + "' WHERE id_buku = '" + txtID.Text + "'";
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
            
            queryInsert("INSERT into buku Values (0,'" + txtIsbn.Text + "','" + txtJudul.Text + "','" + txtPengarang.Text + "','" +txtPenerbit.Text + "','" + nudTahun.Value.ToString() + "','"+nudStok.Value.ToString()+"','"+cmbKategori.SelectedValue+"')");
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
            txtIsbn.Clear();
            txtID.Clear();
            txtJudul.Clear();
            txtPenerbit.Clear();
            txtPengarang.Clear();
            cmbKategori.SelectedIndex = -1;
            nudTahun.Value = 2026;
            nudStok.Value = 0;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                txtID.Text = row.Cells["id_buku"].Value.ToString();
                txtIsbn.Text = row.Cells["isbn"].Value.ToString();
                txtJudul.Text = row.Cells["judul"].Value.ToString();
                txtPengarang.Text = row.Cells["pengarang"].Value.ToString();
                txtPenerbit.Text = row.Cells["penerbit"].Value.ToString();
                nudTahun.Value = Convert.ToInt32(row.Cells["tahun_terbit"].Value);
                nudStok.Value = Convert.ToInt32(row.Cells["stok"].Value);
                cmbKategori.SelectedValue = row.Cells["id_kategori"].Value.ToString();
            }
        }



        //HALOOOO SAYANGGG..inii cara nyambungin foreign keyy nyaa, pertamaa tamaa kamu harus pencet dulu form nyaa di bagian paling luarnya
        //sampee muncul form load kayakk dibawah inii ^_^
        private void FormBuku_Load(object sender, EventArgs e)
        {
            baca();

            string query = "SELECT id_kategori,nama_kategori FROM kategori"; //inii pilihh kolomm dan tabel yang mau kamuu sambunginn

            using (MySqlConnection conn = new MySqlConnection(database))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbKategori.DataSource = dt;
                    cmbKategori.DisplayMember = "nama_kategori"; 
                    cmbKategori.ValueMember = "id_kategori"; 

                    cmbKategori.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal konek ke database XAMPP: " + ex.Message, "Error Konek", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Search(string nama)
        {
            string strQuery = "SELECT * FROM buku WHERE judul LIKE '%" + nama + "%'";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(textBox1.Text);
        }
    }
}
