using AppName.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.EFDataAccess.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            //ToTable("Products");

            //Ignore(p => p.Description);

            Property(p => p.Description)
                //.HasColumnName("ProductDescription")
                .HasMaxLength(255);
        }
    }
}
