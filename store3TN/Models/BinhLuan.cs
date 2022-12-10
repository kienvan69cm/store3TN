using System;
using System.ComponentModel;

namespace store3TN.Models
{
    public class BinhLuan
    {
        [DisplayName("Mã Bình Luận")]
        public int MaBL { get; set; }
        [DisplayName("Mã Sản Phẩm")]
        public int MaSP { get; set; }
        [DisplayName("Mã Tin")]
        public int MaTin { get; set; }
        [DisplayName("Mã Người Dùng")]
        public int MaND { get; set; }
        [DisplayName("Bình Luận")]
        public string BLuan { get; set; }
        [DisplayName("Ngày Bình Luận")]
        public DateTime NgayLap { get; set; }
    }
}