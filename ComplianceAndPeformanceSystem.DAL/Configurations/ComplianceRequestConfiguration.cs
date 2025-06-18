using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class ComplianceRequestConfiguration : IEntityTypeConfiguration<ComplianceRequest>
{
    public void Configure(EntityTypeBuilder<ComplianceRequest> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Seq).ValueGeneratedOnAdd();

        builder.HasIndex(s => s.AssignTaskNameAr);
        builder.HasIndex(s => s.AssignTaskNameEn);


        builder.HasOne(d => d.Status)
            .WithMany(p => p.Status)
            .HasForeignKey(d => d.StatusId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_ComplianceRequest_StatusId");
    }
}
