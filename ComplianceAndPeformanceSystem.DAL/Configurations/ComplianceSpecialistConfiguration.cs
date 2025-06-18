using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class ComplianceSpecialistConfiguration : IEntityTypeConfiguration<ComplianceSpecialist>
{
    public void Configure(EntityTypeBuilder<ComplianceSpecialist> builder)
    {
        builder.HasKey(s => s.Id);


        builder.HasOne(d => d.ComplianceRequest)
                .WithMany(p => p.ComplianceSpecialists)
                .HasForeignKey(d => d.ComplianceRequestId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ComplianceSpecialists_ComplianceRequestId");
    }
}
