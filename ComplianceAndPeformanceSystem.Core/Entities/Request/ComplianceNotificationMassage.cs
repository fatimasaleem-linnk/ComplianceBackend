namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ComplianceNotificationMassage
{
    public int Id { get; set; }
    public string Role { get; set; }
    public string MessageType { get; set; }
    public string MessageTitleAR { get; set; }
    public string MessageTitleEn { get; set; }
    public string MessageBodyAR { get; set; }
    public string MessageBodyEn { get; set; }
    public string ActionUrl { get; set; }
}
