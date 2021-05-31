using m.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace m.Data.Configuration
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            // config cho bang nay la bang trung gian cua 2 bang quan he nhieu nhieu
            builder.ToTable("ProductInCategories");

            builder.HasKey(t => new { t.CategoryId, t.ProductId });     // tao object moi lam khoa chinh. La 2 truong trong bang

            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductInCategories).HasForeignKey(pc => pc.ProductId); // tao lien ket den bang product

            builder.HasOne(t => t.Category).WithMany(pc => pc.ProductInCategories).HasForeignKey(pc => pc.CategoryId); // tao lien ket den bang category
        }
    }
}