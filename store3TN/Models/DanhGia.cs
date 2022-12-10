using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace store3TN.Models
{
    public class DanhGia
    {
        public int MaDG { get; set; }
        public int MaSP { get; set; }
        public int MaND { get; set; }
        public int SoSao { get; set; }
        public string NoiDung { get; set; }
        public DateTime NgayDanhGia { get; set; }
    }
}