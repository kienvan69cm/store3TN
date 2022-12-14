using Microsoft.AspNetCore.Mvc;
using store3TN.Data;
using store3TN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store3TN.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("{MaSP}")]
        public IActionResult Index(int MaSP)
        {
            this.ViewBag.BLSP = GetBinhLuan.getAllBLSP();
            this.ViewBag.TLBL = GetBinhLuan.TLBL();
            this.ViewBag.TenND = GetNguoiDung.TenND();
            this.ViewBag.DanhGia = GetDanhGia.getAllDanhGia();
            this.ViewBag.SLDanhGia = GetDanhGia.SLDanhGia();
            return View(GetSanPham.getThongTinSanPham(MaSP));
        }
    }
}