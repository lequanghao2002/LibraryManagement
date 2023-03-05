using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien
{
    internal class DocGia
    {
        private string id;
        private string name;
        private DateTime dateOfBirth;
        private string sex;
        private string address;
        private string phoneNumber;
        private DateTime dateCreated;
        private DateTime dateExpiration;

        public DocGia(string id, string name, 
            DateTime dateOfBirth, 
            string sex, 
            string address, 
            string phoneNumber, 
            DateTime dateCreated, 
            DateTime dateExpiration)
        {
            this.Id = id;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Sex = sex;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.DateCreated = dateCreated;
            this.DateExpiration = dateExpiration;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public DateTime DateExpiration { get => dateExpiration; set => dateExpiration = value; }
    }
}
