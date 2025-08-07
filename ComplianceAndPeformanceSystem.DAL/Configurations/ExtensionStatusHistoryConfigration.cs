using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class ExtensionStatusHistoryConfigration : IEntityTypeConfiguration<ExtensionStatusHistory>
{
    public void Configure(EntityTypeBuilder<ExtensionStatusHistory> builder)
    {
        builder.HasKey(s => s.Id);
        builder.HasOne(d => d.Request)
                .WithMany(p => p.StatusHistories)
                .HasForeignKey(d => d.RequestId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_StatusHistories_RequestId");
    }
}
