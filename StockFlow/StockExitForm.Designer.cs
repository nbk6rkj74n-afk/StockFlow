namespace StockFlow
{
    partial class StockExitForm
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
            btnStokCikis = new Button();
            txtMiktar = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 115);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 165);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Stok Miktarı :";
            // 
            // cmbUrun
            // 
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Location = new Point(204, 107);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(151, 28);
            cmbUrun.TabIndex = 2;
            // 
            // btnStokCikis
            // 
            btnStokCikis.Location = new Point(142, 220);
            btnStokCikis.Name = "btnStokCikis";
            btnStokCikis.Size = new Size(124, 29);
            btnStokCikis.TabIndex = 3;
            btnStokCikis.Text = "Stok Çıkışı Yap";
            btnStokCikis.UseVisualStyleBackColor = true;
            btnStokCikis.Click += btnStokCikis_Click_1;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(204, 165);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(151, 27);
            txtMiktar.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 50);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "STOK ÇIKIŞI";
            // 
            // StockExitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 368);
            Controls.Add(label3);
            Controls.Add(txtMiktar);
            Controls.Add(btnStokCikis);
            Controls.Add(cmbUrun);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StockExitForm";
            Text = "StockExitForm";
            Load += StockExitForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbUrun;
        private Button btnStokCikis;
        private TextBox txtMiktar;
        private Label label3;
    }
}