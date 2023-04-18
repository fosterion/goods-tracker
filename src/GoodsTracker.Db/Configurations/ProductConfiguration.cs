using GoodsTracker.Db.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsTracker.Db.Configurations;

internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasIndex(_ => _.Id).IsUnique(true);
        builder.HasMany(_ => _.History)
            .WithOne(_ => _.Product)
            .HasForeignKey(_ => _.ProductId);
    }
}
