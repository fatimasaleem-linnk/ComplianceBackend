using Microsoft.AspNetCore.Http;

namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class ComplianceReportDto
{
    public Guid ComplianceDetailId { get; set; }
    public Guid Id { get; set; }
    public int ReportTypeID { get; set; }           // نوع التقرير (Initial/Final)
    public string? ReportTypeName { get; set; }
    public string? LicenseEntityName { get; set; }
    public string ReportNumber { get; set; } = $"RPT-{DateTime.Today.Year}-{DateTime.Today.Month:D2}-{new Random().Next(1000, 9999)}";    // الرقم التعريفي (readonly/auto-generated)
    public long VisitTypeID { get; set; }            // نوع الزيارة
    public string? VisitTypeName { get; set; }
    public string? VisitReferenceNumber{ get; set; }
    public long LicenseID { get; set; }             // المرخص له
    public string? FacilityOrLine { get; set; }       // المصنع أو خط الأنابيب
    public string? Activity { get; set; }             // النشاط
    public string? SiteName { get; set; }             // موقع (اسم الموقع)
    public string? InspectionScope { get; set; }      // نطاق التفتيش
    public int LocationID { get; set; }   // محافظة الترخيص (مقاطعة)
    public string? LocationName { get; set; }
    public string? LicenseNumber { get; set; }            // معرف الترخيص

    public DateTime? CommercialOperationDate { get; set; }   // تاريخ التشغيل التجاري
    public DateTime? LicenseIssueDate { get; set; }           // تاريخ إصدار الترخيص
    public DateTime? VisitDate { get; set; }         // تاريخ الزيارة

    public virtual ICollection<AuditorsDto>? Auditors { get; set; }   // أسماء المراجعون
    public virtual ICollection<LicenseParticipantDto>? Participants { get; set; }   // المشاركون من الجهة
    public virtual ICollection<QuestaionDto>? Questaions { get; set; }
    public virtual PreviousRecommendationsDto? PreviousRecommendations { get; set; }
    public List<IFormFile>? Attachments { get; set; }
    public virtual List<AttachmentDto>? AttachmentsList { get; set; }

    public string? AuditorsJS { get; set; }
    public string? ParticipantsJS { get; set; }
    public string? PreviousJS { get; set; }
    public string? QuestaionsJS { get; set; }

    public string? Recommendation { get; set; }
    public string? Notes { get; set; }
    public bool? IsDeleted { get; set; }

    public string? CreatedByID { get; set; }
    public DateTime CreatedOn { get; set; }
    public string? ModifiedByID { get; set; }

    public DateTime ModifiedOn { get; set; }
    public bool? IsDraft { get; set; } = false;
    public int? ReportStatusID { get; set; } 
    public string? ReportStatusName { get; set; } 

}
