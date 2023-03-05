using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.Model;

namespace QLThuVien.Modify
{
    internal class ModifyTheLoai
    {
        SqlDataAdapter dataAdapter;

        SqlCommand sqlCommand;

        DataTable dataTable;

        public ModifyTheLoai()
        {
            dataTable = new DataTable();
        }

        public DataTable getAllTheLoai()
        {

            string query = "select * from TheLoai";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }

            return dataTable;
        }

        public string createID()
        {
            string newID = "";
            if (dataTable.Rows.Count <= 0)
            {
                newID = "TL001";
            }
            else
            {
                int id;
                newID = "TL";

                id = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(2, 3));
                id++;

                if (id < 10)
                {
                    newID += "00";
                }
                else if (id < 100)
                {
                    newID += "0";
                }

                newID += id.ToString();

            }
            return newID;
        }

        public bool insert(TheLoai entity)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "insert into TheLoai values (@ID,@Ten)";

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = entity.Id;
                sqlCommand.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = entity.Name;

                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }

            return true;
        }

        public bool update(TheLoai entity)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "update TheLoai " +
                "set Ten = @Ten " +
                "where ID = @ID";
            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = entity.Id;
                sqlCommand.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = entity.Name;

                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }

            return true;
        }

        public bool delete(string id)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "delete from TheLoai where ID = @ID";

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }

            return true;
        }
    }
}
