using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Core.Entities;
using ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit;
using Microsoft.EntityFrameworkCore;

namespace ComplianceAndPeformanceSystem.DAL;

public class ComplianceAndPeformanceDbContext : DbContext, IComplianceAndPeformanceDbContext
{
    private readonly ICurrentUserService _currentUserService;


    public ComplianceAndPeformanceDbContext(DbContextOptions<ComplianceAndPeformanceDbContext> options)
          : base(options)
    {
    }
    public ComplianceAndPeformanceDbContext(DbContextOptions<ComplianceAndPeformanceDbContext> options, ICurrentUserService _currentUserService)
          : base(options)
    {
        this._currentUserService = _currentUserService;
    }
    public DbSet<Attachment> Attachments { get; set; }

    public DbSet<CategoryLookup> CategoryLookup { get; set; }
    public DbSet<LookupValue> LookupValue { get; set; }
    public DbSet<ComplianceApproval> ComplianceApproval { get; set; }
    public DbSet<ComplianceDetails> ComplianceDetails { get; set; }
    public DbSet<ComplianceNotificationMassage> ComplianceNotificationMassage { get; set; }
    public DbSet<ComplianceRequest> ComplianceRequest { get; set; }
    public DbSet<ComplianceRequestActivity> ComplianceRequestActivity { get; set; }
    public DbSet<ComplianceSpecialist> ComplianceSpecialist { get; set; }
    public DbSet<ComplianceVisitSpecialist> ComplianceVisitSpecialist { get; set; }
    public DbSet<VisitSurveyAnswer> VisitSurveyAnswer { get; set; }
    public DbSet<VisitSurveyQuestion> VisitSurveyQuestion { get; set; }

    public DbSet<DocumentExtensionRequest> DocumentExtensionRequest { get; set; }
    public DbSet<ExtensionStatusHistory> ExtensionStatusHistories { get; set; }
    public DbSet<VisitStatusHistory> VisitStatusHistories { get; set; }
    public DbSet<RescheduleRequest> RescheduleRequests { get; set; }
    public DbSet<ComplianceVisitDisclosure> ComplianceVisitDisclosure { get; set; }

    public DbSet<ReportCategory> ReportCategories { get; set; }
    public DbSet<ReportSubCategory> ReportSubCategories { get; set; }
    public DbSet<ReportEntries> ReportEntries { get; set; }
    public DbSet<Auditors> Auditors { get; set; }
    public DbSet<LicenseParticipant> LicenseParticipants { get; set; }
    public DbSet<PreviousRecommendations> PreviousRecommendations { get; set; }
    public DbSet<Questaion> Questaions { get; set; }
    public DbSet<ComplianceReport> ComplianceReports { get; set; }
    public DbSet<ReportRequestActivity> ReportRequestActivities { get; set; }
    public DbSet<CorrectiveEvidence> CorrectiveEvidences { get; set; }
    public DbSet<CorrectiveActionPlan> CorrectiveActionPlans { get; set; }
    public DbSet<ComplianceReportReview> ComplianceReportReviews { get; set; }
    public DbSet<ActivityLog> ActivityLogs { get; set; }
    public DbSet<Template> Templates { get; set; }
    public DbSet<TeamShortage> TeamShortages { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<TrackedEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedByID = _currentUserService.User.UserId;
                    entry.Entity.CreatedByEmail = _currentUserService.User.UserEmail;
                    entry.Entity.CreatedByUserName = _currentUserService.User.UserName;
                    entry.Entity.CreatedOn = DateTime.Now;
                    entry.Entity.ModifiedByID = _currentUserService.User.UserId;
                    entry.Entity.ModifiedByUserName = _currentUserService.User.UserName;
                    entry.Entity.ModifiedByEmail = _currentUserService.User.UserEmail;
                    entry.Entity.ModifiedOn = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.ModifiedByID = _currentUserService.User.UserId;
                    entry.Entity.ModifiedByUserName = _currentUserService.User.UserName;
                    entry.Entity.ModifiedByEmail = _currentUserService.User.UserEmail;
                    entry.Entity.ModifiedOn = DateTime.Now;
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     modelBuilder.ApplyConfigurationsFromAssembly(typeof(ComplianceAndPeformanceDbContext).Assembly);

        modelBuilder.Entity<TeamShortage>()
            .HasOne(t => t.ComplianceDetails)
            .WithMany() // If ComplianceDetails can have many shortage requests
            .HasForeignKey(t => t.ComplianceDetailsId);

        base.OnModelCreating(modelBuilder);
    }
}
