namespace ComplianceAndPeformanceSystem.Contract.Models;

public class ComplianceVisitDisclosureModel
{
    public Guid Id { get; set; }
    public Guid ComplianceVisitSpecialistId { get; set; }
    public string SurveyNotes { get; set; }
    public bool HasConflicts { get; set; }
    public string? SubmissionStatus { get; set; }
}
