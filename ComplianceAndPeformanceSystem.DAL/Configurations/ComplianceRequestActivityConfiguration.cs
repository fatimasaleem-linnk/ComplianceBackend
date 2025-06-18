using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class ComplianceRequestActivityConfiguration : IEntityTypeConfiguration<ComplianceRequestActivity>
{
    public void Configure(EntityTypeBuilder<ComplianceRequestActivity> builder)
    {
        builder.HasKey(s => s.Id);


        builder.HasOne(d => d.ComplianceRequest)
                .WithMany(p => p.ComplianceRequestActivities)
                .HasForeignKey(d => d.ComplianceRequestId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ComplianceRequestActivity_ComplianceRequestId");
    }
}
