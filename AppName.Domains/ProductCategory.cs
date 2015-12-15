using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Domains
{
    public class ProductCategory : BaseObject
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
