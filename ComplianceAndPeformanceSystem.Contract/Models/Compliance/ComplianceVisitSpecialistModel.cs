using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.Models.Compliance
{
    public class ComplianceVisitSpecialistModel
    {
        public Guid Id { get; set; }
        public Guid ComplianceDetailsId { get; set; }
        public string SpecialistUserId { get; set; }
        public string SpecialistUserName { get; set; }
        public string SpecialistUserEmail { get; set; }
        public string? MobileNumber{ get; set; }
        public ComplianceVisitDisclosureModel? ComplianceVisitDisclosure { get; set; }
    }
}
