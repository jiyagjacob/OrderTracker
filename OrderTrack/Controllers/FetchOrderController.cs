using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderTrack.Controllers
{
	public class FetchOrderController : Controller
	{
		public IActionResult Index()
		{
			return View("~/Views/FetchOrder/FetchOrder.cshtml");
		}
		public IActionResult LoadMain()
		{
			return View("~/Views/FetchOrder/FetchOrder.cshtml");
		}
	}
}
