namespace StockFlow
{
    partial class MainForm
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
            panelMenu = new Panel();
            btnCikis = new Button();
            btnStokCikis = new Button();
            btnStokGiris = new Button();
            btnUrunler = new Button();
            btnAnaSayfa = new Button();
            panelHeader = new Panel();
            pnlToplamUrun = new Panel();
            lblToplamUrun = new Label();
            lblToplamUrunBaslik = new Label();
            pnlKritikStok = new Panel();
            lblKritikStokBaslik = new Label();
            lblKritikStok = new Label();
            pnlStokDegeri = new Panel();
            lblStokDegeriBasliik = new Label();
            lblStokDegeri = new Label();
            colorDialog1 = new ColorDialog();
            btnRaporlar = new Button();
            panelMenu.SuspendLayout();
            pnlToplamUrun.SuspendLayout();
            pnlKritikStok.SuspendLayout();
            pnlStokDegeri.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnRaporlar);
            panelMenu.Controls.Add(btnCikis);
            panelMenu.Controls.Add(btnStokCikis);
            panelMenu.Controls.Add(btnStokGiris);
            panelMenu.Controls.Add(btnUrunler);
            panelMenu.Controls.Add(btnAnaSayfa);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 653);
            panelMenu.TabIndex = 0;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(30, 442);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 29);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnStokCikis
            // 
            btnStokCikis.Location = new Point(30, 287);
            btnStokCikis.Name = "btnStokCikis";
            btnStokCikis.Size = new Size(94, 29);
            btnStokCikis.TabIndex = 3;
            btnStokCikis.Text = "Stok Çıkışı";
            btnStokCikis.UseVisualStyleBackColor = true;
            btnStokCikis.Click += btnStokCikis_Click;
            // 
            // btnStokGiris
            // 
            btnStokGiris.Location = new Point(30, 216);
            btnStokGiris.Name = "btnStokGiris";
            btnStokGiris.Size = new Size(94, 25);
            btnStokGiris.TabIndex = 3;
            btnStokGiris.Text = "Stok Girişi";
            btnStokGiris.UseVisualStyleBackColor = true;
            btnStokGiris.Click += btnStokGiris_Click;
            // 
            // btnUrunler
            // 
            btnUrunler.Location = new Point(30, 138);
            btnUrunler.Name = "btnUrunler";
            btnUrunler.Size = new Size(94, 29);
            btnUrunler.TabIndex = 4;
            btnUrunler.Text = "Ürünler";
            btnUrunler.UseVisualStyleBackColor = true;
            btnUrunler.Click += btnUrunler_Click;
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.Location = new Point(30, 74);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Size = new Size(94, 29);
            btnAnaSayfa.TabIndex = 3;
            btnAnaSayfa.Text = "Ana Sayfa";
            btnAnaSayfa.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(220, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(962, 125);
            panelHeader.TabIndex = 1;
            // 
            // pnlToplamUrun
            // 
            pnlToplamUrun.Controls.Add(lblToplamUrun);
            pnlToplamUrun.Controls.Add(lblToplamUrunBaslik);
            pnlToplamUrun.Location = new Point(247, 138);
            pnlToplamUrun.Name = "pnlToplamUrun";
            pnlToplamUrun.Size = new Size(266, 125);
            pnlToplamUrun.TabIndex = 2;
            // 
            // lblToplamUrun
            // 
            lblToplamUrun.AccessibleName = "";
            lblToplamUrun.AutoSize = true;
            lblToplamUrun.Location = new Point(116, 80);
            lblToplamUrun.Name = "lblToplamUrun";
            lblToplamUrun.Size = new Size(17, 20);
            lblToplamUrun.TabIndex = 4;
            lblToplamUrun.Text = "0";
            // 
            // lblToplamUrunBaslik
            // 
            lblToplamUrunBaslik.AutoSize = true;
            lblToplamUrunBaslik.Location = new Point(81, 28);
            lblToplamUrunBaslik.Name = "lblToplamUrunBaslik";
            lblToplamUrunBaslik.Size = new Size(94, 20);
            lblToplamUrunBaslik.TabIndex = 0;
            lblToplamUrunBaslik.Text = "Toplam Ürün";
            // 
            // pnlKritikStok
            // 
            pnlKritikStok.Controls.Add(lblKritikStokBaslik);
            pnlKritikStok.Controls.Add(lblKritikStok);
            pnlKritikStok.Location = new Point(558, 138);
            pnlKritikStok.Name = "pnlKritikStok";
            pnlKritikStok.Size = new Size(269, 125);
            pnlKritikStok.TabIndex = 3;
            // 
            // lblKritikStokBaslik
            // 
            lblKritikStokBaslik.AutoSize = true;
            lblKritikStokBaslik.Location = new Point(98, 28);
            lblKritikStokBaslik.Name = "lblKritikStokBaslik";
            lblKritikStokBaslik.Size = new Size(76, 20);
            lblKritikStokBaslik.TabIndex = 5;
            lblKritikStokBaslik.Text = "Kritik Stok";
            // 
            // lblKritikStok
            // 
            lblKritikStok.AutoSize = true;
            lblKritikStok.Location = new Point(137, 80);
            lblKritikStok.Name = "lblKritikStok";
            lblKritikStok.Size = new Size(17, 20);
            lblKritikStok.TabIndex = 6;
            lblKritikStok.Text = "0";
            // 
            // pnlStokDegeri
            // 
            pnlStokDegeri.Controls.Add(lblStokDegeriBasliik);
            pnlStokDegeri.Controls.Add(lblStokDegeri);
            pnlStokDegeri.Location = new Point(872, 138);
            pnlStokDegeri.Name = "pnlStokDegeri";
            pnlStokDegeri.Size = new Size(268, 125);
            pnlStokDegeri.TabIndex = 3;
            // 
            // lblStokDegeriBasliik
            // 
            lblStokDegeriBasliik.AutoSize = true;
            lblStokDegeriBasliik.Location = new Point(74, 28);
            lblStokDegeriBasliik.Name = "lblStokDegeriBasliik";
            lblStokDegeriBasliik.Size = new Size(141, 20);
            lblStokDegeriBasliik.TabIndex = 7;
            lblStokDegeriBasliik.Text = "Toplam Stok Değeri";
            // 
            // lblStokDegeri
            // 
            lblStokDegeri.AutoSize = true;
            lblStokDegeri.Location = new Point(127, 80);
            lblStokDegeri.Name = "lblStokDegeri";
            lblStokDegeri.Size = new Size(17, 20);
            lblStokDegeri.TabIndex = 8;
            lblStokDegeri.Text = "0";
            // 
            // btnRaporlar
            // 
            btnRaporlar.Location = new Point(30, 372);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(94, 29);
            btnRaporlar.TabIndex = 4;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(pnlKritikStok);
            Controls.Add(pnlStokDegeri);
            Controls.Add(pnlToplamUrun);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockFlow-Ana Panel";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            pnlToplamUrun.ResumeLayout(false);
            pnlToplamUrun.PerformLayout();
            pnlKritikStok.ResumeLayout(false);
            pnlKritikStok.PerformLayout();
            pnlStokDegeri.ResumeLayout(false);
            pnlStokDegeri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelHeader;
        private Button btnUrunler;
        private Button btnAnaSayfa;
        private Button btnStokGiris;
        private Button btnCikis;
        private Button btnStokCikis;
        private Panel pnlToplamUrun;
        private Panel pnlKritikStok;
        private Panel pnlStokDegeri;
        private Label lblKritikStokBaslik;
        private Label lblToplamUrun;
        private Label lblToplamUrunBaslik;
        private Label lblStokDegeriBasliik;
        private Label lblStokDegeri;
        private Label lblKritikStok;
        private ColorDialog colorDialog1;
        private Button btnRaporlar;
    }
}