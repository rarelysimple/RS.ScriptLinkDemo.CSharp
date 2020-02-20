using NLog;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using RS.ScriptLinkDemo.CSharp.Soap.Services.Smtp;
using System.Net.Mail;

namespace RS.ScriptLinkDemo.CSharp.Soap.Commands
{
    public class SendEmailCommand : IRunScriptCommand
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IOptionObjectDecorator _optionObject;
        private readonly ISmtpService _smtpService;

        public SendEmailCommand(IOptionObjectDecorator optionObject, ISmtpService smtpService)
        {
            _optionObject = optionObject;
            _smtpService = smtpService;
        }

        public IOptionObject2015 Execute()
        {
            logger.Debug("Executing {command}.", nameof(SendEmailCommand));

            string to = "fakeemail@domain.local";
            string from = "noreply@domain.local";
            string subject = "Example Send Email Command";
            string body = @"This is our example email to demonstrate sending of emails from ScriptLink.";
            MailMessage mailMessage = new MailMessage(from, to)
            { 
                IsBodyHtml = false,
                Subject = subject,
                Body = body
            };

            _smtpService.Send(mailMessage);
            _smtpService.Dispose();

            return _optionObject.ToReturnOptionObject(ErrorCode.None, "Email sent.");
        }
    }
}