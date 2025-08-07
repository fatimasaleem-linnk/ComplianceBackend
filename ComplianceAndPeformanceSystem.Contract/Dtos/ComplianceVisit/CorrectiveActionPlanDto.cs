using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class CorrectiveActionPlanDto
{
    public Guid Id { get; set; }
    public Guid ComplianceDeatilsID { get; set; }

    public Guid ReportId { get; set; }
    public List<IFormFile>? Files { get; set; }
    public List<AttachmentDto>? FileList { get; set; }
    public string? LicenseEntityID { get; set; }
    public string? PlanDetails { get; set; }
    public DateTime Deadline { get; set; }
}

public class EvidenceReviewDto
{
    public Guid planId { get; set; }
    public Guid EvidenceId { get; set; }
    public bool IsApproved { get; set; }
    public string ReviewerComments { get; set; }
}
public class EvidenceUploadDto
{
    public List<IFormFile> Files { get; set; }
    public List<AttachmentDto> FileList { get; set; }
    public string Comments { get; set; }
    public Guid planId { get; set; }
    public Guid Id { get; set; }
}
public class ComplianceReportReviewDto
{
    public Guid planId { get; set; }
    public Guid reportId { get; set; }
    public bool IsApproved { get; set; }
    public string ReasonForReturn { get; set; } // Required if not approved
}
