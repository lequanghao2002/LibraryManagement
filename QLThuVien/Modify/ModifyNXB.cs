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
    internal class ModifyNXB
    {
        SqlDataAdapter dataAdapter;

        SqlCommand sqlCommand;

        DataTable dataTable;

        public ModifyNXB()
        {
            dataTable = new DataTable();
        }

        public DataTable getAllNXB()
        {

            string query = "select * from NhaXuatBan";

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
                newID = "NXB001";
            }
            else
            {
                int id;
                newID = "NXB";

                id = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(3, 3));
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

        public bool insert(NXB entity)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "insert into NhaXuatBan values (@ID,@Ten,@DiaChi,@SoDienThoai)";

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = entity.Id;
                sqlCommand.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = entity.Name;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = entity.Address;
                sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = entity.PhoneNumber;

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

        public bool update(NXB entity)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "update NhaXuatBan " +
                "set Ten = @Ten, " +
                    "DiaChi = @DiaChi, " +
                    "SoDienThoai = @SoDienThoai " +
                "where ID = @ID";
            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = entity.Id;
                sqlCommand.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = entity.Name;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = entity.Address;
                sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = entity.PhoneNumber;

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

            string query = "delete from NhaXuatBan where ID = @ID";

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
