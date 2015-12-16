using AppName.Domains;
using AppName.Logic.ProductCategories.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Logic.Interfaces
{
    public interface IProductCategoryLogic : ILogic
    {
        ProductCategoriesResult GetAllActive();

        ProductCategoryResult Create(ProductCategory category);
    }
}
