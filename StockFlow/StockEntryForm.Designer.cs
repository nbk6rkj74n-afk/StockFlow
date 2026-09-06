namespace StockFlow
{
    partial class StockEntryForm
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
            label1 = new Label();
            label2 = new Label();
            cmbUrun = new ComboBox();
            btnStokGiris = new Button();
            txtMiktar = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 108);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 163);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Stok Miktarı";
            // 
            // cmbUrun
            // 
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Location = new Point(223, 100);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(151, 28);
            cmbUrun.TabIndex = 2;
            // 
            // btnStokGiris
            // 
            btnStokGiris.Location = new Point(151, 240);
            btnStokGiris.Name = "btnStokGiris";
            btnStokGiris.Size = new Size(161, 29);
            btnStokGiris.TabIndex = 3;
            btnStokGiris.Text = "Stok Girişi Yap";
            btnStokGiris.UseVisualStyleBackColor = true;
            btnStokGiris.Click += btnStokGiris_Click_1;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(223, 156);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(151, 27);
            txtMiktar.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 43);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "STOK GİRİŞİ";
            // 
            // StockEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 356);
            Controls.Add(label3);
            Controls.Add(txtMiktar);
            Controls.Add(btnStokGiris);
            Controls.Add(cmbUrun);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StockEntryForm";
            Text = "StockEntryForm";
            Load += StockEntryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbUrun;
        private Button btnStokGiris;
        private TextBox txtMiktar;
        private Label label3;
    }
}