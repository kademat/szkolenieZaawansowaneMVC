using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Domains
{
    public class Product : BaseObject
    {
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual ProductCategory Category { get; set; }

        public string Description { get; set; }
    }
}
