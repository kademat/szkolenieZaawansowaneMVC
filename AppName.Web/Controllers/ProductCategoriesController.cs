using AppName.Domains;
using AppName.EFDataAccess;
using AppName.Logic.Interfaces;
using AppName.Logic.ProductCategories;
using AppName.Web.Infrastructure;
using AppName.Web.ViewModels.ProductCategories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppName.Web.Controllers
{
    public class ProductCategoriesController : BaseController
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

            return View(viewModel);
        }

        public ActionResult Create()
        {
            return View(new CreateViewModel());
        }

        [HttpPost]
        public ActionResult Create(CreateViewModel viewModel)
        {
            if (ModelState.IsValid == false)
            {
                return View(viewModel);
            }

            var category = Mapper.Map<ProductCategory>(viewModel);

            var result = ProductCategoryLogic.Create(category);

            if (result.Success == false)
            {
                AddErrors(result.Errors);
                return View(viewModel);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var result = ProductCategoryLogic.GetById(id);

            if (result.Success)
            {
                return Content("blad");
            }

            return View();
        }
    }
}