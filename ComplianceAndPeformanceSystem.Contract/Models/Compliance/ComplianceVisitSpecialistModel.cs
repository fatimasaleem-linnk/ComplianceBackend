namespace ComplianceAndPeformanceSystem.Contract.Models;

public class ComplianceVisitSpecialistModel
{
    public Guid Id { get; set; }
    public Guid ComplianceDetailsId { get; set; }
    public string SpecialistUserId { get; set; }
    public string SpecialistUserName { get; set; }
    public string SpecialistUserEmail { get; set; }
    public string? MobileNumber { get; set; }
    public DateTime? CreatedOn { get; set; }
    public bool? IsSubmitted { get; set; }
    public ComplianceVisitDisclosureModel? ComplianceVisitDisclosure { get; set; }
    public virtual List<VisitSurveyAnswerModel>? VisitSurveyAnswers { get; set; }
}
