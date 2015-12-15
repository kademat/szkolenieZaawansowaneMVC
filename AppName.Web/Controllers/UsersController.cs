using AppName.Web.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppName.Web.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View(new CreateViewModel());
        }

        [HttpPost]
        public ActionResult Create(CreateViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}