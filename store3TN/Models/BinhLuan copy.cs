using System;
using System.ComponentModel;

namespace store3TN.Models
{
    public class DanhGia
    {
        [DisplayName("Mã Sản Phẩm")]
        public int MaSP { get; set; }
        [DisplayName("Mã Người Dùng")]
        public int MaND { get; set; }
        [DisplayName("Số Sao")]
        public int SoSao { get; set; }
        [DisplayName("Nội Dung")]
        public string NoiDung { get; set; }
        [DisplayName("Ngày Đánh Giá")]
        public DateTime NgayDanhGia { get; set; }
    }
}