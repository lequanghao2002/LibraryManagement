using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    internal class NXB
    {
        private string id;
        private string name;
        private string address;
        private string phoneNumber;

        public NXB(
            string id,
            string name,
            string address,
            string phoneNumber)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
