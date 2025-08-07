using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Seeds
{
    public class ReportSubCategorySeed : IEntityTypeConfiguration<ReportSubCategory>
    {
        public void Configure(EntityTypeBuilder<ReportSubCategory> builder)
        {
            // Seed SubCategories
            builder.HasData(new List<ReportSubCategory>()
            {
            new() { Id = 11, Name = "Compliance", NameAr = "الامتثال", CategoryID = 1 },
            new() { Id = 12, Name = "Licensing requirements", NameAr = "متطلبات الترخيص", CategoryID = 1 },
            new() { Id = 13, Name = "Organization & capabilities", NameAr = "الهيكل التنظيمي والقدرات", CategoryID = 1 },

            new() { Id = 21, Name = "Accounting requirements", NameAr = "متطلبات المحاسبة", CategoryID = 2 },
            new() { Id = 22, Name = "Financial information", NameAr = "المعلومات المالية", CategoryID = 2 },

            new() { Id = 31, Name = "Organization & capabilities", NameAr = "الهيكل التنظيمي والقدرات", CategoryID = 3 },
            new() { Id = 32, Name = "Regulatory requirements", NameAr = "المتطلبات التنظيمية", CategoryID = 3 },

            new() { Id = 41, Name = "Consumer information", NameAr = "معلومات المستهلك", CategoryID = 4 },
            new() { Id = 42, Name = "Consumer satisfaction", NameAr = "رضا المستهلك", CategoryID = 4 }
            });
        }
    }
}
