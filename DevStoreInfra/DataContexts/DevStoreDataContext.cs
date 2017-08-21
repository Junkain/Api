using DevStore.Domain;
using DevStoreInfra.DataContexts.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevStoreInfra.DataContexts
{
    public class DevStoreDataContext : DbContext
    {
        public DevStoreDataContext() : base("DevStoreConnecionString")
        {
            Database.SetInitializer < DevStoreDataContext>(new DevStoreDataContextInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMaps());
            base.OnModelCreating(modelBuilder);
        }

    }

    public class DevStoreDataContextInitializer : DropCreateDatabaseIfModelChanges<DevStoreDataContext>
    {
        protected override void Seed(DevStoreDataContext context)
        {
            context.Categories.Add(new Category { Id = 1, Title = "Informática"});
            context.Categories.Add(new Category { Id = 2, Title = "Games" });
            context.Categories.Add(new Category { Id = 3, Title = "Papelaria" });
            context.SaveChanges();

            context.Products.Add(new Product { Id = 1, CategoryId = 1, IsActive = true, Price=2, Title="Monitor"});
            context.Products.Add(new Product { Id = 2, CategoryId = 2, IsActive = true, Price = 10, Title = "Ps4" });
            context.Products.Add(new Product { Id = 3, CategoryId = 3, IsActive = true, Price = 4, Title = "Caderno" });
            context.SaveChanges();
        }
    }
}
