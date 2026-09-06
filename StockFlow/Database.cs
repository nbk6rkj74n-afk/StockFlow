using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace StockFlow
{
    public class Database
    {
        private string connectionString =
            @"Server=ZEY;Database=StockFlow;Trusted_Connection=True;TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}