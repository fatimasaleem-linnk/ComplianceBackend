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
            new()
            {
                Id = 1,
                NameEn = "Licensed Entity",
                NameAr = "المرخص له"
            },
            new()
            {
                Id = 2,
                NameEn = "Activity",
                NameAr ="النشاط"
            },
            new()
            {
                Id = 3,
                NameEn = "Plant Name",
                NameAr = "اسم المحطة"
            },
            new()
            {
                Id = 4,
                NameEn = "Location",
                NameAr = "الموقع"
            },

            new()
            {
                Id = 5,
                NameEn = "Quarter Planned For Visit",
                NameAr = "الربع المخطط له"

            },
            new()
            {
                Id = 6,
                NameEn = "Visit Type",
                NameAr = "نوع الزيارة"
            },

             new()
            {
                Id = 7,
                NameEn = "Plan Status",
                NameAr = "حالة الخطة"
            },

              new()
            {
                Id = 8,
                NameEn = "Visit Status",
                NameAr = "حالة الزيارة"
            },
            new()
            {
                Id = 9,
                NameEn = "Attachment Type",
                NameAr = "نوع الملفات"
            },
            new()
            {
                Id = 10,
                NameEn = "Report Type",
                NameAr = "نوع التقرير"
            },
            new()
            {
                Id = 11,
                NameEn = "Completion Status",
                NameAr = "حالة الإنجاز"
            },
            new()
            {
                Id = 12,
                NameEn = "Template Type",
                NameAr = "نوع النموذج"
            },
        });

    }
}
