
using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Notification.Services;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Numeric;
using System.Net;
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

            var html = await _viewRendererService.RenderPartialToStringAsync("EmailNotification/Templates/" + message.ViewName, message);

            MailMessage mail = new MailMessage();
            //mail.From = new MailAddress(_emailConfigurationModel.From, message.Subject);

            mail.From = new MailAddress("fatima.saleem@linnkarabia.com", message.Subject);

            if (message.To != null)
            {
                foreach (var item in message.To)
                    mail.To.Add(new MailAddress(item));
            }
            if (message.CC != null) 
            {
                foreach (var item in message.CC)
                    mail.CC.Add(new MailAddress(item));
            }

            mail.IsBodyHtml = true;
            //SmtpClient client = new SmtpClient();
            //client.Port = _emailConfigurationModel.Port;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            ////client.UseDefaultCredentials = true;
            //client.Host = _emailConfigurationModel.SmtpServer;

            var client = new SmtpClient("smtp.office365.com", 587)
            {
                Credentials = new NetworkCredential("fatima.saleem@linnkarabia.com", "Fatazm@97"),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };

            mail.Subject = message.Subject;
            mail.Body = html;
            await client.SendMailAsync(mail);

        }
    }
}
