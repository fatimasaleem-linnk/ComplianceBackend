using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class TemplateConfiguration : IEntityTypeConfiguration<Template>
{
    public void Configure(EntityTypeBuilder<Template> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Id).ValueGeneratedOnAdd();

        builder.HasOne(d => d.TemplateType)
                .WithMany(p => p.Templates)
                .HasForeignKey(d => d.TemplateTypeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Template_TemplateTypeId");
    }
}
