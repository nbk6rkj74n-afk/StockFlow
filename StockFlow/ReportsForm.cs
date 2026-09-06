using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockFlow
{
    public partial class ReportsForm : Form
    {
        Database db = new Database();

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            RaporuGetir();
        }

        private void RaporuGetir()
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT
                    ProductName AS [Ürün Adı],
                    StockQuantity AS [Mevcut Stok],
                    CriticalStock AS [Kritik Stok],
                    SalePrice AS [Satış Fiyatı],
                    (StockQuantity * SalePrice) AS [Toplam Değer]
                FROM Products
                ORDER BY ProductName";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvRaporlar.DataSource = table;
                    }
                }

                dgvRaporlar.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvRaporlar.ReadOnly = true;
                dgvRaporlar.AllowUserToAddRows = false;
                dgvRaporlar.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Rapor yüklenirken hata oluştu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
