using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class ComplianceVisitSpecialistConfiguration : IEntityTypeConfiguration<ComplianceVisitSpecialist>
{
    public void Configure(EntityTypeBuilder<ComplianceVisitSpecialist> builder)
    {
        builder.HasKey(s => s.Id);


        builder.HasOne(d => d.ComplianceDetails)
                .WithMany(p => p.ComplianceVisitSpecialists)
                .HasForeignKey(d => d.ComplianceDetailsId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ComplianceVisitSpecialist_ComplianceDetailsId");
    }
}
