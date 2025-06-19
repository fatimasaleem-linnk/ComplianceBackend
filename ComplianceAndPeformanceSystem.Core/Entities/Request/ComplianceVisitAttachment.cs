using System.ComponentModel.DataAnnotations.Schema;


namespace ComplianceAndPeformanceSystem.Core.Entities.Request
{
    public class ComplianceVisitAttachment : TrackedEntity
    {
        public string? Name { get; set; }
        public string? Path { get; set; }
        public string? Type { get; set; }
        public string? Url { get; set; }


        public Guid? ComplianceDetailsID { get; set; }
        [ForeignKey(nameof(ComplianceDetailsID))]
        public ComplianceDetails? ComplianceDetails { get; set; }
    }
}
