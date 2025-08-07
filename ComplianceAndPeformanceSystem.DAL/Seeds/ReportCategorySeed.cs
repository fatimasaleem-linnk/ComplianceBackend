using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ComplianceAndPeformanceSystem.Core.Entities;

namespace ComplianceAndPeformanceSystem.DAL.Seeds
{
    public class ReportCategorySeed : IEntityTypeConfiguration<ReportCategory>
    {

        public void Configure(EntityTypeBuilder<ReportCategory> builder)
        {
            // Seed ReportCategories
            builder.HasData(new List<ReportCategory>()
            {
                new() { Id = 1, Name = "Legal & Regulation", NameAr = "القانونية والتنظيمية" },
                new() { Id = 2, Name = "Financial", NameAr = "مالي" },
                new() { Id = 3, Name = "Technical", NameAr = "فني" },
                new() { Id = 4, Name = "Consumer Service", NameAr = "خدمة المستهلك" }
            });
        }
    }
}
