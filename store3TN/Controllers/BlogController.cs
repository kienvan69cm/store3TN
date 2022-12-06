using Microsoft.AspNetCore.Mvc;
using store3TN.Data;
using store3TN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store3TN.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index(int page = 1)
        {
            List<TinTuc> list = GetTinTuc.getAllTinTuc();
            const int pageSize = 4;
            if (page < 1) page = 1;
            int recsCount = list.Count();
            var pager = new Pager(recsCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var data = list.Skip(recSkip).Take(pageSize).ToList();
            this.ViewBag.Pager = pager;
            this.ViewBag.TinTucPhoBien = GetTinTuc.getTinTucPhoBien();
            return View(data);
        }
    }
}
