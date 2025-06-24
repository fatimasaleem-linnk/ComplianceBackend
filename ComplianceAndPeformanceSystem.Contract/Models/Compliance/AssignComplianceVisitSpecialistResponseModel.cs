using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.Models.Compliance
{
    public class AssignComplianceVisitSpecialistResponseModel
    {
        public bool IsUpdate { get; set; }
        public List<string> NotifyNewUsers { get; set; }
        public List<string> NotifyConflictUsers { get; set; }
    }
}
