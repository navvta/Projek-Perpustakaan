using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Perpus_Nama_Kelas
{
    partial class FormUtama
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
            this.menuUtama = new System.Windows.Forms.MenuStrip();
            this.mnuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnggota = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKategori = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuku = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPeminjaman = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPengembalian = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuUtama.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuUtama
            // 
            this.menuUtama.BackColor = System.Drawing.Color.DarkCyan;
            this.menuUtama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuUtama.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuUtama.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMaster,
            this.mnuTransaksi});
            this.menuUtama.Location = new System.Drawing.Point(0, 0);
            this.menuUtama.Name = "menuUtama";
            this.menuUtama.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuUtama.Size = new System.Drawing.Size(1238, 36);
            this.menuUtama.TabIndex = 0;
            this.menuUtama.Text = "menuUtama";
            // 
            // mnuMaster
            // 
            this.mnuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnggota,
            this.mnuKategori,
            this.mnuBuku});
            this.mnuMaster.ForeColor = System.Drawing.Color.White;
            this.mnuMaster.Name = "mnuMaster";
            this.mnuMaster.Size = new System.Drawing.Size(136, 32);
            this.mnuMaster.Text = "Administrasi";
            // 
            // mnuAnggota
            // 
            this.mnuAnggota.Name = "mnuAnggota";
            this.mnuAnggota.Size = new System.Drawing.Size(191, 36);
            this.mnuAnggota.Text = "Anggota";
            this.mnuAnggota.Click += new System.EventHandler(this.mnuAnggota_Click);
            // 
            // mnuKategori
            // 
            this.mnuKategori.Name = "mnuKategori";
            this.mnuKategori.Size = new System.Drawing.Size(191, 36);
            this.mnuKategori.Text = "Kategori";
            this.mnuKategori.Click += new System.EventHandler(this.mnuKategori_Click);
            // 
            // mnuBuku
            // 
            this.mnuBuku.Name = "mnuBuku";
            this.mnuBuku.Size = new System.Drawing.Size(191, 36);
            this.mnuBuku.Text = "Buku";
            this.mnuBuku.Click += new System.EventHandler(this.mnuBuku_Click);
            // 
            // mnuTransaksi
            // 
            this.mnuTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPeminjaman,
            this.mnuPengembalian});
            this.mnuTransaksi.ForeColor = System.Drawing.Color.White;
            this.mnuTransaksi.Name = "mnuTransaksi";
            this.mnuTransaksi.Size = new System.Drawing.Size(105, 32);
            this.mnuTransaksi.Text = "Transaksi";
            // 
            // mnuPeminjaman
            // 
            this.mnuPeminjaman.Name = "mnuPeminjaman";
            this.mnuPeminjaman.Size = new System.Drawing.Size(276, 36);
            this.mnuPeminjaman.Text = "Peminjaman";
            this.mnuPeminjaman.Click += new System.EventHandler(this.mnuPeminjaman_Click);
            // 
            // mnuPengembalian
            // 
            this.mnuPengembalian.Name = "mnuPengembalian";
            this.mnuPengembalian.Size = new System.Drawing.Size(276, 36);
            this.mnuPengembalian.Text = "Pengembalian";
            this.mnuPengembalian.Click += new System.EventHandler(this.mnuPengembalian_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 50F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(0, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1238, 664);
            this.label1.TabIndex = 2;
            this.label1.Text = "TISHRI LIBRARY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1238, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuUtama);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuUtama;
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Perpustakaan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuUtama.ResumeLayout(false);
            this.menuUtama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuUtama;
        private System.Windows.Forms.ToolStripMenuItem mnuMaster;
        private System.Windows.Forms.ToolStripMenuItem mnuAnggota;
        private System.Windows.Forms.ToolStripMenuItem mnuKategori;
        private System.Windows.Forms.ToolStripMenuItem mnuBuku;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaksi;
        private System.Windows.Forms.ToolStripMenuItem mnuPeminjaman;
        private System.Windows.Forms.ToolStripMenuItem mnuPengembalian;
        private Label label1;
    }
}
