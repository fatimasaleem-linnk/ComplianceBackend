using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class ComplianceNotificationMassageConfiguration : IEntityTypeConfiguration<ComplianceNotificationMassage>
{
    public void Configure(EntityTypeBuilder<ComplianceNotificationMassage> builder)
    {
        builder.HasKey(s => s.Id);
    }
}
