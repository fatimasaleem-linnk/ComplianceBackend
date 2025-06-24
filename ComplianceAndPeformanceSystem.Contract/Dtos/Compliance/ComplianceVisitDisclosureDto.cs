using ComplianceAndPeformanceSystem.Contract.Models.Compliance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.Dtos.Compliance
{
    public class ComplianceVisitDisclosureDto
    {
        public Guid ComplianceDetailId { get; set; }
        public long LicensedEntityId { get; set; }
        public string? LicenseEntityName { get; set; }
        public long? LocationId { get; set; }
        public string? LocationName { get; set; }
        public Guid ComplianceVisitSpecialistId { get; set; }
        public string? SurveyNotes { get; set; }
        public bool? HasConflicts { get; set; }
        public List<VisitSurveryQuestionModel>? VisitSurveyQuestions { get; set; }
        public List<VisitSurveyAnswerModel>? VisitSurveyAnswers { get; set; }

    }
}
