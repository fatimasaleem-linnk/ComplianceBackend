
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Core.Entities;

namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class CompliancePlanDto
{
    public long Seq { get; set; }
    public Guid Id { get; set; }
    public Guid ComplianceRequestId { get; set; }
    public required long LicensedEntityId { get; set; }
    public string? LicensedEntityName { get; set; }
    public required long ActivityId { get; set; }
    public string? ActivityName { get; set; }
    public required long PlantNameId { get; set; }
    public string? PlantName { get; set; }
    public long? LocationId { get; set; }
    public string? LocationName { get; set; }
    public long? QuarterPlannedForVisitId { get; set; }
    public string? QuarterPlannedForVisitName { get; set; }
    public string? QuarterPlannedForVisitNameEn { get; set; }
    public long VisitTypeId { get; set; }
    public string? VisitTypeName { get; set; }
    public string? CancellationReason { get; set; }
    public string? RescheduleReason { get; set; }
    public DateTime? VisitDate { get; set; }
    public DateTime ScheduledDate { get; set; }
    public DateTime? CancelledAt { get; set; }

    public long? DesignedCapacity { get; set; }
    public string? VisitReferenceNumber { get; set; }
    public int? UnscheduledVisitsForCurrentQuarter { get; set; }
    public long? VisitStatusId { get; set; }
    public string? VisitStatusName { get; set; }
    public string? LocationVisit { get; set; }

    public List<ComplianceVisitSpecialistModel>? ComplianceVisitSpecialists { get; set; }
    public List<AttachmentDto>? VisitDocuments { get; set; }
    public List<VisitStatusHistory>? VisitStatusHistory { get; set; }

    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
}
