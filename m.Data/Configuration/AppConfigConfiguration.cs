using m.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace m.Data.Configuration
{
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");  // gen ra ten bang la AppConfigs
            builder.HasKey(x => x.Key); // khai bao khoa chinh la truong key
            builder.Property(x => x.Value).IsRequired();    // khong duoc de trang khoa
        }
    }
}