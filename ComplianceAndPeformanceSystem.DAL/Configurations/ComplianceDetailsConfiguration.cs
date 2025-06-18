using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Configurations;

public class ComplianceDetailsConfiguration : IEntityTypeConfiguration<ComplianceDetails>
{
    public void Configure(EntityTypeBuilder<ComplianceDetails> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Seq).ValueGeneratedOnAdd();


        builder.HasOne(d => d.QuarterPlannedForVisit)
                .WithMany(p => p.QuarterPlannedForVisits)
                .HasForeignKey(d => d.QuarterPlannedForVisitId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ComplianceDetails_QuarterPlannedForVisitId");

        builder.HasOne(d => d.Activity)
               .WithMany(p => p.Activities)
               .HasForeignKey(d => d.ActivityId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_ComplianceDetails_ActivityId");


        builder.HasOne(d => d.LicensedEntity)
               .WithMany(p => p.LicensedEntities)
               .HasForeignKey(d => d.LicensedEntityId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_ComplianceDetails_LicensedEntityId");


        builder.HasOne(d => d.Location)
               .WithMany(p => p.Locations)
               .HasForeignKey(d => d.LocationId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_ComplianceDetails_LocationId");


        builder.HasOne(d => d.VisitType)
               .WithMany(p => p.VisitTypes)
               .HasForeignKey(d => d.VisitTypeId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_ComplianceDetails_VisitTypeId");

        builder.HasOne(d => d.PlantName)
               .WithMany(p => p.PlantNames)
               .HasForeignKey(d => d.PlantNameId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_ComplianceDetails_PlantNameId");

        builder.HasOne(d => d.ComplianceRequest)
               .WithMany(p => p.ComplianceDetails)
               .HasForeignKey(d => d.ComplianceRequestId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_ComplianceDetails_ComplianceRequestId");


    }
}
