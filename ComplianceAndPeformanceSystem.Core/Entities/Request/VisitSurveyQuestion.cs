namespace ComplianceAndPeformanceSystem.Core.Entities;

public class VisitSurveyQuestion : TrackedEntity
{
    public string QuestionAr { get; set; }
    public string QuestionEn { get; set; }
    public virtual ICollection<VisitSurveyAnswer> VisitSurveyAnswers { get; set; }
}
