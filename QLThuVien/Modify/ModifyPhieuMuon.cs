using QLThuVien.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Modify
{
    internal class ModifyPhieuMuon
    {
        SqlDataAdapter dataAdapter;

        SqlCommand sqlCommand;

        DataTable dataTable;

        public ModifyPhieuMuon()
        {
            dataTable = new DataTable();
        }

        public DataTable getAllPhieuMuon()
        {

            string query = "select * from PhieuMuon";

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
                newID = "PM001";
            }
            else
            {
                int id;
                newID = "PM";

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

        public bool insert(PhieuMuon entity)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "insert into PhieuMuon values (@ID,@DocGia_ID)";

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = entity.Id;
                sqlCommand.Parameters.Add("@DocGia_ID", SqlDbType.NVarChar).Value = entity.Dg_id;

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

        public bool update(PhieuMuon entity)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "update PhieuMuon " +
                "set DocGia_ID = @DocGia_ID " +
                "where ID = @ID";
            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = entity.Id;
                sqlCommand.Parameters.Add("@DocGia_ID", SqlDbType.NVarChar).Value = entity.Dg_id;

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

            string query = "delete from PhieuMuon where ID = @ID";

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

        public string getDocGiaByID(string id)
        {
            string result = "";
            if (id != string.Empty)
            {
                SqlConnection sqlConnection = Connection.getConnection();

                string query = "select HoTen from DocGia where ID =@ID";

                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                result = sqlCommand.ExecuteScalar().ToString();

                sqlConnection.Close();

            }
            return result;
        }

    }
}
