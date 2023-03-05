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
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string soDienThoai;
        private DateTime ngayTao;
        private DateTime ngayHetHan;

        public DocGia(
            string id, 
            string hoTen, 
            DateTime ngaySinh, 
            string gioiTinh, 
            string diaChi, 
            string soDienThoai, 
            DateTime ngayTao, 
            DateTime ngayHetHan)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.ngayTao = ngayTao;
            this.ngayHetHan = ngayHetHan;
        }

        public string Id { get => id; set => id = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
    }
}
