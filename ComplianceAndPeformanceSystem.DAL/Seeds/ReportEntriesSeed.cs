using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComplianceAndPeformanceSystem.DAL.Seeds
{
    public class ReportEntriesSeed : IEntityTypeConfiguration<ReportEntries>
    {
        public void Configure(EntityTypeBuilder<ReportEntries> builder)
        {
            // Seed Entries
            builder.HasData(new List<ReportEntries>()
            {
            // Legal & Regulation - Compliance
            new() { Id = 111, Name = "Complied with licensed facility's design capacity data", NameAr = "الامتثال لبيانات الطاقة التصميمية للمنشأة المرخصة", SupCategoryID = 11 },
            new() { Id = 112, Name = "Implemented recommendations from previous audits within defined period", NameAr = "تنفيذ التوصيات من عمليات التدقيق السابقة ضمن الفترة المحددة", SupCategoryID = 11 },
            new() { Id = 113, Name = "Provided data/information requested by SWA in an approved format", NameAr = "تقديم البيانات/المعلومات المطلوبة من الهيئة بالصيغة المعتمدة", SupCategoryID = 11 },
            new() { Id = 114, Name = "Supported audit team and complied with requests", NameAr = "دعم فريق التدقيق والامتثال للطلبات", SupCategoryID = 11 },
            // Legal & Regulation - Licensing requirements
            new() { Id = 121, Name = "Obtained a land title deed for licensed facility/asset", NameAr = "الحصول على صك ملكية للأصل أو المنشأة المرخصة", SupCategoryID = 12 },
            new() { Id = 122, Name = "Obtained a valid license or permit as per law", NameAr = "الحصول على ترخيص أو تصريح ساري حسب النظام", SupCategoryID = 12 },
            new() { Id = 123, Name = "Obtained required approvals for mergers/acquisitions", NameAr = "الحصول على الموافقات اللازمة للاندماجات أو الاستحواذات", SupCategoryID = 12 },
            // Legal & Regulation - Organization & capabilities
            new() { Id = 131, Name = "Established compliance department and defined job descriptions", NameAr = "إنشاء إدارة امتثال وتحديد الوصف الوظيفي", SupCategoryID = 13 },
            new() { Id = 132, Name = "Submitted and obtained approval for the compliance plan", NameAr = "تقديم واعتماد خطة الامتثال", SupCategoryID = 13 },

            // Financial - Accounting requirements
            new() { Id = 211, Name = "Established an updated fixed asset register (FAR)", NameAr = "إعداد سجل الأصول الثابتة المحدّث", SupCategoryID = 21 },
            new() { Id = 212, Name = "Implemented separate accounts for licensed activities", NameAr = "تطبيق حسابات منفصلة للأنشطة المرخصة", SupCategoryID = 21 },
            // Financial - Financial information
            new() { Id = 221, Name = "Submitted annual audited financial statements", NameAr = "تقديم القوائم المالية السنوية المدققة", SupCategoryID = 22 },
            new() { Id = 222, Name = "Provided valid and accurate commercial agreements", NameAr = "تقديم اتفاقيات تجارية صحيحة ودقيقة", SupCategoryID = 22 },
            new() { Id = 223, Name = "Submitted and obtained approval for revenue management method", NameAr = "تقديم واعتماد آلية إدارة الإيرادات", SupCategoryID = 22 },

            // Technical - Organization & capabilities
            new() { Id = 311, Name = "Mechanism for monitoring and controlling water quality", NameAr = "آلية مراقبة وضبط جودة المياه", SupCategoryID = 31 },
            new() { Id = 312, Name = "Established operational plans", NameAr = "إعداد خطط تشغيلية", SupCategoryID = 31 },
            new() { Id = 313, Name = "Established maintenance and incident reporting plans", NameAr = "إعداد خطط الصيانة والتقارير عن الحوادث", SupCategoryID = 31 },
            new() { Id = 314, Name = "Established risk and emergency management plans", NameAr = "إعداد خطط إدارة المخاطر والطوارئ", SupCategoryID = 31 },
            // Technical - Regulatory requirements
            new() { Id = 321, Name = "Complied with KSA localization and operational performance standards", NameAr = "الامتثال لمعايير التوطين والأداء التشغيلي في المملكة", SupCategoryID = 32 },
            new() { Id = 322, Name = "Disposed wastewater treated as per standards", NameAr = "تصريف مياه الصرف الصحي المعالجة حسب المعايير", SupCategoryID = 32 },

            // Consumer Service - Consumer information
            new() { Id = 411, Name = "Kept encrypted consumer data, restricting access to required employees", NameAr = "حفظ بيانات المستهلك بشكل مشفر وتقييد الوصول", SupCategoryID = 41 },
            new() { Id = 412, Name = "Made service information publicly available", NameAr = "إتاحة معلومات الخدمة للعامة", SupCategoryID = 41 },
            // Consumer Service - Consumer satisfaction
            new() { Id = 421, Name = "Established a call center for consumer inquiries", NameAr = "إنشاء مركز اتصال لاستفسارات المستهلك", SupCategoryID = 42 },
            new() { Id = 422, Name = "Provided training for employees dealing with consumers", NameAr = "تقديم تدريب للموظفين للتعامل مع المستهلكين", SupCategoryID = 42 }
            });
        }
    }
}
