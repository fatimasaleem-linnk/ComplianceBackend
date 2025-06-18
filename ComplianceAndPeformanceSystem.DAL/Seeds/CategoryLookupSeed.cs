using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Seeds;

public class CategoryLookupSeed : IEntityTypeConfiguration<CategoryLookup>
{
    public void Configure(EntityTypeBuilder<CategoryLookup> builder)
    {
        builder.HasData(new List<CategoryLookup>()
        {
            new CategoryLookup()
            {
                Id = 1,
                NameEn = "Licensed Entity",
                NameAr = "المرخص له"
            },
            new CategoryLookup()
            {
                Id = 2,
                NameEn = "Activity",
                NameAr ="النشاط"
            },
            new CategoryLookup()
            {
                Id = 3,
                NameEn = "Plant Name",
                NameAr = "اسم المحطة"
            },
            new CategoryLookup()
            {
                Id = 4,
                NameEn = "Location",
                NameAr = "الموقع"
            },

            new CategoryLookup()
            {
                Id = 5,
                NameEn = "Quarter Planned For Visit",
                NameAr = "الربع المخطط له"

            },
            new CategoryLookup()
            {
                Id = 6,
                NameEn = "Visit Type",
                NameAr = "نوع الزيارة"
            },

             new CategoryLookup()
            {
                Id = 7,
                NameEn = "Plan Status",
                NameAr = "حالة الخطة"
            },

              new CategoryLookup()
            {
                Id = 8,
                NameEn = "Visit Status",
                NameAr = "حالة الزيارة"
            },
        });

    }
}
