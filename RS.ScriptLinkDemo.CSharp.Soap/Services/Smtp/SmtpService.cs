using NLog;
using System;
using System.Net.Mail;

namespace RS.ScriptLinkDemo.CSharp.Soap.Services.Smtp
{
    public class SmtpService : ISmtpService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly SmtpClient smtpClient;
        private bool disposed = false;

        public SmtpService()
        {
            smtpClient = new SmtpClient();
        }

        ~SmtpService()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    smtpClient.Dispose();
                }
                disposed = true;
            }
        }

        public void Send(MailMessage message)
        {
            try
            {
                smtpClient.Send(message);
            }
            catch (SmtpException ex)
            {
                logger.Error(ex, "There was a problem attempting to send mail message via SMTP. Error: {errorMessage}", ex.Message);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "There was a problem attempting to send mail message via SMTP. ErrorType: {errorType} Error: {errorMessage}", ex.GetType(), ex.Message);
                throw;
            }
        }
    }
}