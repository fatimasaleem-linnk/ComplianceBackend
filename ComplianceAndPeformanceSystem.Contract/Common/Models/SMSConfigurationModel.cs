namespace ComplianceAndPeformanceSystem.Contract.Common.Models;

public class SMSConfigurationModel
{
    public string SMSUrl { get; set; }
    public bool SendingSMSEnabled { get; set; }
    public string SMSAppKey { get; set; }
}
