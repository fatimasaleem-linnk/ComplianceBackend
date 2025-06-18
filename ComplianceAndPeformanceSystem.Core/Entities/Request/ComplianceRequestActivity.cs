namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ComplianceRequestActivity 
{
    public Guid Id { get; set; }
    public Guid ComplianceRequestId { get; set; }
    public DateTime CreatedOn { get; set; }
    public string CreatedByUserId { get; set; }
    public string CreatedByUserName { get; set; }
    public string CreatedByUserEmail { get; set; }
    public required string ActionAr { get; set; }
    public required string ActionEn { get; set; }
    public string DetailsAr { get; set; }
    public string DetailsEn { get; set; }
    public virtual ComplianceRequest? ComplianceRequest { get; set; }
}
