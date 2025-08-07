namespace ComplianceAndPeformanceSystem.Contract.Models;

public class VisitSurveyAnswerModel
{
    public Guid? Id { get; set; }
    public Guid? ComplianceVisitSpecialistId { get; set; }
    public Guid VisitSurveyQuestionId { get; set; }
    public bool Answer { get; set; }
    public string? Reason { get; set; }

}
