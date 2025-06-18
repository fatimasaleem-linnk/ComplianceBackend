namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ComplianceVisitSpecialist : TrackedEntity
{
    public Guid ComplianceDetailsId { get; set; }
    public string SpecialistUserId { get; set; }
    public string SpecialistUserName { get; set; }
    public string SpecialistUserEmail { get; set; }
    public string? SurveyNotes { get; set; }
    public string? MobileNumber { get; set; }
    public virtual ComplianceDetails? ComplianceDetails { get; set; }
    public virtual ICollection<VisitSurveyAnswer> VisitSurveyAnswers { get; set; }
}
