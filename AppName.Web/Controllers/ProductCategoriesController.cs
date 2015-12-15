using AppName.EFDataAccess;
using AppName.Logic.Interfaces;
using AppName.Logic.ProductCategories;
using AppName.Web.ViewModels.ProductCategories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppName.Web.Controllers
{
    public class ProductCategoriesController : Controller
    {
        public IProductCategoryLogic ProductCategoryLogic
        {
            get
            {
                return new ProductCategoryLogic(new ProductCategoryRepository(new DataContext()));
            }
        }
        // GET: ProductCategories
        public ActionResult Index()
        {
            var result = ProductCategoryLogic.GetAllActive();

            if (result.Success == false)
            {
                return Content("Blad (test)");
            }

            var viewModel = new IndexViewModel();

            viewModel.Categories = Mapper.Map<IEnumerable<IndexItemViewModel>>(result.Categories);

            return View();
        }
    }
}