using AppName.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppName.Web.Infrastructure
{
	public class BaseController : Controller
	{
		protected void AddErrors(IEnumerable<ErrorMessage> errors)
		{
			foreach (var error in errors)
			{
				ModelState.AddModelError(error.PropertyName, error.Error);
			}
		}
	}
}