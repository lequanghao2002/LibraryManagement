using QLThuVien.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QLThuVien.Modify
{
    internal class ModifyCTPhieuMuon
    {
        SqlDataAdapter dataAdapter;

        SqlCommand sqlCommand;

        DataTable dataTable;

        public ModifyCTPhieuMuon()
        {
            dataTable = new DataTable();
        }

        public DataTable getAllCTPhieuMuon()
        {
            string query = "select * from CTPhieuMuon";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }

            return dataTable;
        }

        public DataTable getAllCTPhieuMuonTheoDG(string id)
        {


            string query = "select ctpm.PhieuMuon_ID, ctpm.Sach_ID, ctpm.NgayMuon, ctpm.NgayTra, ctpm.GhiChu " +
                "from PhieuMuon pm, CTPhieuMuon ctpm " +
                "where pm.ID = ctpm.PhieuMuon_ID " +
                "and pm.DocGia_ID = '" + id + "'";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }

            return dataTable;

        }

        public bool insert(CTPhieuMuon entity)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "insert into CTPhieuMuon values (@PhieuMuon_ID,@Sach_ID,@NgayMuon,@NgayTra,@GhiChu)";

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@PhieuMuon_ID", SqlDbType.NVarChar).Value = entity.Pm_id;
                sqlCommand.Parameters.Add("@Sach_ID", SqlDbType.NVarChar).Value = entity.S_id;
                sqlCommand.Parameters.Add("@NgayMuon", SqlDbType.DateTime).Value = entity.BorrowingDate;
                sqlCommand.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value = entity.AppointmentDate;
                sqlCommand.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = entity.Note;

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

        public bool update(DateTime giaHan, string maSach, string phieuMuon)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "update CTPhieuMuon " +
                "set NgayTra = @NgayTra " +
                "where Sach_ID = @Sach_ID and PhieuMuon_ID = @PhieuMuon_ID";
            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@NgayTra", SqlDbType.NVarChar).Value = giaHan;
                sqlCommand.Parameters.Add("@Sach_ID", SqlDbType.NVarChar).Value = maSach;
                sqlCommand.Parameters.Add("@PhieuMuon_ID", SqlDbType.NVarChar).Value = phieuMuon;

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

        public bool delete(string idPhieuMuon, string idSach)
        {
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "delete from CTPhieuMuon where Sach_ID = @Sach_ID and PhieuMuon_ID = @PhieuMuon_ID";

            try
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@PhieuMuon_ID", SqlDbType.NVarChar).Value = idPhieuMuon;
                sqlCommand.Parameters.Add("@Sach_ID", SqlDbType.NVarChar).Value = idSach;

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

        public string getSachByID(string id)
        {
            string result = "";
            if (id != string.Empty)
            {
                SqlConnection sqlConnection = Connection.getConnection();

                string query = "select Ten from Sach where ID =@ID";

                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                result = sqlCommand.ExecuteScalar().ToString();

                sqlConnection.Close();

            }
            return result;
        }

        public bool checkMuonSach(string idPhieuMuon)
        {
            // --------- Tìm mã độc giả
            SqlConnection sqlConnection = Connection.getConnection();

            string query = "select DocGia_ID " +
                "from PhieuMuon " +
                "where ID = @idPhieuMuon";


            sqlConnection.Open();

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@idPhieuMuon", SqlDbType.NVarChar).Value = idPhieuMuon;

            string idDocGia = sqlCommand.ExecuteScalar().ToString();

            sqlConnection.Close();

            // --------- Kiểm tra số lượng sách mà độc giả đang mượn
            SqlConnection sqlConnection2 = Connection.getConnection();

            string query2 = "select count(*) " +
                "from DocGia dg, PhieuMuon pm, CTPhieuMuon ctpm " +
                "where dg.ID = pm.DocGia_ID and pm.ID = ctpm.PhieuMuon_ID " +
                "and dg.ID = @idDocGia";

            sqlConnection2.Open();

            sqlCommand = new SqlCommand(query2, sqlConnection2);
            sqlCommand.Parameters.Add("@idDocGia", SqlDbType.NVarChar).Value = idDocGia;

            int check = int.Parse(sqlCommand.ExecuteScalar().ToString());

            sqlConnection2.Close();
            if (check >= 3)
            {
                return false;
            }

            return true;
        }
    }
}
