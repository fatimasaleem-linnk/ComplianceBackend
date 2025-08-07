namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class LicenseParticipantDto
{
    public string Name { get; set; }                 // الاسم
    public string? Department { get; set; }           // القسم
    public string? Position { get; set; }             // الوظيفة
    public string Phone { get; set; }                // الهاتف
    public string Email { get; set; }                // البريد
}
