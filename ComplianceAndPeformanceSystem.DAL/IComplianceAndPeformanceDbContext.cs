using ComplianceAndPeformanceSystem.Core.Entities;
using ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit;
using Microsoft.EntityFrameworkCore;

namespace ComplianceAndPeformanceSystem.DAL;

public interface IComplianceAndPeformanceDbContext
{
    DbSet<Attachment> Attachments { get; set; }
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
    DbSet<DocumentExtensionRequest> DocumentExtensionRequest { get; set; }
    DbSet<ExtensionStatusHistory> ExtensionStatusHistories { get; set; }
    DbSet<VisitStatusHistory> VisitStatusHistories { get; set; }
    DbSet<RescheduleRequest> RescheduleRequests { get; set; }
    DbSet<ComplianceVisitDisclosure> ComplianceVisitDisclosure { get; set; }

    DbSet<ReportCategory> ReportCategories { get; set; }
    DbSet<ReportSubCategory> ReportSubCategories { get; set; }
    DbSet<ReportEntries> ReportEntries { get; set; }
    DbSet<Auditors> Auditors { get; set; }
    DbSet<LicenseParticipant> LicenseParticipants { get; set; }
    DbSet<PreviousRecommendations> PreviousRecommendations { get; set; }
    DbSet<Questaion> Questaions { get; set; }
    DbSet<ComplianceReport> ComplianceReports { get; set; }
    DbSet<ReportRequestActivity> ReportRequestActivities { get; set; }

    DbSet<CorrectiveEvidence> CorrectiveEvidences { get; set; }
    DbSet<CorrectiveActionPlan> CorrectiveActionPlans { get; set; }
    DbSet<ComplianceReportReview> ComplianceReportReviews { get; set; }
    DbSet<ActivityLog> ActivityLogs { get; set; }
    DbSet<Template> Templates { get; set; }
    DbSet<TeamShortage> TeamShortages { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());

}
