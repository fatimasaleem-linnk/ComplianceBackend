namespace ComplianceAndPeformanceSystem.Core.Entities;

public class VisitSurveyAnswer : TrackedEntity
{
    public Guid ComplianceVisitSpecialistId { get; set; }
    public Guid VisitSurveyQuestionId { get; set; }
    public bool Answer { get; set; }
    public string? Reason { get; set; }

    public virtual ComplianceVisitSpecialist ComplianceVisitSpecialist { get; set; }
    public virtual VisitSurveyQuestion VisitSurveyQuestion { get; set; }
}
