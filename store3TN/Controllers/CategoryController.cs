using Microsoft.AspNetCore.Mvc;
using store3TN.Data;
using store3TN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store3TN.Controllers
{
    [Route("category")]
    public class CategoryController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index(int page = 1)
        {
            // get all products
            List<SanPham> list = GetSanPham.getAllSanPham();
            const int pageSize = 9;
            if (page < 1) page = 1;
            int recsCount = list.Count();
            var pager = new Pager(recsCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var data = list.Skip(recSkip).Take(pageSize).ToList();
            this.ViewBag.Pager = pager;
            this.ViewBag.HotProducts = GetSanPham.getAllSanPhamHot();
            this.ViewBag.SLSP = GetSanPham.getSoLuongSanPham();
            this.ViewBag.RAM = GetSanPham.getRAM();
            this.ViewBag.DungLuong = GetSanPham.getDungLuong();
            // get all hot products
            List<SanPham> listHot = GetSanPham.getAllSanPhamHot();
            return View(data);
        }
    }
}