namespace ComplianceAndPeformanceSystem.Core.Entities
{
    public class ComplianceVisitDisclosure : TrackedEntity
    {
        public Guid ComplianceVisitSpecialistId { get; set; }
        public virtual ComplianceVisitSpecialist? ComplianceVisitSpecialist { get; set; }
        public string SurveyNotes { get; set; }
        public bool HasConflicts { get; set; }
    }
}
