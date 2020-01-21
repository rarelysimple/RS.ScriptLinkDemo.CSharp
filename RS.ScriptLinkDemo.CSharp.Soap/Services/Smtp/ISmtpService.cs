using System.Net.Mail;

namespace RS.ScriptLinkDemo.CSharp.Soap.Services.Smtp
{
    public interface ISmtpService
    {
        void Dispose();
        void Send(MailMessage mailMessage);
    }
}