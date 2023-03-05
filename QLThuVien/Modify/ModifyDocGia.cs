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
    internal class ModifyDocGia
    {
        // Truy xuất dữ liệu vào data table
        SqlDataAdapter dataAdapter;

        // Truy vấn, thêm, xóa, sửa CSDL
        SqlCommand sqlCommand;

        DataTable dataTable = new DataTable();

        public ModifyDocGia() {
        
        }

        public DataTable getAllDocGia(string id = null, string ten = null)
        {
            if(id != null)
            {
                string query = "select * from DocGia where ID like '%" + id + "%'";

                using (SqlConnection sqlConnection = Connection.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(query, sqlConnection);
                    dataAdapter.Fill(dataTable);

                    sqlConnection.Close();
                }

                return dataTable;
            }
            else if (ten != null)
            {
                string query = "select * from DocGia where HoTen like '%" + ten + "%'";

                using (SqlConnection sqlConnection = Connection.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(query, sqlConnection);
                    dataAdapter.Fill(dataTable);

                    sqlConnection.Close();
                }

                return dataTable;
            }
            else
            {
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

        public string createID()
        {
            string newID = "";
            if(dataTable.Rows.Count <= 0)
            {
                newID = "DG001";
            }
            else
            {
                int id;
                newID = "DG";

                id = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(2,3));
                id++;

                if(id < 10)
                {
                    newID += "00";
                }
                else if(id < 100)
                {
                    newID += "0";
                }

                newID += id.ToString();

            }
            return newID;
        }

        public bool insert(DocGia entity)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "insert into DocGia values (@ID,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@SoDienThoai,@NgayTao,@NgayHet)";

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = entity.Id;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = entity.Name;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = entity.DateOfBirth.ToShortDateString();
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = entity.Sex;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = entity.Address;
                sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = entity.PhoneNumber;
                sqlCommand.Parameters.Add("@NgayTao", SqlDbType.DateTime).Value = entity.DateCreated.ToShortDateString();
                sqlCommand.Parameters.Add("@NgayHet", SqlDbType.DateTime).Value = entity.DateExpiration.ToShortDateString();

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

        public bool update(DocGia entity)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "update DocGia " +
                "set HoTen = @HoTen, " +
                    "NgaySinh = @NgaySinh, " +
                    "GioiTinh = @GioiTinh, " +
                    "DiaChi = @DiaChi, " +
                    "SoDienThoai = @SoDienThoai," +
                    "NgayTao = @NgayTao, " +
                    "NgayHet = @NgayHet " +
                "where ID = @ID";

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = entity.Id;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = entity.Name;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = entity.DateOfBirth.ToShortDateString();
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = entity.Sex;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = entity.Address;
                sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = entity.PhoneNumber;
                sqlCommand.Parameters.Add("@NgayTao", SqlDbType.DateTime).Value = entity.DateCreated.ToShortDateString();
                sqlCommand.Parameters.Add("@NgayHet", SqlDbType.DateTime).Value = entity.DateExpiration.ToShortDateString();

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

            string query = "delete from DocGia where ID = @ID";

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
