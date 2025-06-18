using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class CategoryLookupConfiguration : IEntityTypeConfiguration<CategoryLookup>
{
    public void Configure(EntityTypeBuilder<CategoryLookup> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Id).ValueGeneratedOnAdd();
        builder.HasIndex(s => s.NameAr);
        builder.HasIndex(s => s.NameEn);

    }
}
