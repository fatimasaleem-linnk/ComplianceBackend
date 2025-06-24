using Microsoft.EntityFrameworkCore;
using ComplianceAndPeformanceSystem.Core.Entities;
using ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit;

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
    DbSet<VisitDocument> VisitDocuments { get; set; }
    DbSet<DocumentExtensionRequest> DocumentExtensionRequest { get; set; }
    DbSet<ExtensionStatusHistory> ExtensionStatusHistories { get; set; }
    DbSet<VisitStatusHistory> VisitStatusHistories  { get; set; }
    DbSet<RescheduleRequest> RescheduleRequests   { get; set; }
    DbSet<ComplianceVisitDisclosure> ComplianceVisitDisclosure{ get; set; }



    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());

}
