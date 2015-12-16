using AppName.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppName.Logic.ProductCategories.Results;
using AppName.Logic.Repositories;
using AppName.Domains;
using AppName.Logic.ProductCategories.Validators;

namespace AppName.Logic.ProductCategories
{
    public class ProductCategoryLogic : BaseLogic, IProductCategoryLogic
    {
        private IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryLogic(IProductCategoryRepository productCategoryRepository)
        {
            if (productCategoryRepository == null)
            {
                throw new ArgumentNullException("productCategoryRepository");
            }
        }

        public ProductCategoryResult Create(ProductCategory category)
        {
            if (category == null)
            {
                throw new ArgumentNullException("category");
            }

            var validator = new ProductCategoryValidator();

            var validatorResult = validator.Validate(category);

            if (validatorResult.IsValid == false)
            {
                return CreateFailureResult<ProductCategoryResult>(validatorResult.Errors);
            }

            _productCategoryRepository.Add(category);

            _productCategoryRepository.SaveChanges();

            return CreateSuccesResult<ProductCategoryResult>(r => r.Category = category);

        }

        public ProductCategoriesResult GetAllActive()
        {
            var query = _productCategoryRepository.GetAllActive();

            return CreateSuccesResult<ProductCategoriesResult>(r => r.Categories = query);
        }
    }
}
