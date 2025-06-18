using ComplianceAndPeformanceSystem.Contract.Helper;

namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class ExportRequestExcelDto
{
    [ExcelExportAttribute(HeaderName = "رقم الموظف")]
    public string? RequesterUID { get; set; }
    [ExcelExportAttribute(HeaderName = "رقم الطلب")]
    public string? RequestNumber { get; set; }
    [ExcelExportAttribute(HeaderName = "تاريخ الانشاء")]
    public string? RequestDate { get; set; }
    [ExcelExportAttribute(HeaderName = "اسم الموظف")]
    public string? EmployeeName { get; set; }
    [ExcelExportAttribute(HeaderName = "الموقع")]
    public string? Location { get; set; }
    [ExcelExportAttribute(HeaderName = "الادارة")]
    public string? Division { get; set; }
    [ExcelExportAttribute(HeaderName = "القسم")]
    public string? Department { get; set; }
    [ExcelExportAttribute(HeaderName = "الجنس")]
    public string? Gender { get; set; }
    [ExcelExportAttribute(HeaderName = "قياس البنطلون")]
    public string? PantSizeName { get; set; }
    [ExcelExportAttribute(HeaderName = "قياس القميص")]
    public string? ShirtSizeName { get; set; }
    [ExcelExportAttribute(HeaderName = "لون القميص")]
    public string? ShirtColorName { get; set; }
    [ExcelExportAttribute(HeaderName = "قياس الجاكت")]
    public string? JacketSizeName { get; set; }
    [ExcelExportAttribute(HeaderName = "حذاء برباط")]
    public string? ShoesWithTieSizeName { get; set; }
    [ExcelExportAttribute(HeaderName = "حذاء بدون رباط")]
    public string? ShoesWithoutTieSizeName { get; set; }
    [ExcelExportAttribute(HeaderName = "قياس القبعة")]
    public string? HatSizeName { get; set; }
    [ExcelExportAttribute(HeaderName = "حالة الطلب")]
    public string? RequestStatus { get; set; }
    [ExcelExportAttribute(HeaderName = "ملاحظات")]
    public string? Notes { get; set; }







}
