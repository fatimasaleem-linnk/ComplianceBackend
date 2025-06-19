using ComplianceAndPeformanceSystem.Core.Entities;
using ComplianceAndPeformanceSystem.Core.Entities.Request;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations
{
    class ComplianceVisitAttachmentConfiguration : IEntityTypeConfiguration<ComplianceVisitAttachment>
    {
        public void Configure(EntityTypeBuilder<ComplianceVisitAttachment> builder)
        {
            builder.HasKey(s => s.Id);
        }
    }
}
 

