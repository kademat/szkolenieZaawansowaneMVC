using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppName.Web.Infrastructure;

namespace AppName.Web.Controllers
{
	public class TestController : BaseController
	{
		//
		// GET: /Test/
		public ActionResult Index()
		{
			return View();
		}
	}
}