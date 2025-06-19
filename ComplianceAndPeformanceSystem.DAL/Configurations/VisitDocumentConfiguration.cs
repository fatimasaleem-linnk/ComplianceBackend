using ComplianceAndPeformanceSystem.Core.Entities;
using ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations
{
    class VisitDocumentConfiguration : IEntityTypeConfiguration<VisitDocument>
    {
        public void Configure(EntityTypeBuilder<VisitDocument> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasOne(d => d.ComplianceDetails);
        }
    }
}
 

