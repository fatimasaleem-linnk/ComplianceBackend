using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class VisitSurveyQuestionConfiguration : IEntityTypeConfiguration<VisitSurveyQuestion>
{
    public void Configure(EntityTypeBuilder<VisitSurveyQuestion> builder)
    {
        builder.HasKey(s => s.Id);

    }
}
