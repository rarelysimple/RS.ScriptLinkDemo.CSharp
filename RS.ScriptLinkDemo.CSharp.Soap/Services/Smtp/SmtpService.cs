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
            if (message != null)
            {
                try
                {
                    smtpClient.Send(message);
                    logger.Debug("MailMessage sent to {toAddresses} cc'd {ccAddresses} from {fromAddress}.", message.To, message.CC, message.From);
                }
                catch (SmtpException ex)
                {
                    logger.Error(ex, "There was a problem attempting to send mail message to {toAddresses} cc'd {ccAddresses} from {fromAddress}. Error: {errorMessage}", message.To, message.CC, message.From, ex.Message);
                    return;
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "There was a problem attempting to send mail message to {toAddresses} cc'd {ccAddresses} from {fromAddress}. ErrorType: {errorType} Error: {errorMessage}", message.To, message.CC, message.From, ex.GetType(), ex.Message);
                    throw;
                }
            }
            else
            {
                logger.Error("No MailMessage was provided to send. Aborting.");
            }
        }
    }
}