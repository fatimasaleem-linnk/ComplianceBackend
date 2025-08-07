using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class LicenseParticipant
{
    [Key]
    public int ID { get; set; } = new int();
    public string Name { get; set; }                 // الاسم
    public string Department { get; set; }           // القسم
    public string Position { get; set; }             // الوظيفة
    public string Phone { get; set; }                // الهاتف
    public string Email { get; set; }                // البريد

    public Guid ReportID { get; set; }
    [ForeignKey(nameof(ReportID))]
    public ComplianceReport? ComplianceReport { get; set; }
}
