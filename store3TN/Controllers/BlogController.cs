using Microsoft.AspNetCore.Mvc;
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
		public IActionResult Index()
		{
			return View();
		}
	}
}
