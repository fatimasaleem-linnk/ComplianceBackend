using ComplianceAndPeformanceSystem.Contract.Models;

namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class ComplianceVisitDisclosureDto
{
    public Guid ComplianceDetailId { get; set; }
    public long LicensedEntityId { get; set; }
    public string? LicenseEntityName { get; set; }
    public string? LocationVisit { get; set; }
    public long? LocationId { get; set; }
    public string? LocationName { get; set; }
    public Guid ComplianceVisitSpecialistId { get; set; }
    public string? SurveyNotes { get; set; }
    public bool? HasConflicts { get; set; }
    public List<VisitSurveryQuestionModel>? VisitSurveyQuestions { get; set; }
    public List<VisitSurveyAnswerModel>? VisitSurveyAnswers { get; set; }

}
