namespace StockFlow
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUrunAdi = new Label();
            txtUrunAdi = new TextBox();
            lblKategori = new Label();
            cmbKategori = new ComboBox();
            lblStok = new Label();
            txtStok = new TextBox();
            lblFiyat = new Label();
            lblKritikStok = new Label();
            txtFiyat = new TextBox();
            txtKritikStok = new TextBox();
            btnUrunEkle = new Button();
            dgvUrunler = new DataGridView();
            btnUrunSil = new Button();
            btnUrunGuncelle = new Button();
            txtUrunAra = new TextBox();
            lblUrunAra = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // lblUrunAdi
            // 
            lblUrunAdi.AutoSize = true;
            lblUrunAdi.Location = new Point(12, 20);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new Size(67, 20);
            lblUrunAdi.TabIndex = 0;
            lblUrunAdi.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(148, 17);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(151, 27);
            txtUrunAdi.TabIndex = 1;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(12, 84);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(66, 20);
            lblKategori.TabIndex = 2;
            lblKategori.Text = "Kategori";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(148, 76);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(151, 28);
            cmbKategori.TabIndex = 3;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Location = new Point(12, 140);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(88, 20);
            lblStok.TabIndex = 4;
            lblStok.Text = "Stok Miktarı";
            // 
            // txtStok
            // 
            txtStok.Location = new Point(150, 133);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(149, 27);
            txtStok.TabIndex = 5;
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Location = new Point(12, 204);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(79, 20);
            lblFiyat.TabIndex = 6;
            lblFiyat.Text = "Birim Fiyat";
            // 
            // lblKritikStok
            // 
            lblKritikStok.AutoSize = true;
            lblKritikStok.Location = new Point(12, 257);
            lblKritikStok.Name = "lblKritikStok";
            lblKritikStok.Size = new Size(132, 20);
            lblKritikStok.TabIndex = 7;
            lblKritikStok.Text = "Kritik Stok Seviyesi";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(148, 204);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(151, 27);
            txtFiyat.TabIndex = 8;
            // 
            // txtKritikStok
            // 
            txtKritikStok.Location = new Point(150, 254);
            txtKritikStok.Name = "txtKritikStok";
            txtKritikStok.Size = new Size(149, 27);
            txtKritikStok.TabIndex = 9;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(26, 485);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(252, 29);
            btnUrunEkle.TabIndex = 10;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(12, 287);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.Size = new Size(807, 188);
            dgvUrunler.TabIndex = 11;
            dgvUrunler.CellClick += dgvUrunler_CellClick;
            dgvUrunler.CellContentClick += dgvUrunler_CellContentClick;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(542, 485);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(246, 29);
            btnUrunSil.TabIndex = 12;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnUrunGuncelle
            // 
            btnUrunGuncelle.Location = new Point(284, 485);
            btnUrunGuncelle.Name = "btnUrunGuncelle";
            btnUrunGuncelle.Size = new Size(235, 29);
            btnUrunGuncelle.TabIndex = 13;
            btnUrunGuncelle.Text = "Ürün Güncelle";
            btnUrunGuncelle.UseVisualStyleBackColor = true;
            btnUrunGuncelle.Click += btnUrunGuncelle_Click;
            // 
            // txtUrunAra
            // 
            txtUrunAra.Location = new Point(456, 13);
            txtUrunAra.Name = "txtUrunAra";
            txtUrunAra.Size = new Size(125, 27);
            txtUrunAra.TabIndex = 14;
            txtUrunAra.TextChanged += txtUrunAra_TextChanged;
            // 
            // lblUrunAra
            // 
            lblUrunAra.AutoSize = true;
            lblUrunAra.Location = new Point(381, 20);
            lblUrunAra.Name = "lblUrunAra";
            lblUrunAra.Size = new Size(70, 20);
            lblUrunAra.TabIndex = 15;
            lblUrunAra.Text = "Ürün Ara:";
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 526);
            Controls.Add(lblUrunAra);
            Controls.Add(txtUrunAra);
            Controls.Add(btnUrunGuncelle);
            Controls.Add(btnUrunSil);
            Controls.Add(dgvUrunler);
            Controls.Add(btnUrunEkle);
            Controls.Add(txtKritikStok);
            Controls.Add(txtFiyat);
            Controls.Add(lblKritikStok);
            Controls.Add(lblFiyat);
            Controls.Add(txtStok);
            Controls.Add(lblStok);
            Controls.Add(cmbKategori);
            Controls.Add(lblKategori);
            Controls.Add(txtUrunAdi);
            Controls.Add(lblUrunAdi);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockFlow-Ürünler";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUrunAdi;
        private TextBox txtUrunAdi;
        private Label lblKategori;
        private ComboBox cmbKategori;
        private Label lblStok;
        private TextBox txtStok;
        private Label lblFiyat;
        private Label lblKritikStok;
        private TextBox txtFiyat;
        private TextBox txtKritikStok;
        private Button btnUrunEkle;
        private DataGridView dgvUrunler;
        private Button btnUrunSil;
        private Button btnUrunGuncelle;
        private TextBox txtUrunAra;
        private Label lblUrunAra;
    }
}