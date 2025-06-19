using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class ComplianceVisitDisclosureConfiguration : IEntityTypeConfiguration<ComplianceVisitDisclosure>
{
    public void Configure(EntityTypeBuilder<ComplianceVisitDisclosure> builder)
    {
        builder.HasKey(s => s.Id);

        builder.HasOne(d => d.ComplianceVisitSpecialist)
                .WithOne(p => p.ComplianceVisitDisclosure)
                .HasForeignKey<ComplianceVisitDisclosure>(d => d.ComplianceVisitSpecialistId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ComplianceVisitDisclosure_ComplianceVisitSpecialistId");
    }
}
