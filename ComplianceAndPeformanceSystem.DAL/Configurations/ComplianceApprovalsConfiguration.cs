using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class ComplianceApprovalsConfiguration : IEntityTypeConfiguration<ComplianceApproval>
{
    public void Configure(EntityTypeBuilder<ComplianceApproval> builder)
    {
        builder.HasKey(s => s.Id);

        builder.HasOne(d => d.ComplianceRequest)
               .WithMany(p => p.ComplianceApprovals)
               .HasForeignKey(d => d.ComplianceRequestId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_ComplianceApprovals_ComplianceRequestId");


    }
}
