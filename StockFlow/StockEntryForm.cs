using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockFlow
{
    public partial class StockEntryForm : Form
    {
        Database db = new Database();

        public StockEntryForm()
        {
            InitializeComponent();
        }

        private void StockEntryForm_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void UrunleriGetir()
        {
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT ProductID, ProductName FROM Products";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbUrun.Items.Clear();

                        while (reader.Read())
                        {
                            cmbUrun.Items.Add(
                                new Urun
                                {
                                    ProductID = Convert.ToInt32(reader["ProductID"]),
                                    ProductName = reader["ProductName"].ToString()
                                });
                        }
                    }
                }

                cmbUrun.DisplayMember = "ProductName";
                cmbUrun.ValueMember = "ProductID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürünler yüklenirken hata oluştu:\n" + ex.Message);
            }
        }

        private void btnStokGiris_Click(object sender, EventArgs e)
        {
            if (cmbUrun.SelectedItem == null)
            {
                MessageBox.Show("Lütfen ürün seçiniz.");
                return;
            }

            if (!int.TryParse(txtMiktar.Text, out int miktar) || miktar <= 0)
            {
                MessageBox.Show("Stok miktarı pozitif bir sayı olmalıdır.");
                return;
            }

            Urun secilenUrun = (Urun)cmbUrun.SelectedItem;

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE Products
                        SET StockQuantity = StockQuantity + @Miktar
                        WHERE ProductID = @ProductID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Miktar", miktar);
                        cmd.Parameters.AddWithValue("@ProductID", secilenUrun.ProductID);

                        int sonuc = cmd.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Stok girişi başarıyla yapıldı.",
                                "Başarılı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            txtMiktar.Clear();
                            cmbUrun.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stok girişi sırasında hata oluştu:\n" + ex.Message);
            }
        }

        private void btnStokGiris_Click_1(object sender, EventArgs e)
        {
           
            {
                if (cmbUrun.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen ürün seçiniz.");
                    return;
                }

                if (!int.TryParse(txtMiktar.Text, out int miktar) || miktar <= 0)
                {
                    MessageBox.Show("Stok miktarı pozitif bir sayı olmalıdır.");
                    return;
                }

                Urun secilenUrun = (Urun)cmbUrun.SelectedItem;

                try
                {
                    using (SqlConnection conn = db.GetConnection())
                    {
                        conn.Open();

                        string query = @"
                UPDATE Products
                SET StockQuantity = StockQuantity + @Miktar
                WHERE ProductID = @ProductID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Miktar", miktar);
                            cmd.Parameters.AddWithValue("@ProductID", secilenUrun.ProductID);

                            int sonuc = cmd.ExecuteNonQuery();

                            if (sonuc > 0)
                            {
                                MessageBox.Show("Stok girişi başarıyla yapıldı.");

                                txtMiktar.Clear();
                                cmbUrun.SelectedIndex = -1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Stok girişi sırasında hata oluştu:\n" + ex.Message);
                }
            }
        }
    }

    public class Urun
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
