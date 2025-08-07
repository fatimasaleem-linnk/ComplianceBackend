using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Notification.Services;
using System.Net.Mail;


namespace ComplianceAndPeformanceSystem.Notification;

public class EmailNotificationService : INotificationService
{
    private readonly EmailConfigurationModel _emailConfigurationModel;
    private readonly IViewRendererService _viewRendererService;
    public EmailNotificationService(EmailConfigurationModel emailConfigurationModel, IViewRendererService viewRendererService)
    {
        _emailConfigurationModel = emailConfigurationModel;
        _viewRendererService = viewRendererService;
    }
    public async Task SendAsync(NotificationMessageModel message)
    {
        if (_emailConfigurationModel.SendingEmailEnabled)
        {

           
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(_emailConfigurationModel.From, message.Subject);

            if (message.To != null || message?.To?.Count > 0)
            {
                foreach (var item in message.To)
                    mail.To.Add(new MailAddress(item));
            }
            if (message.CC != null || message?.CC?.Count > 0)
            {
                foreach (var item in message.CC)
                    mail.CC.Add(new MailAddress(item));
            }

            mail.IsBodyHtml = true;
            SmtpClient client = new SmtpClient();
            client.Port = _emailConfigurationModel.Port;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = true;
            client.Host = _emailConfigurationModel.SmtpServer;
            mail.Subject = message.Subject;
            if (message.Body == null)
            {
                var html = await _viewRendererService.RenderPartialToStringAsync("EmailNotification/Templates/" + message.ViewName, message);
                mail.Body = html;

            }
            else
            {
                mail.Body = message.Body;
            }
            await client.SendMailAsync(mail);

        }
    }
}
