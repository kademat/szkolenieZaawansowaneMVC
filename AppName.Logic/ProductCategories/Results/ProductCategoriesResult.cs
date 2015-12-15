using AppName.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Logic.ProductCategories.Results
{
    public class ProductCategoriesResult : BaseResult
    {
        public IQueryable<ProductCategory> Categories { get; set; }
    }
}
