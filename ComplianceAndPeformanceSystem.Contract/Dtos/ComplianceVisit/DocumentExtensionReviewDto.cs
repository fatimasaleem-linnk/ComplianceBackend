using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit
{
    public class DocumentExtensionReviewDto
    {
        public int NewStatus { get; set; }  // 2=Approved, 3=Rejected, 4=Modified
        public int? FinalStatus { get; set; }  // 2=Approved, 3=Rejected, 4=Modified
        public string? ActionReason { get; set; } 
        public int? NewFinalDays { get; set; }
        public Guid RequestId { get; set; }
    }
}
