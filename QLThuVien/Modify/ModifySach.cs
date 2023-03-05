using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.Model;
using System.Drawing;

namespace QLThuVien.Modify
{
    internal class ModifySach
    {
        SqlDataAdapter dataAdapter;

        SqlCommand sqlCommand;

        DataTable dataTable;

        public ModifySach()
        {
            dataTable = new DataTable();
        }

        public DataTable getAllSach(string id = null, string ten = null)
        {
            if (id != null)
            {
                string query = "select * from Sach where ID like '%" + id + "%'";

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
                string query = "select * from Sach where Ten like '%" + ten + "%'";

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
                string query = "select * from Sach";

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
            if (dataTable.Rows.Count <= 0)
            {
                newID = "S001";
            }
            else
            {
                int id;
                newID = "S";

                id = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][0].ToString().Substring(1, 3));
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

        public bool insert(Sach entity)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "insert into Sach values (@ID,@Ten,@Gia,@TacGia_ID,@TheLoai_ID,@NhaXuatBan_ID)";

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = entity.Id;
                sqlCommand.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = entity.Name;
                sqlCommand.Parameters.Add("@Gia", SqlDbType.Float).Value = entity.Price;
                sqlCommand.Parameters.Add("@TacGia_ID", SqlDbType.NVarChar).Value = entity.Tg_id;
                sqlCommand.Parameters.Add("@TheLoai_ID", SqlDbType.NVarChar).Value = entity.Tl_id;
                sqlCommand.Parameters.Add("@NhaXuatBan_ID", SqlDbType.NVarChar).Value = entity.Nxb_id;

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

        public bool update(Sach entity)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "update Sach " +
                "set Ten = @Ten, " +
                    "Gia = @Gia, " +
                    "TacGia_ID = @TacGia_ID, " +
                    "TheLoai_ID = @TheLoai_ID, " +
                    "NhaXuatBan_ID = @NhaXuatBan_ID " +
                "where ID = @ID";
            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = entity.Id;
                sqlCommand.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = entity.Name;
                sqlCommand.Parameters.Add("@Gia", SqlDbType.Float).Value = entity.Price;
                sqlCommand.Parameters.Add("@TacGia_ID", SqlDbType.NVarChar).Value = entity.Tg_id;
                sqlCommand.Parameters.Add("@TheLoai_ID", SqlDbType.NVarChar).Value = entity.Tl_id;
                sqlCommand.Parameters.Add("@NhaXuatBan_ID", SqlDbType.NVarChar).Value = entity.Nxb_id;

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

            string query = "delete from Sach where ID = @ID";

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

        public string getTacGiaByID(string id)
        {
            string result = "";
            if (id != string.Empty)
            {
                SqlConnection sqlConnection = Connection.getConnection();

                string query = "select HoTen from TacGia where ID =@ID";

                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                result = sqlCommand.ExecuteScalar().ToString();

                sqlConnection.Close();

            }
            return result;
        }

        public string getTheLoaiByID(string id)
        {
            string result = "";
            if (id != string.Empty)
            {
                SqlConnection sqlConnection = Connection.getConnection();

                string query = "select Ten from TheLoai where ID = @ID";

                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                result = sqlCommand.ExecuteScalar().ToString();

                sqlConnection.Close();

            }
            return result;
        }

        public string getNxbByID(string id)
        {
            string result = "";
            if (id != string.Empty)
            {
                SqlConnection sqlConnection = Connection.getConnection();

                string query = "select Ten from NhaXuatBan where ID = @ID";

                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                result = sqlCommand.ExecuteScalar().ToString();

                sqlConnection.Close();

            }
            return result;
        }

        public DataTable getAllSachDangMuon()
        {
            string query = "select s.ID, s.Ten, pm.ID, dg.ID, ctpm.NgayMuon, ctpm.NgayTra " +
                "from Sach s, CTPhieuMuon ctpm, PhieuMuon pm, DocGia dg " +
                "where s.ID = ctpm.Sach_ID and ctpm.PhieuMuon_ID = pm.ID and pm.DocGia_ID = dg.ID";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }

            return dataTable;
        }

        public DataTable getAllSachTreHan()
        {
            string query = "select s.ID, s.Ten, pm.ID, dg.ID, ctpm.NgayMuon, ctpm.NgayTra " +
                "from Sach s, CTPhieuMuon ctpm, PhieuMuon pm, DocGia dg " +
                "where s.ID = ctpm.Sach_ID and ctpm.PhieuMuon_ID = pm.ID and pm.DocGia_ID = dg.ID " +
                "and GETDATE() > NgayTra";

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
