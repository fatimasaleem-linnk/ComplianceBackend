using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.Models.Compliance
{
    public class AssignComplianceVisitSpecialistModel
    {
        public Guid RequestId { get; set; }
        public Guid ComplianceDetailsId { get; set; }
        public List<string> AssignedUserId { get; set; }
    }
}
