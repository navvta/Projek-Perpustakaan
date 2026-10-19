using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Perpus_Nama_Kelas
{
    partial class FormPengembalian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlJudul = new System.Windows.Forms.Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblTransaksi = new System.Windows.Forms.Label();
            this.cmbTransaksi = new System.Windows.Forms.ComboBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblJatuhTempo = new System.Windows.Forms.Label();
            this.lblKembali = new System.Windows.Forms.Label();
            this.dtpKembali = new System.Windows.Forms.DateTimePicker();
            this.lblDenda = new System.Windows.Forms.Label();
            this.txtDenda = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBersih = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dtpJatuhTempo = new System.Windows.Forms.DateTimePicker();
            this.btnHitungDenda = new System.Windows.Forms.Button();
            this.pnlJudul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlJudul
            // 
            this.pnlJudul.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlJudul.Controls.Add(this.lblJudul);
            this.pnlJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlJudul.Location = new System.Drawing.Point(0, 0);
            this.pnlJudul.Name = "pnlJudul";
            this.pnlJudul.Size = new System.Drawing.Size(880, 60);
            this.pnlJudul.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(20, 14);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(379, 45);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Transaksi Pengembalian";
            // 
            // lblTransaksi
            // 
            this.lblTransaksi.AutoSize = true;
            this.lblTransaksi.Location = new System.Drawing.Point(24, 121);
            this.lblTransaksi.Name = "lblTransaksi";
            this.lblTransaksi.Size = new System.Drawing.Size(142, 28);
            this.lblTransaksi.TabIndex = 2;
            this.lblTransaksi.Text = "ID Peminjaman";
            // 
            // cmbTransaksi
            // 
            this.cmbTransaksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransaksi.FormattingEnabled = true;
            this.cmbTransaksi.Location = new System.Drawing.Point(185, 118);
            this.cmbTransaksi.Name = "cmbTransaksi";
            this.cmbTransaksi.Size = new System.Drawing.Size(300, 36);
            this.cmbTransaksi.TabIndex = 3;
            this.cmbTransaksi.SelectedIndexChanged += new System.EventHandler(this.cmbTransaksi_SelectedIndexChanged);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(20, 81);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(159, 28);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "ID Pengembalian";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(185, 78);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(300, 34);
            this.txtID.TabIndex = 5;
            this.txtID.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // lblJatuhTempo
            // 
            this.lblJatuhTempo.AutoSize = true;
            this.lblJatuhTempo.Location = new System.Drawing.Point(45, 168);
            this.lblJatuhTempo.Name = "lblJatuhTempo";
            this.lblJatuhTempo.Size = new System.Drawing.Size(121, 28);
            this.lblJatuhTempo.TabIndex = 6;
            this.lblJatuhTempo.Text = "Jatuh tempo";
            // 
            // lblKembali
            // 
            this.lblKembali.AutoSize = true;
            this.lblKembali.Location = new System.Drawing.Point(25, 211);
            this.lblKembali.Name = "lblKembali";
            this.lblKembali.Size = new System.Drawing.Size(154, 28);
            this.lblKembali.TabIndex = 8;
            this.lblKembali.Text = "Tanggal kembali";
            this.lblKembali.Click += new System.EventHandler(this.lblKembali_Click);
            // 
            // dtpKembali
            // 
            this.dtpKembali.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKembali.Location = new System.Drawing.Point(185, 205);
            this.dtpKembali.Name = "dtpKembali";
            this.dtpKembali.Size = new System.Drawing.Size(160, 34);
            this.dtpKembali.TabIndex = 9;
            // 
            // lblDenda
            // 
            this.lblDenda.AutoSize = true;
            this.lblDenda.Location = new System.Drawing.Point(45, 285);
            this.lblDenda.Name = "lblDenda";
            this.lblDenda.Size = new System.Drawing.Size(69, 28);
            this.lblDenda.TabIndex = 12;
            this.lblDenda.Text = "Denda";
            this.lblDenda.Click += new System.EventHandler(this.lblDenda_Click);
            // 
            // txtDenda
            // 
            this.txtDenda.Location = new System.Drawing.Point(185, 285);
            this.txtDenda.Name = "txtDenda";
            this.txtDenda.ReadOnly = true;
            this.txtDenda.Size = new System.Drawing.Size(160, 34);
            this.txtDenda.TabIndex = 13;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(196, 337);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(105, 34);
            this.btnSimpan.TabIndex = 16;
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
            this.btnUbah.Location = new System.Drawing.Point(316, 337);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(105, 34);
            this.btnUbah.TabIndex = 17;
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
            this.btnHapus.Location = new System.Drawing.Point(436, 337);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(105, 34);
            this.btnHapus.TabIndex = 18;
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
            this.btnBersih.Location = new System.Drawing.Point(556, 337);
            this.btnBersih.Name = "btnBersih";
            this.btnBersih.Size = new System.Drawing.Size(105, 34);
            this.btnBersih.TabIndex = 19;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(20, 415);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(840, 345);
            this.dgv.TabIndex = 21;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // dtpJatuhTempo
            // 
            this.dtpJatuhTempo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJatuhTempo.Location = new System.Drawing.Point(185, 168);
            this.dtpJatuhTempo.Name = "dtpJatuhTempo";
            this.dtpJatuhTempo.Size = new System.Drawing.Size(160, 34);
            this.dtpJatuhTempo.TabIndex = 22;
            // 
            // btnHitungDenda
            // 
            this.btnHitungDenda.BackColor = System.Drawing.Color.DarkCyan;
            this.btnHitungDenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHitungDenda.FlatAppearance.BorderSize = 0;
            this.btnHitungDenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHitungDenda.ForeColor = System.Drawing.Color.White;
            this.btnHitungDenda.Location = new System.Drawing.Point(185, 245);
            this.btnHitungDenda.Name = "btnHitungDenda";
            this.btnHitungDenda.Size = new System.Drawing.Size(165, 34);
            this.btnHitungDenda.TabIndex = 23;
            this.btnHitungDenda.Text = "Hitung Denda";
            this.btnHitungDenda.UseVisualStyleBackColor = false;
            this.btnHitungDenda.Click += new System.EventHandler(this.btnHitungDenda_Click);
            // 
            // FormPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(880, 780);
            this.Controls.Add(this.btnHitungDenda);
            this.Controls.Add(this.dtpJatuhTempo);
            this.Controls.Add(this.pnlJudul);
            this.Controls.Add(this.lblTransaksi);
            this.Controls.Add(this.cmbTransaksi);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblJatuhTempo);
            this.Controls.Add(this.lblKembali);
            this.Controls.Add(this.dtpKembali);
            this.Controls.Add(this.lblDenda);
            this.Controls.Add(this.txtDenda);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBersih);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormPengembalian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi Pengembalian";
            this.Load += new System.EventHandler(this.FormPengembalian_Load);
            this.pnlJudul.ResumeLayout(false);
            this.pnlJudul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlJudul;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblTransaksi;
        private System.Windows.Forms.ComboBox cmbTransaksi;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblJatuhTempo;
        private System.Windows.Forms.Label lblKembali;
        private System.Windows.Forms.DateTimePicker dtpKembali;
        private System.Windows.Forms.Label lblDenda;
        private System.Windows.Forms.TextBox txtDenda;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBersih;
        private System.Windows.Forms.DataGridView dgv;
        private DateTimePicker dtpJatuhTempo;
        private Button btnHitungDenda;
    }
}
