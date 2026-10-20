using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Perpus_Nama_Kelas
{
    partial class FormPeminjaman
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlJudul = new System.Windows.Forms.Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.grpHeader = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblKodeTransaksi = new System.Windows.Forms.Label();
            this.txtKodeTransaksi = new System.Windows.Forms.TextBox();
            this.lblAnggota = new System.Windows.Forms.Label();
            this.cmbAnggota = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPinjam = new System.Windows.Forms.Label();
            this.dtpPinjam = new System.Windows.Forms.DateTimePicker();
            this.lblJatuhTempo = new System.Windows.Forms.Label();
            this.dtpJatuhTempo = new System.Windows.Forms.DateTimePicker();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBersih = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Detail = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDDetail = new System.Windows.Forms.TextBox();
            this.cmbJudul = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbIDPeminjaman = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pnlJudul.SuspendLayout();
            this.grpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlJudul
            // 
            this.pnlJudul.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlJudul.Controls.Add(this.lblJudul);
            this.pnlJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlJudul.Location = new System.Drawing.Point(0, 0);
            this.pnlJudul.Name = "pnlJudul";
            this.pnlJudul.Size = new System.Drawing.Size(1082, 60);
            this.pnlJudul.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(20, 14);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(204, 45);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Peminjaman";
            this.lblJudul.Click += new System.EventHandler(this.lblJudul_Click);
            // 
            // grpHeader
            // 
            this.grpHeader.Controls.Add(this.label2);
            this.grpHeader.Controls.Add(this.textBox1);
            this.grpHeader.Controls.Add(this.label1);
            this.grpHeader.Controls.Add(this.txtID);
            this.grpHeader.Controls.Add(this.cmbStatus);
            this.grpHeader.Controls.Add(this.lblKodeTransaksi);
            this.grpHeader.Controls.Add(this.txtKodeTransaksi);
            this.grpHeader.Controls.Add(this.lblAnggota);
            this.grpHeader.Controls.Add(this.cmbAnggota);
            this.grpHeader.Controls.Add(this.lblStatus);
            this.grpHeader.Controls.Add(this.lblPinjam);
            this.grpHeader.Controls.Add(this.dtpPinjam);
            this.grpHeader.Controls.Add(this.lblJatuhTempo);
            this.grpHeader.Controls.Add(this.dtpJatuhTempo);
            this.grpHeader.Location = new System.Drawing.Point(20, 75);
            this.grpHeader.Name = "grpHeader";
            this.grpHeader.Size = new System.Drawing.Size(840, 216);
            this.grpHeader.TabIndex = 2;
            this.grpHeader.TabStop = false;
            this.grpHeader.Text = "Data Transaksi";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Dipinjam",
            "Selesai"});
            this.cmbStatus.Location = new System.Drawing.Point(152, 150);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(250, 36);
            this.cmbStatus.TabIndex = 13;
            // 
            // lblKodeTransaksi
            // 
            this.lblKodeTransaksi.AutoSize = true;
            this.lblKodeTransaksi.Location = new System.Drawing.Point(17, 70);
            this.lblKodeTransaksi.Name = "lblKodeTransaksi";
            this.lblKodeTransaksi.Size = new System.Drawing.Size(139, 28);
            this.lblKodeTransaksi.TabIndex = 3;
            this.lblKodeTransaksi.Text = "Kode transaksi";
            // 
            // txtKodeTransaksi
            // 
            this.txtKodeTransaksi.Location = new System.Drawing.Point(152, 67);
            this.txtKodeTransaksi.Name = "txtKodeTransaksi";
            this.txtKodeTransaksi.Size = new System.Drawing.Size(250, 34);
            this.txtKodeTransaksi.TabIndex = 4;
            // 
            // lblAnggota
            // 
            this.lblAnggota.AutoSize = true;
            this.lblAnggota.Location = new System.Drawing.Point(17, 110);
            this.lblAnggota.Name = "lblAnggota";
            this.lblAnggota.Size = new System.Drawing.Size(89, 28);
            this.lblAnggota.TabIndex = 5;
            this.lblAnggota.Text = "Anggota";
            // 
            // cmbAnggota
            // 
            this.cmbAnggota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnggota.FormattingEnabled = true;
            this.cmbAnggota.Location = new System.Drawing.Point(152, 107);
            this.cmbAnggota.Name = "cmbAnggota";
            this.cmbAnggota.Size = new System.Drawing.Size(250, 36);
            this.cmbAnggota.TabIndex = 6;
            this.cmbAnggota.SelectedIndexChanged += new System.EventHandler(this.cmbAnggota_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 28);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // lblPinjam
            // 
            this.lblPinjam.AutoSize = true;
            this.lblPinjam.Location = new System.Drawing.Point(457, 36);
            this.lblPinjam.Name = "lblPinjam";
            this.lblPinjam.Size = new System.Drawing.Size(145, 28);
            this.lblPinjam.TabIndex = 9;
            this.lblPinjam.Text = "Tanggal pinjam";
            // 
            // dtpPinjam
            // 
            this.dtpPinjam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPinjam.Location = new System.Drawing.Point(607, 33);
            this.dtpPinjam.Name = "dtpPinjam";
            this.dtpPinjam.Size = new System.Drawing.Size(160, 34);
            this.dtpPinjam.TabIndex = 10;
            // 
            // lblJatuhTempo
            // 
            this.lblJatuhTempo.AutoSize = true;
            this.lblJatuhTempo.Location = new System.Drawing.Point(468, 79);
            this.lblJatuhTempo.Name = "lblJatuhTempo";
            this.lblJatuhTempo.Size = new System.Drawing.Size(121, 28);
            this.lblJatuhTempo.TabIndex = 11;
            this.lblJatuhTempo.Text = "Jatuh tempo";
            this.lblJatuhTempo.Click += new System.EventHandler(this.lblJatuhTempo_Click);
            // 
            // dtpJatuhTempo
            // 
            this.dtpJatuhTempo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJatuhTempo.Location = new System.Drawing.Point(607, 73);
            this.dtpJatuhTempo.Name = "dtpJatuhTempo";
            this.dtpJatuhTempo.Size = new System.Drawing.Size(160, 34);
            this.dtpJatuhTempo.TabIndex = 12;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(308, 432);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(105, 34);
            this.btnSimpan.TabIndex = 21;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Location = new System.Drawing.Point(428, 432);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(105, 34);
            this.btnUbah.TabIndex = 22;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(548, 432);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(105, 34);
            this.btnHapus.TabIndex = 23;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBersih
            // 
            this.btnBersih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnBersih.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBersih.FlatAppearance.BorderSize = 0;
            this.btnBersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBersih.ForeColor = System.Drawing.Color.White;
            this.btnBersih.Location = new System.Drawing.Point(668, 432);
            this.btnBersih.Name = "btnBersih";
            this.btnBersih.Size = new System.Drawing.Size(105, 34);
            this.btnBersih.TabIndex = 24;
            this.btnBersih.Text = "Bersih";
            this.btnBersih.UseVisualStyleBackColor = false;
            this.btnBersih.Click += new System.EventHandler(this.btnBersih_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv.ColumnHeadersHeight = 34;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(20, 275);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1015, 138);
            this.dgv.TabIndex = 26;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Detail);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.dgvBuku);
            this.groupBox2.Controls.Add(this.dgvDetail);
            this.groupBox2.Controls.Add(this.nudJumlah);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtIDDetail);
            this.groupBox2.Controls.Add(this.cmbJudul);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbIDPeminjaman);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(20, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1050, 334);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Peminjaman";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(288, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(523, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 28);
            this.label12.TabIndex = 30;
            this.label12.Text = "Buku Yang Tersedia";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(408, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 34);
            this.button2.TabIndex = 28;
            this.button2.Text = "Ubah";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Detail
            // 
            this.Detail.AutoSize = true;
            this.Detail.Location = new System.Drawing.Point(3, 89);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(63, 28);
            this.Detail.TabIndex = 29;
            this.Detail.Text = "Detail";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(528, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 29;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(648, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 34);
            this.button4.TabIndex = 30;
            this.button4.Text = "Bersih";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvBuku
            // 
            this.dgvBuku.AllowUserToAddRows = false;
            this.dgvBuku.AllowUserToDeleteRows = false;
            this.dgvBuku.AllowUserToResizeRows = false;
            this.dgvBuku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBuku.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuku.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvBuku.ColumnHeadersHeight = 34;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuku.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvBuku.EnableHeadersVisualStyles = false;
            this.dgvBuku.Location = new System.Drawing.Point(518, 120);
            this.dgvBuku.MultiSelect = false;
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.ReadOnly = true;
            this.dgvBuku.RowHeadersVisible = false;
            this.dgvBuku.RowHeadersWidth = 62;
            this.dgvBuku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuku.Size = new System.Drawing.Size(497, 151);
            this.dgvBuku.TabIndex = 28;
            this.dgvBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuku_CellClick);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToResizeRows = false;
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvDetail.ColumnHeadersHeight = 34;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvDetail.EnableHeadersVisualStyles = false;
            this.dgvDetail.Location = new System.Drawing.Point(0, 120);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.RowHeadersWidth = 62;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(497, 151);
            this.dgvDetail.TabIndex = 27;
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(950, 32);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(70, 34);
            this.nudJumlah.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID Detail";
            // 
            // txtIDDetail
            // 
            this.txtIDDetail.Location = new System.Drawing.Point(113, 30);
            this.txtIDDetail.Name = "txtIDDetail";
            this.txtIDDetail.Size = new System.Drawing.Size(160, 34);
            this.txtIDDetail.TabIndex = 15;
            // 
            // cmbJudul
            // 
            this.cmbJudul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJudul.FormattingEnabled = true;
            this.cmbJudul.Location = new System.Drawing.Point(700, 33);
            this.cmbJudul.Name = "cmbJudul";
            this.cmbJudul.Size = new System.Drawing.Size(160, 36);
            this.cmbJudul.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(871, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Jumlah";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 28);
            this.label10.TabIndex = 5;
            this.label10.Text = "ID Peminjaman";
            // 
            // cmbIDPeminjaman
            // 
            this.cmbIDPeminjaman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDPeminjaman.FormattingEnabled = true;
            this.cmbIDPeminjaman.Location = new System.Drawing.Point(433, 32);
            this.cmbIDPeminjaman.Name = "cmbIDPeminjaman";
            this.cmbIDPeminjaman.Size = new System.Drawing.Size(160, 36);
            this.cmbIDPeminjaman.TabIndex = 6;
            this.cmbIDPeminjaman.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(615, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 28);
            this.label11.TabIndex = 7;
            this.label11.Text = "ID Buku";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(152, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(250, 34);
            this.txtID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID Peminjaman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cari ID Anggota :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(607, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 34);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cari ID Peminjaman :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 34);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(694, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cari Judul Buku :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(854, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 34);
            this.textBox3.TabIndex = 32;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1082, 808);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlJudul);
            this.Controls.Add(this.grpHeader);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBersih);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormPeminjaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi Peminjaman";
            this.Load += new System.EventHandler(this.FormPeminjaman_Load);
            this.pnlJudul.ResumeLayout(false);
            this.pnlJudul.PerformLayout();
            this.grpHeader.ResumeLayout(false);
            this.grpHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlJudul;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.GroupBox grpHeader;
        private System.Windows.Forms.Label lblKodeTransaksi;
        private System.Windows.Forms.TextBox txtKodeTransaksi;
        private System.Windows.Forms.Label lblAnggota;
        private System.Windows.Forms.ComboBox cmbAnggota;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPinjam;
        private System.Windows.Forms.DateTimePicker dtpPinjam;
        private System.Windows.Forms.Label lblJatuhTempo;
        private System.Windows.Forms.DateTimePicker dtpJatuhTempo;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBersih;
        private ComboBox cmbStatus;
        private DataGridView dgv;
        private GroupBox groupBox2;
        private Label label8;
        private TextBox txtIDDetail;
        private ComboBox cmbJudul;
        private Label label9;
        private Label label10;
        private ComboBox cmbIDPeminjaman;
        private Label label11;
        private NumericUpDown nudJumlah;
        private Button button1;
        private Label label12;
        private Button button2;
        private Label Detail;
        private Button button3;
        private Button button4;
        private DataGridView dgvBuku;
        private DataGridView dgvDetail;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtID;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
    }
}
