using Microsoft.EntityFrameworkCore;
using ComplianceAndPeformanceSystem.Core.Entities;

namespace ComplianceAndPeformanceSystem.DAL;

public interface IComplianceAndPeformanceDbContext
{
    DbSet<CategoryLookup> CategoryLookup { get; set; }
    DbSet<LookupValue> LookupValue { get; set; }
    DbSet<ComplianceApproval> ComplianceApproval { get; set; }
    DbSet<ComplianceDetails> ComplianceDetails { get; set; }
    DbSet<ComplianceNotificationMassage> ComplianceNotificationMassage { get; set; }
    DbSet<ComplianceRequest> ComplianceRequest { get; set; }
    DbSet<ComplianceRequestActivity> ComplianceRequestActivity { get; set; }
    DbSet<ComplianceSpecialist> ComplianceSpecialist { get; set; }
    DbSet<ComplianceVisitSpecialist> ComplianceVisitSpecialist { get; set; }
    DbSet<VisitSurveyAnswer> VisitSurveyAnswer { get; set; }
    DbSet<VisitSurveyQuestion> VisitSurveyQuestion { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());

}
