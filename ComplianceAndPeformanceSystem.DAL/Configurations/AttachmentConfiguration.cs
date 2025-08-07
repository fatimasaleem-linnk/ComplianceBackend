using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
{
    public void Configure(EntityTypeBuilder<Attachment> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Id).ValueGeneratedOnAdd();


        builder.HasIndex(s => s.AttachmentGuid).IsUnique();


        builder.HasOne(d => d.AttachmentType)
                .WithMany(p => p.AttachmentTypes)
                .HasForeignKey(d => d.AttachmentTypeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Attachments_LookupValue_AttachmentTypeId");

    }
}
