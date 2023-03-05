using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    internal class CTPhieuMuon
    {
        private string pm_id;
        private string s_id;
        private DateTime borrowingDate;
        private DateTime appointmentDate;
        private string note;

        public CTPhieuMuon(
            string pm_id,
            string s_id,
            DateTime borrowingDate,
            DateTime appointmentDate,
            string note)
        {
            this.Pm_id = pm_id;
            this.S_id = s_id;
            this.BorrowingDate = borrowingDate;
            this.AppointmentDate = appointmentDate;
            this.Note = note;
        }

        public string Pm_id { get => pm_id; set => pm_id = value; }
        public string S_id { get => s_id; set => s_id = value; }
        public DateTime BorrowingDate { get => borrowingDate; set => borrowingDate = value; }
        public DateTime AppointmentDate { get => appointmentDate; set => appointmentDate = value; }
        public string Note { get => note; set => note = value; }
    }
}
