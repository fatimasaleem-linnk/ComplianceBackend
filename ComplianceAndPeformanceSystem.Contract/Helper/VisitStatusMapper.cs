using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IServices;

namespace ComplianceAndPeformanceSystem.Contract.Helper
{
    public static class VisitStatusMapper
    {
        public static string ToFriendlyString(int? status, ICurrentLanguageService? currentLanguage)
        {
            if (currentLanguage?.Language == LanguageEnum.En)
            {
                return status switch
                {
                    200 => "RescheduleRequested",
                    201 => "Rescheduled",
                    202 => "Completed",
                    203 => "Cancelled",
                    _ => "unknown"
                };
            }
            else
            {
                return status switch
                {
                    200 => "طلب إعادة جدولة",
                    201 => "تمت إعادة الجدولة",
                    202 => "مكتمل",
                    203 => "ملغاة",
                    _ => "غير معروف"
                };
            }
        }

    }
}
