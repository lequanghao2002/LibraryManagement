using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien
{
    internal class Modify
    {
        // Truy xuất dữ liệu vào data table
        SqlDataAdapter dataAdapter;
        public Modify() {
        
        }

        public DataTable getAllDocGia()
        {
            DataTable dataTable = new DataTable();

            string query = "select * from DocGia";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }

            return dataTable;
        }
    }
}
