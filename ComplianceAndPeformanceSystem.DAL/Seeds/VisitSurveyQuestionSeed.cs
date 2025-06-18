using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Seeds;

public class VisitSurveyQuestionSeed : IEntityTypeConfiguration<VisitSurveyQuestion>
{
    public void Configure(EntityTypeBuilder<VisitSurveyQuestion> builder)
    {
        builder.HasData(new List<VisitSurveyQuestion>()
        {
            new VisitSurveyQuestion()
            {
                Id = new Guid("F1F58C6F-0860-482A-BE61-AA065B631920"),
                QuestionAr = "هل لديك أي مصلحة تجارية أو شراكة أو نشاط مالي قد يؤثر على الزيارة؟",
                QuestionEn = "Do you have any business interest, partnership, or financial activity that might affect the visit?",
                ModifiedOn = DateTime.Now,
                CreatedOn = DateTime.Now,
            },
            new VisitSurveyQuestion()
            {
                Id = new Guid("F1F58C6F-0860-482A-BE61-AA065B631921"),
                QuestionAr = "هل لديك أي أقارب من الدرجة الأولى إلى الرابعة يمتلكون عملاً تجاريًا أو لديهم مصلحة مالية مع الكيان الذي تتم زيارته؟",
                QuestionEn = "Do you have any first- to fourth-degree relatives who own a business or have a financial interest in the entity being visited?",
                ModifiedOn = DateTime.Now,
                CreatedOn = DateTime.Now,
            },
            new VisitSurveyQuestion()
            {
                Id = new Guid("F1F58C6F-0860-482A-BE61-AA065B631922"),
                QuestionAr = "هل تشغل حاليًا أي منصب إداري أو عضوية في منظمة لها علاقات مباشرة أو غير مباشرة مع الجهة التي تتم زيارتها؟",
                QuestionEn = "Do you currently hold any management position or membership in an organization that has direct or indirect ties to the visited entity?",
                ModifiedOn = DateTime.Now,
                CreatedOn = DateTime.Now,
            },
            new VisitSurveyQuestion()
            {
                Id = new Guid("F1F58C6F-0860-482A-BE61-AA065B631923"),
                QuestionAr = "هل لديك أي أقارب من الدرجة الأولى إلى الرابعة يشغلون مناصب إدارية  أو عضوية في جهة مرتبطة بالجهة التي تتم زيارتها؟",
                QuestionEn = "Do you have any first- to fourth-degree relatives who hold administrative or membership positions in an organization related to the entity being visited?",
                ModifiedOn = DateTime.Now,
                CreatedOn = DateTime.Now,
            },
            new VisitSurveyQuestion()
            {
                Id = new Guid("F1F58C6F-0860-482A-BE61-AA065B631924"),
                QuestionAr = "هل لديك أي علاقات أو اتصالات سابقة مع موظفي الجهة التي قد تؤثر  على الزيارة؟",
                QuestionEn = "Do you have any previous relationships or contacts with staff members that may affect the visit?",
                ModifiedOn = DateTime.Now,
                CreatedOn = DateTime.Now,
            },
            new VisitSurveyQuestion()
            {
                Id = new Guid("F1F58C6F-0860-482A-BE61-AA065B631925"),
                QuestionAr = "هل لديك أي أسباب قد تؤثر على قدرتك على إجراء الزيارة بموضوعية  واستقلالية؟",
                QuestionEn = "Do you have any reasons that might affect your ability to conduct the visit objectively and independently?",
                ModifiedOn = DateTime.Now,
                CreatedOn = DateTime.Now,
            },
            new VisitSurveyQuestion()
            {
                Id = new Guid("F1F58C6F-0860-482A-BE61-AA065B631926"),
                QuestionAr = "هل لديك أي أقارب من الدرجة الأولى إلى الرابعة يمتلكون عملاً تجاريًا أو لديهم مصلحة مالية مع الكيان الذي تتم زيارته؟",
                QuestionEn = "Do you have any first- to fourth-degree relatives who own a business or have a financial interest in the entity being visited?",
                ModifiedOn = DateTime.Now,
                CreatedOn = DateTime.Now,
            },
        });

    }

}
