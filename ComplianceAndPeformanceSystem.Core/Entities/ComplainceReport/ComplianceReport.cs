using System.ComponentModel.DataAnnotations.Schema;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ComplianceReport : TrackedEntity
{
    // Main Info
    public int ReportTypeID { get; set; }           // نوع التقرير (Initial/Final)
    public Guid ComplianceDetailId { get; set; }           // نوع التقرير (Initial/Final)
    public string ReportNumber { get; set; }         // الرقم التعريفي (readonly/auto-generated)
    public long VisitTypeID { get; set; }            // نوع الزيارة
    public long LicenseID { get; set; }             // المرخص له
    public string FacilityOrLine { get; set; }       // المصنع أو خط الأنابيب
    public string Activity { get; set; }             // النشاط
    public string SiteName { get; set; }             // موقع (اسم الموقع)
    public string InspectionScope { get; set; }      // نطاق التفتيش

    // License Info
    public int LocationID { get; set; }   // محافظة الترخيص (مقاطعة)
    public string LicenseNumber { get; set; }            // معرف الترخيص
    public DateTime? CommercialOperationDate { get; set; }   // تاريخ التشغيل التجاري
    public DateTime? LicenseIssueDate { get; set; }           // تاريخ إصدار الترخيص

    // Visit & Reviewers
    public DateTime? VisitDate { get; set; }         // تاريخ الزيارة

    public virtual ICollection<Auditors>? Auditors { get; set; }   // أسماء المراجعون
    public virtual ICollection<LicenseParticipant>? Participants { get; set; }   // License Participants

    public string? Recommendation { get; set; }
    public string? Notes { get; set; }

    public virtual ICollection<Questaion>? Questaions { get; set; }
    public virtual PreviousRecommendations? PreviousRecommendations { get; set; }

    public ICollection<ReportRequestActivity> ReportActivities { get; set; }
    [ForeignKey(nameof(ComplianceDetailId))]
    public virtual ComplianceDetails? ComplianceDetails { get; set; }
    public int? ReportStatusID { get; set; }
}
