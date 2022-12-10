using Microsoft.AspNetCore.Mvc;
using store3TN.Data;
using store3TN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store3TN.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        // route: cart/maND
        [Route("{MaND}")]
        public IActionResult Index(int MaND)
        {
            // get all products
            List<SanPham> list = GetSanPham.getAllSanPham();
            // covert list to dictionary with key is MaSP and value is list of SanPham
            Dictionary<int, SanPham> dict = new Dictionary<int, SanPham>();
            foreach (var item in list)
            {
                dict.Add(item.MaSP, item);
            }
            ViewBag.ListSanPham = dict;
            return View(GetGioHang.getGioHang(MaND));
        }
    }
}