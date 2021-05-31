using m.Data.Configuration;
using m.Data.Entity;
using m.Data.Extensions;
using Microsoft.EntityFrameworkCore;

namespace m.Data.EF
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration table
            // c1 add truc tiep cac config bang vao day
            // c2 tao class config rieng cho tung bang. khai bao vao day
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());  // khai bao tung class configuration cho bang

            modelBuilder.ApplyConfiguration(new CartConfiguration());

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            modelBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());

            modelBuilder.ApplyConfiguration(new ContactConfiguration());

            modelBuilder.ApplyConfiguration(new LanguageConfiguration());

            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());

            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());

            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());

            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());

            modelBuilder.ApplyConfiguration(new PromotionConfiguration());

            modelBuilder.ApplyConfiguration(new TransactionConfiguration());

            // Data seeding table
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }

        // khai bao cac bang trong entity
        public DbSet<Product> Products;

        public DbSet<Category> Categories;
    }
}