using NLog;
using System;
using System.Net.Mail;

namespace RS.ScriptLinkDemo.CSharp.Soap.Services.Smtp
{
    public class SmtpService : ISmtpService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly SmtpClient smtpClient;

        public SmtpService()
        {
            smtpClient = new SmtpClient();
        }

        public void Dispose()
        {
            smtpClient.Dispose();
        }

        public void Send(MailMessage message)
        {
            try
            {
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "There was a problem attempting to send mail message via SMTP. Error: {errorMessage}", ex.Message);
            }
        }
    }
}