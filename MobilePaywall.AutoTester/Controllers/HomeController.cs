using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilePaywall.AutoTester.Controllers
{
	public class HomeController : Controller
	{

		public ActionResult Index()
		{
			return this.Content("OK");
		}

	}
}
