using ComplianceAndPeformanceSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Contract.Models.Compliance
{
    public class VisitSurveryQuestionModel
    {
        public Guid Id { get; set; }
        public string QuestionAr { get; set; }
        public string QuestionEn { get; set; }
    }
}
