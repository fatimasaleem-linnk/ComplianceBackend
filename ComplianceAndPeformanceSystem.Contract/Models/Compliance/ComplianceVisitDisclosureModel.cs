using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.Models.Compliance
{
    public class ComplianceVisitDisclosureModel
    {
        public Guid Id { get; set; }
        public Guid ComplianceVisitSpecialistId { get; set; }
        public string SurveyNotes { get; set; }
        public bool HasConflicts { get; set; }
        public string? SubmissionStatus { get; set; }
    }
}
