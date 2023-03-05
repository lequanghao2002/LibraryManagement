using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    internal class PhieuMuon
    {
        private string id;
        private string dg_id;

        public PhieuMuon(string id, string dg_id)
        {
            this.Id = id;
            this.Dg_id = dg_id;
        }

        public string Id { get => id; set => id = value; }
        public string Dg_id { get => dg_id; set => dg_id = value; }
    }
}
