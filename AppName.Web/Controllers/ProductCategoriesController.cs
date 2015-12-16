using AppName.Domains;
using AppName.EFDataAccess;
using AppName.Logic.Interfaces;
using AppName.Logic.ProductCategories;
using AppName.Web.Infrastructure;
using AppName.Web.ViewModels.ProductCategories;
using AutoMapper;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppName.Web.Controllers
{
    public class ProductCategoriesController : BaseController
    {
        [Dependency]
        public Lazy<IProductCategoryLogic> LazyProductCategoryLogic { get; set; }

        public IProductCategoryLogic ProductCategoryLogic
        {
            get
            {
                return LazyProductCategoryLogic.Value;
                //return new ProductCategoryLogic(new ProductCategoryRepository(new DataContext()));
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

            if (result.Success == false)
            {
                return Content("blad");
            }

            var viewModel = Mapper.Map<EditViewModel>(result.Category);



            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel viewModel)
        {
            if (ModelState.IsValid == false)
            {
                return View(viewModel);
            }

            var getResult = ProductCategoryLogic.GetById(viewModel.Id);

            if (getResult.Success == false)
            {
                return Content("Blad getResult.Success");
            }

            var category = Mapper.Map(viewModel, getResult.Category);

            var saveResult = ProductCategoryLogic.Save(category);

            if (saveResult.Success == false)
            {
                AddErrors(saveResult.Errors);
                return View(viewModel);
            }

            return RedirectToAction("Index");
        }
    }
}