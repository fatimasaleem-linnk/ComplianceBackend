using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IServices;

namespace ComplianceAndPeformanceSystem.Contract.Helper
{
    public static class ExtensionStatusMapper
    {
        public static string ToFriendlyString(int? status, ICurrentLanguageService? currentLanguage)
        {
            if (currentLanguage?.Language == LanguageEnum.En)
            {
                return status switch
                {
                    1 => "pending",
                    2 => "approved",
                    3 => "rejected",
                    4 => "modified",
                    _ => "unknown"
                };
            }
            else
            {
                return status switch
                {
                    1 => "قيد الانتظار",
                    2 => "موافقة",
                    3 => "رفض",
                    4 => "تعديل",
                    _ => "غير معروف"
                };
            }
        }
    }

}
