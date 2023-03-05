using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    internal class Sach
    {
        private string id;
        private string name;
        private double price;
        private string tg_id;
        private string tl_id;
        private string nxb_id;

        public Sach(
            string id, 
            string name, 
            double price, 
            string tg_id, 
            string tl_id, 
            string nxb_id)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Tg_id = tg_id;
            this.Tl_id = tl_id;
            this.Nxb_id = nxb_id;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Tg_id { get => tg_id; set => tg_id = value; }
        public string Tl_id { get => tl_id; set => tl_id = value; }
        public string Nxb_id { get => nxb_id; set => nxb_id = value; }
    }
}
