namespace ComplianceAndPeformanceSystem.Contract.Common.Models;

public class EmailConfigurationModel
{
    public string From { get; set; }
    public string SmtpServer { get; set; }
    public int Port { get; set; }
    public bool SendingEmailEnabled { get; set; }
    public bool SSL { get; set; }
}
