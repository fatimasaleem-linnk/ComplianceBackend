﻿namespace ComplianceAndPeformanceSystem.Contract.Dtos
{
    //public class ComplianceReportDto
    //{
    //    public Guid Id { get; set; }
    //    public int ReportTypeID { get; set; }           // نوع التقرير (Initial/Final)
    //    public string ReportTypeName { get; set; }
    //    public string ReportNumber { get; set; }         // الرقم التعريفي (readonly/auto-generated)
    //    public int VisitTypeID { get; set; }            // نوع الزيارة
    //    public string VisitTypeName { get; set; }
    //    public long LicenseID { get; set; }             // المرخص له
    //    public string FacilityOrLine { get; set; }       // المصنع أو خط الأنابيب
    //    public string Activity { get; set; }             // النشاط
    //    public string SiteName { get; set; }             // موقع (اسم الموقع)
    //    public string InspectionScope { get; set; }      // نطاق التفتيش
    //    public int LocationID { get; set; }   // محافظة الترخيص (مقاطعة)
    //    public string LocationName { get; set; }
    //    public string LicenseNumber { get; set; }            // معرف الترخيص

    //    public DateTime? CommercialOperationDate { get; set; }   // تاريخ التشغيل التجاري
    //    public DateTime? LicenseIssueDate { get; set; }           // تاريخ إصدار الترخيص
    //    public DateTime? VisitDate { get; set; }         // تاريخ الزيارة

    //    public virtual ICollection<Auditors>? Auditors { get; set; }   // أسماء المراجعون
    //    public virtual ICollection<LicenseParticipant>? Participants { get; set; }   // المشاركون من الجهة
    //    public virtual ICollection<Questaion>? Questaions { get; set; }
    //    public virtual PreviousRecommendations? PreviousRecommendations { get; set; }
    //    public List<IFormFile>? Attachments { get; set; }

    //    // for model [fromform]

    //    public string? AuditorsJS { get; set; }
    //    public string? ParticipantsJS { get; set; }
    //    public string? QuestaionsJS { get; set; }

    //    public string? Recommendation { get; set; }
    //    public string? Notes { get; set; }
    //    public bool? IsDeleted { get; set; }

    //    public string? CreatedByID { get; set; }
    //    public DateTime CreatedOn { get; set; }
    //    public string? ModifiedByID { get; set; }
    //    public DateTime ModifiedOn { get; set; }
    //}
    //public class PreviousRecommendations
    //{
    //    [Key]
    //    public int ID { get; set; } = new int();
    //    public DateTime? VisitDate { get; set; }
    //    public int? CompletionStatusID { get; set; }
    //    public string? Comments { get; set; }
    //    public string? Action { get; set; }

    //    public Guid ReportID { get; set; }
    //    [ForeignKey(nameof(ReportID))]
    //    public ComplianceReport? ComplianceReport { get; set; }
    //}

    //public class Questaion
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    public int? CategoryID { get; set; }
    //    public string? CategoryName { get; set; }

    //    public int? SubCategoryID { get; set; }
    //    public string? SubCategoryName { get; set; }

    //    public int? EntryID { get; set; }
    //    public string? EntryName { get; set; }

    //    public string? Grade { get; set; }
    //    public bool Evidence { get; set; } = false;
    //    public string? Comments { get; set; }

    //    public Guid ReportID { get; set; }
    //    [ForeignKey(nameof(ReportID))]
    //    public ComplianceReport? ComplianceReport { get; set; }
    //}

    //public class LicenseParticipant
    //{
    //    [Key]
    //    public int ID { get; set; } = new int();
    //    public string Name { get; set; }                 // الاسم
    //    public string Department { get; set; }           // القسم
    //    public string Position { get; set; }             // الوظيفة
    //    public string Phone { get; set; }                // الهاتف
    //    public string Email { get; set; }                // البريد

    //    public Guid ReportID { get; set; }
    //    [ForeignKey(nameof(ReportID))]
    //    public ComplianceReport? ComplianceReport { get; set; }
    //}

    //public class Auditors
    //{
    //    [Key]
    //    public int ID { get; set; } = new int();
    //    public string Name { get; set; }

    //    public Guid ReportID { get; set; }
    //    [ForeignKey(nameof(ReportID))]
    //    public ComplianceReport? ComplianceReport { get; set; }
    //}


}
