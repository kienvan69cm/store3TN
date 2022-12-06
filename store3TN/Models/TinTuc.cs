using System;
using System.ComponentModel;

namespace store3TN.Models
{
    public class TinTuc
    {
        [DisplayName("Mã Tin Tức")]
        public int MaTin { get; set; }
        [DisplayName("Tiêu Đề")]
        public string TieuDe { get; set; }
        [DisplayName("Mô Tả Ngắn")]
        public string MoTaNgan { get; set; }
        [DisplayName("Nội Dung")]
        public string NoiDung { get; set; }
        [DisplayName("Hình Ảnh")]
        public string HinhAnh { get; set; }
        [DisplayName("Người Tạo")]
        public string NguoiTao { get; set; }
        [DisplayName("Lượt Xem")]
        public int LuotXem { get; set; }
        [DisplayName("Ngày Đăng")]
        public DateTime NgayDang { get; set; }
    }
}