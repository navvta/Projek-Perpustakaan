using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Perpus_Nama_Kelas
{
    partial class FormAnggota
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
            this.lblKode = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblTelepon = new System.Windows.Forms.Label();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.lblDaftar = new System.Windows.Forms.Label();
            this.dtpDaftar = new System.Windows.Forms.DateTimePicker();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBersih = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
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
            this.pnlJudul.Size = new System.Drawing.Size(660, 60);
            this.pnlJudul.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(20, 14);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(230, 45);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Data Anggota";
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(30, 127);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(137, 28);
            this.lblKode.TabIndex = 2;
            this.lblKode.Text = "Kode anggota";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(170, 124);
            this.txtKode.MaxLength = 20;
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(240, 34);
            this.txtKode.TabIndex = 3;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(30, 167);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(64, 28);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(170, 164);
            this.txtNama.MaxLength = 100;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(470, 34);
            this.txtNama.TabIndex = 5;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(30, 207);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(74, 28);
            this.lblAlamat.TabIndex = 6;
            this.lblAlamat.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(170, 204);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(470, 65);
            this.txtAlamat.TabIndex = 7;
            // 
            // lblTelepon
            // 
            this.lblTelepon.AutoSize = true;
            this.lblTelepon.Location = new System.Drawing.Point(30, 287);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Size = new System.Drawing.Size(115, 28);
            this.lblTelepon.TabIndex = 8;
            this.lblTelepon.Text = "No. telepon";
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(170, 284);
            this.txtTelepon.MaxLength = 20;
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(240, 34);
            this.txtTelepon.TabIndex = 9;
            // 
            // lblDaftar
            // 
            this.lblDaftar.AutoSize = true;
            this.lblDaftar.Location = new System.Drawing.Point(30, 327);
            this.lblDaftar.Name = "lblDaftar";
            this.lblDaftar.Size = new System.Drawing.Size(137, 28);
            this.lblDaftar.TabIndex = 10;
            this.lblDaftar.Text = "Tanggal daftar";
            // 
            // dtpDaftar
            // 
            this.dtpDaftar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDaftar.Location = new System.Drawing.Point(170, 324);
            this.dtpDaftar.Name = "dtpDaftar";
            this.dtpDaftar.Size = new System.Drawing.Size(160, 34);
            this.dtpDaftar.TabIndex = 11;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(30, 374);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(105, 34);
            this.btnSimpan.TabIndex = 12;
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
            this.btnUbah.Location = new System.Drawing.Point(150, 374);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(105, 34);
            this.btnUbah.TabIndex = 13;
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
            this.btnHapus.Location = new System.Drawing.Point(270, 374);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(105, 34);
            this.btnHapus.TabIndex = 14;
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
            this.btnBersih.Location = new System.Drawing.Point(390, 374);
            this.btnBersih.Name = "btnBersih";
            this.btnBersih.Size = new System.Drawing.Size(105, 34);
            this.btnBersih.TabIndex = 15;
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
            this.dgv.Location = new System.Drawing.Point(20, 436);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(620, 202);
            this.dgv.TabIndex = 16;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(110, 28);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID anggota";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(170, 75);
            this.txtID.MaxLength = 20;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(240, 34);
            this.txtID.TabIndex = 18;
            // 
            // FormAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(660, 650);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pnlJudul);
            this.Controls.Add(this.lblKode);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.lblTelepon);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.lblDaftar);
            this.Controls.Add(this.dtpDaftar);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnBersih);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormAnggota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Anggota";
            this.Load += new System.EventHandler(this.FormAnggota_Load);
            this.pnlJudul.ResumeLayout(false);
            this.pnlJudul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlJudul;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblTelepon;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.Label lblDaftar;
        private System.Windows.Forms.DateTimePicker dtpDaftar;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBersih;
        private System.Windows.Forms.DataGridView dgv;
        private Label lblID;
        private TextBox txtID;
    }
}
