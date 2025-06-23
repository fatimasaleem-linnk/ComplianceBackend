using ComplianceAndPeformanceSystem.Core.Entities;
using ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit
{
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
        public virtual LookupValue LicensedEntity { get; set; }
        public virtual LookupValue Activity { get; set; }
        public virtual LookupValue PlantName { get; set; }
        public virtual LookupValue Location { get; set; }
        public virtual LookupValue QuarterPlannedForVisit { get; set; }
        public virtual LookupValue VisitType { get; set; }

        public virtual ComplianceRequest ComplianceRequest { get; set; }
        public virtual ICollection<ComplianceRequestActivity>? ComplianceRequestActivities { get; set; }
        public virtual ICollection<VisitStatusHistory>? VisitStatusHistory { get; set; }

        public virtual ICollection<ComplianceVisitSpecialist>? ComplianceVisitSpecialists { get; set; }
        public virtual ICollection<VisitDocument>? VisitDocuments { get; set; }

    }

    //public class ComplianceDetailsDto
    //{
    //    public long Seq { get; set; }
    //    public Guid Id { get; set; }
    //    public Guid ComplianceRequestId { get; set; }
    //    public long LicensedEntityId { get; set; }
    //    public long ActivityId { get; set; }

    //    public string ActivityName { get; set; }
    //    public string LicensedEntityName { get; set; }
    //    public string LocationName { get; set; }
    //    public string QuarterPlannedForVisitName { get; set; }
    //    public string VisitTypeName { get; set; }

    //    public long PlantNameId { get; set; }
    //    public long? LocationId { get; set; }
    //    public long? QuarterPlannedForVisitId { get; set; }
    //    public long VisitTypeId { get; set; }
    //    public DateTime? VisitDate { get; set; }
    //    public long? DesignedCapacity { get; set; }
    //    public string? VisitReferenceNumber { get; set; }

    //    public DateTime ScheduledDate { get; set; }
    //    public int Status { get; set; }
    //    public string? StatusName { get; set; }
    //    public string? CancellationReason { get; set; }
    //    public DateTime? CancelledAt { get; set; }


    //    public DateTime CreatedOn { get; set; }
    //    public DateTime ModifiedOn { get; set; }
    //    public DateTime? AssignedOn { get; set; }

    //    public bool IsDeleted { get; set; }
    //    public virtual LookupValue LicensedEntity { get; set; }
    //    public virtual LookupValue Activity { get; set; }
    //    public virtual LookupValue PlantName { get; set; }
    //    public virtual LookupValue Location { get; set; }
    //    public virtual LookupValue QuarterPlannedForVisit { get; set; }
    //    public virtual LookupValue VisitType { get; set; }

    //    public virtual ComplianceRequest ComplianceRequest { get; set; }
    //    public virtual ICollection<ComplianceRequestActivity>? ComplianceRequestActivities { get; set; }
    //    public virtual ICollection<VisitStatusHistory>? VisitStatusHistory { get; set; }

    //    public virtual ICollection<ComplianceVisitSpecialist>? ComplianceVisitSpecialists { get; set; }

    //}
}
