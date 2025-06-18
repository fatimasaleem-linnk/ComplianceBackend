using ComplianceAndPeformanceSystem.Contract.Models;

namespace ComplianceAndPeformanceSystem.Contract.IServices;

public interface INotificationService
{
    Task SendAsync(NotificationMessageModel message);
}
