using AppName.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.EFDataAccess
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("Name=DefaultConnection")
        {

        }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.AddFromAssembly(typeof(DataContext).Assembly);

            //modelBuilder.Entity<Product>().ToTable("lk_Products");
        }

        private string _userName;

        public string UserName
        {
            get
            {
                return _userName ?? "system";
            }
            set
            {
                _userName = value;
            }
        }

        private DateTime? _now;

        public DateTime Now
        {
            get
            {
                return _now ?? DateTime.Now;
            }

            set
            {
                _now = value;
            }
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            ObjectContext ctx = ((IObjectContextAdapter)this).ObjectContext;

            foreach (var entity in ctx.ObjectStateManager.GetObjectStateEntries(EntityState.Modified))
            {
                var baseObject = entity.Entity as BaseObject;

                if(baseObject == null)
                {
                    continue;
                }
                
                baseObject.UpdatedDate = Now;
                baseObject.UpdatedUser = UserName;

            }

            foreach (var entity in ctx.ObjectStateManager.GetObjectStateEntries(EntityState.Added))
            {
                var baseObject = entity.Entity as BaseObject;

                if (baseObject == null)
                {
                    continue;
                }

                baseObject.UpdatedDate = Now;
                baseObject.UpdatedUser = UserName;
                baseObject.CreatedDate = Now;
                baseObject.CreatedUser = UserName;

            }
            return base.SaveChanges();

        }
    }
}
