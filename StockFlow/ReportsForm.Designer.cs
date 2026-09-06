namespace StockFlow
{
    partial class ReportsForm
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
            dgvRaporlar = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRaporlar).BeginInit();
            SuspendLayout();
            // 
            // dgvRaporlar
            // 
            dgvRaporlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRaporlar.Location = new Point(-1, 41);
            dgvRaporlar.Name = "dgvRaporlar";
            dgvRaporlar.RowHeadersWidth = 51;
            dgvRaporlar.Size = new Size(797, 408);
            dgvRaporlar.TabIndex = 0;       
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "STOK RAPORU";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvRaporlar);
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRaporlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRaporlar;
        private Label label1;
    }
}