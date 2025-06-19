using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Core.Entities
{
    public class ComplianceVisitDisclosure : TrackedEntity
    {
        public Guid ComplianceVisitSpecialistId { get; set; }
        public string SurveyNotes { get; set; }
        public bool HasConflicts { get; set; }
        public virtual ComplianceVisitSpecialist? ComplianceVisitSpecialist { get; set; }
    }
}
