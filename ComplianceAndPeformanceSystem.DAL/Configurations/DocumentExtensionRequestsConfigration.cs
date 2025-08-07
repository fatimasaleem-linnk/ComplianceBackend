using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class DocumentExtensionRequestsConfigration : IEntityTypeConfiguration<DocumentExtensionRequest>
{
    public void Configure(EntityTypeBuilder<DocumentExtensionRequest> builder)
    {
        builder.HasKey(s => s.Id);
        builder.HasOne(d => d.ComplianceDetails);
    }
}
