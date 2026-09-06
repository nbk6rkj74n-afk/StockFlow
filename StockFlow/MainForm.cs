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
namespace StockFlow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            { }
            Database database = new Database();

            using (SqlConnection connection = database.GetConnection())
            {
                connection.Open();

                string query = @"
            SELECT
                COUNT(*) AS ToplamUrun,
                SUM(CASE WHEN StockQuantity <= CriticalStock THEN 1 ELSE 0 END) AS KritikStok,
                SUM(StockQuantity * SalePrice) AS StokDegeri
            FROM Products";

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblToplamUrun.Text = reader["ToplamUrun"].ToString();
                        lblKritikStok.Text = reader["KritikStok"].ToString();

                        decimal stokDegeri = reader["StokDegeri"] == DBNull.Value
                            ? 0
                            : Convert.ToDecimal(reader["StokDegeri"]);

                        lblStokDegeri.Text = "₺" + stokDegeri.ToString("N2");
                    }
                }
            }
        }

        private void btnStokGiris_Click(object sender, EventArgs e)
        {

            {
                StockEntryForm stockEntryForm = new StockEntryForm();
                stockEntryForm.Show();
            }
        }

        private void btnStokCikis_Click(object sender, EventArgs e)
        {
            StockExitForm stockExitForm = new StockExitForm();
            stockExitForm.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            

            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
        }
    }




}
    

