using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit
{
    public class TeamShortage
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ComplianceDetailsId { get; set; }        
        public ComplianceDetails? ComplianceDetails  { get; set; }
        public DateTime? VisitDate { get; set; }
        public long? LicensedEntityId { get; set; }
        public string? ShortageReason { get; set; }
        public  DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; }
    }
}
