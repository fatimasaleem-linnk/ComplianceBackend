using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.Models.Compliance
{
    public class VisitSurveyAnswerModel
    {
        public Guid Id { get; set; }
        public Guid? ComplianceVisitSpecialistId { get; set; }
        public Guid VisitSurveyQuestionId { get; set; }
        public bool Answer { get; set; }
        public string? Reason { get; set; }

    }
}
