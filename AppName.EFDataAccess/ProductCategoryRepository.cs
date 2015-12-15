using AppName.Domains;
using AppName.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AppName.EFDataAccess
{
    public class ProductCategoryRepository : BaseRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(DataContext db)
            : base(db)        {        }

        protected override DbSet<ProductCategory> DbSet
        {
            get
            {
                return _db.ProductCategories;
            }
        }
    }
}
