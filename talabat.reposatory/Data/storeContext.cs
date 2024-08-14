using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using talabat.core.entites;
using talabat.reposatory.Data.configration;

namespace talabat.reposatory.Data
{
    public class storeContext:DbContext 

    {
        public storeContext(DbContextOptions<storeContext>options):base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //oldway   //modelBuilder.ApplyConfiguration(new productConfigration());
            //oldway   //modelBuilder.ApplyConfiguration(new ProductBrandConfiguration());
            //oldway   //modelBuilder.ApplyConfiguration(new ProductTypeConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<product> Product { get; set; }
        public DbSet<ProductBrand> productBrands { get; set; }
        public DbSet<ProductType> productTypes { get; set; }
    }
}
