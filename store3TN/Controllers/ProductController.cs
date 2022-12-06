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
        [Route("index")]
        [Route("")]
        public IActionResult Index(int MaSP)
        {
            return View(GetSanPham.getThongTinSanPham(MaSP));
        }
    }
}