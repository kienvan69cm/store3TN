using System;
using System.ComponentModel;

namespace store3TN.Models
{
    public class SanPham
    {
        [DisplayName("Mã Sản Phẩm")]
        public int MaSP { get; set; }
        [DisplayName("Mã Loại Sản Phẩm")]
        public int MaLSP { get; set; }
        [DisplayName("Tên Sản Phẩm")]
        public string TenSP { get; set; }
        [DisplayName("Tên Series")]
        public string TenSeries { get; set; }
        [DisplayName("Chi Tiết")]
        public string ChiTiet { get; set; }
        [DisplayName("RAM")]
        public string RAM { get; set; }
        [DisplayName("Dung Lượng")]
        public string DungLuong { get; set; }
        [DisplayName("Màu Sắc")]
        public string MauSac { get; set; }
        [DisplayName("Giá Gốc")]
        public decimal GiaGoc { get; set; }
        [DisplayName("Giá Bán")]
        public decimal GiaBan { get; set; }
        [DisplayName("Số Lượng")]
        public int SoLuong { get; set; }
        [DisplayName("Hình Ảnh")]
        public string HinhAnh { get; set; }
        [DisplayName("Mô Tả")]
        public string MoTa { get; set; }
        [DisplayName("New")]
        public int New { get; set; }
        [DisplayName("Hot")]
        public int Hot { get; set; }
        [DisplayName("Số Sao")]
        public int SoSao { get; set; }
        [DisplayName("Số Đánh Giá")]
        public int SoDanhGia { get; set; }
    }
}
