using AppName.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppName.Logic.ProductCategories.Results;
using AppName.Logic.Repositories;

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

        public ProductCategoriesResult GetAllActive()
        {
            var query = _productCategoryRepository.GetAllActive();

            return CreateSuccesResult<ProductCategoriesResult>(r => r.Categories = query);
        }
    }
}
