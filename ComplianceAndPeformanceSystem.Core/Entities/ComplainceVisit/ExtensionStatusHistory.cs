using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ExtensionStatusHistory
{
    [Key]
    public int Id { get; set; }
    public Guid RequestId { get; set; }
    public DocumentExtensionRequest? Request { get; set; }
    public Guid ActionByUserId { get; set; }
    public DateTime ActionAt { get; set; }
    public int? OldStatus { get; set; }
    public int NewStatus { get; set; }
    public string? ActionReason { get; set; }
    public int? NewFinalDays { get; set; }
}
