using StockFlow;

using StockFlow;
using System.Data.SqlClient;

namespace StockFlow
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Database database = new Database();

            using (SqlConnection connection = database.GetConnection())
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);

                int result = (int)command.ExecuteScalar();

                if (result > 0)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý veya þifre hatalý");
                }
               
            }
        }
    }
}
