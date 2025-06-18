using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class VisitSurveyAnswerConfiguration : IEntityTypeConfiguration<VisitSurveyAnswer>
{
    public void Configure(EntityTypeBuilder<VisitSurveyAnswer> builder)
    {
        builder.HasKey(s => s.Id);


        builder.HasOne(d => d.ComplianceVisitSpecialist)
                .WithMany(p => p.VisitSurveyAnswers)
                .HasForeignKey(d => d.ComplianceVisitSpecialistId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_VisitSurveyAnswer_ComplianceVisitSpecialistId");


        builder.HasOne(d => d.VisitSurveyQuestion)
                .WithMany(p => p.VisitSurveyAnswers)
                .HasForeignKey(d => d.VisitSurveyQuestionId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_VisitSurveyAnswer_VisitSurveyQuestionId");
    }
}
