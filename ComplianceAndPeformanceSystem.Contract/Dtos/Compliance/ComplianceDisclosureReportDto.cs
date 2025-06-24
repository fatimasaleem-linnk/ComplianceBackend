using ComplianceAndPeformanceSystem.Contract.Models.Compliance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.Dtos.Compliance
{
    public class ComplianceDisclosureReportDto
    {
        public Guid ComplianceDetailId { get; set; }
        public long? LocationId { get; set; }
        public string? LocationName { get; set; }
        public List<ComplianceVisitSpecialistModel>? ComplianceVisitSpecialists { get; set; }
    }
}
