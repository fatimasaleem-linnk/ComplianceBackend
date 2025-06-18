using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Web;
namespace ComplianceAndPeformanceSystem.Notification;

public class SMSNotificationService(SMSConfigurationModel smsConfigurationModel, ILogger<SMSNotificationService> logger) : INotificationService
{
    public async Task SendAsync(NotificationMessageModel message)
    {
        if (smsConfigurationModel.SendingSMSEnabled)
        {
            if (message.To != null && message.To.Count > 0)
            {
                ParallelOptions parallelOptions = new ParallelOptions
                {
                    MaxDegreeOfParallelism = 100
                };


                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();


                await Parallel.ForEachAsync(message.To, parallelOptions, async (to, CancellationToken) =>
                {
                    try
                    {
                        using (var client = new HttpClient())
                        {
                            client.BaseAddress = new Uri(smsConfigurationModel.SMSUrl);
                            string encodedUrl = HttpUtility.UrlEncode(message.Body);

                            client.DefaultRequestHeaders.Add("AppKey", smsConfigurationModel.SMSAppKey);
                            //HTTP GET
                            var messageUrl = $"?mobileNo={to}&message={encodedUrl}";
                            var response = await client.GetAsync(messageUrl);


                        }
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, ex.Message);
                    }
                });

            }
        }
    }
}
