using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace StockFlow
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Database database = new Database();

            using (SqlConnection connection = database.GetConnection())
            {
                connection.Open();

                string query = @"INSERT INTO Products
                     (ProductName, Category, StockQuantity, SalePrice, CriticalStock)
                     VALUES
                     (@ProductName, @Category, @StockQuantity, @SalePrice, @CriticalStock)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ProductName", txtUrunAdi.Text);
                command.Parameters.AddWithValue("@Category", cmbKategori.Text);
                command.Parameters.AddWithValue("@StockQuantity", int.Parse(txtStok.Text));
                command.Parameters.AddWithValue("@SalePrice", decimal.Parse(txtFiyat.Text));
                command.Parameters.AddWithValue("@CriticalStock", int.Parse(txtKritikStok.Text));

                command.ExecuteNonQuery();

                MessageBox.Show("Ürün başarıyla eklendi.");
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            Database database = new Database();

            using (SqlConnection connection = database.GetConnection())
            {
                connection.Open();

                string query = "SELECT ProductID, ProductName, Category, StockQuantity, SalePrice, CriticalStock FROM Products";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvUrunler.DataSource = table;
            }

            // Kritik stokları kırmızı göster
            foreach (DataGridViewRow row in dgvUrunler.Rows)
            {
                if (row.IsNewRow)
                    continue;

                int stok = Convert.ToInt32(row.Cells["StockQuantity"].Value);
                int kritikStok = Convert.ToInt32(row.Cells["CriticalStock"].Value);

                if (stok <= kritikStok)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü seçin.");
                return;
            }

            int productId = Convert.ToInt32(
                dgvUrunler.CurrentRow.Cells["ProductID"].Value
            );

            Database database = new Database();

            using (SqlConnection connection = database.GetConnection())
            {
                connection.Open();

                string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", productId);

                command.ExecuteNonQuery();
            }

            MessageBox.Show("Ürün silindi.");

            ProductsForm_Load(null, null);
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
                return;
            }

            int productId = Convert.ToInt32(
                dgvUrunler.CurrentRow.Cells["ProductID"].Value
            );

            if (!int.TryParse(txtStok.Text.Trim(), out int stok))
            {
                MessageBox.Show("Stok miktarı sayı olmalıdır.");
                return;
            }

            if (!decimal.TryParse(txtFiyat.Text.Trim(), out decimal fiyat))
            {
                MessageBox.Show("Birim fiyat sayı olmalıdır.");
                return;
            }

            if (!int.TryParse(txtKritikStok.Text.Trim(), out int kritikStok))
            {
                MessageBox.Show("Kritik stok seviyesi sayı olmalıdır.");
                return;
            }

            Database database = new Database();

            using (SqlConnection connection = database.GetConnection())
            {
                connection.Open();

                string query = @"UPDATE Products
                         SET ProductName = @ProductName,
                             Category = @Category,
                             StockQuantity = @StockQuantity,
                             SalePrice = @SalePrice,
                             CriticalStock = @CriticalStock
                         WHERE ProductID = @ProductID";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ProductName", txtUrunAdi.Text.Trim());
                command.Parameters.AddWithValue("@Category", cmbKategori.Text.Trim());
                command.Parameters.AddWithValue("@StockQuantity", stok);
                command.Parameters.AddWithValue("@SalePrice", fiyat);
                command.Parameters.AddWithValue("@CriticalStock", kritikStok);
                command.Parameters.AddWithValue("@ProductID", productId);

                command.ExecuteNonQuery();
            }

            if (stok <= kritikStok)
            {
                MessageBox.Show(
                    "Ürün başarıyla güncellendi.\n\n⚠️ Dikkat! Bu ürün kritik stok seviyesinde.",
                    "Kritik Stok Uyarısı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                MessageBox.Show("Ürün başarıyla güncellendi.");
            }

            ProductsForm_Load(null, null);
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvUrunler.Rows[e.RowIndex];

            txtUrunAdi.Text = row.Cells["ProductName"].Value?.ToString();
            cmbKategori.Text = row.Cells["Category"].Value?.ToString();
            txtStok.Text = Convert.ToInt32(row.Cells["StockQuantity"].Value).ToString();
            txtFiyat.Text = row.Cells["SalePrice"].Value?.ToString();
            txtKritikStok.Text = row.Cells["CriticalStock"].Value?.ToString();
        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            {
                Database database = new Database();

                using (SqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT ProductID, ProductName, Category, 
                                StockQuantity, SalePrice, CriticalStock
                         FROM Products
                         WHERE ProductName LIKE @Search";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@Search",
                        "%" + txtUrunAra.Text.Trim() + "%"
                    );

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvUrunler.DataSource = table;
                }

                // Kritik stokları tekrar kırmızı göster
                foreach (DataGridViewRow row in dgvUrunler.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    int stok = Convert.ToInt32(row.Cells["StockQuantity"].Value);
                    int kritikStok = Convert.ToInt32(row.Cells["CriticalStock"].Value);

                    if (stok <= kritikStok)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
