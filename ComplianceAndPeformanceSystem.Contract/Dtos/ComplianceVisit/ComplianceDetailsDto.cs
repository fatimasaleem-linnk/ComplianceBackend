using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Core.Entities;

namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class ComplianceDetailsDto
{
    public long Seq { get; set; }
    public Guid Id { get; set; }
    public Guid ComplianceRequestId { get; set; }
    public long LicensedEntityId { get; set; }
    public long ActivityId { get; set; }

    public long? VisitStatusId { get; set; }
    public string? VisitStatusName { get; set; }

    public string ActivityName { get; set; }
    public string LicensedEntityName { get; set; }
    public string LocationName { get; set; }
    public string QuarterPlannedForVisitName { get; set; }
    public string VisitTypeName { get; set; }

    public long PlantNameId { get; set; }
    public long? LocationId { get; set; }
    public long? QuarterPlannedForVisitId { get; set; }
    public long VisitTypeId { get; set; }
    public DateTime? VisitDate { get; set; }
    public long? DesignedCapacity { get; set; }
    public string? VisitReferenceNumber { get; set; }

    public DateTime ScheduledDate { get; set; }
    public int Status { get; set; }
    public string? StatusName { get; set; }
    public string? CancellationReason { get; set; }
    public string? RescheduleReason { get; set; }
    public DateTime? CancelledAt { get; set; }


    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public DateTime? AssignedOn { get; set; }

    public bool IsDeleted { get; set; }
    
    public virtual List<VisitStatusHistory>? VisitStatusHistory { get; set; }

    public virtual List<ComplianceVisitSpecialistModel>? ComplianceVisitSpecialists { get; set; }
    public virtual List<AttachmentDto>? VisitDocuments { get; set; }

}
