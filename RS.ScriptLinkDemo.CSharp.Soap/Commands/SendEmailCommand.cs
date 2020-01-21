using NLog;
using RS.ScriptLinkDemo.CSharp.Objects;
using RS.ScriptLinkDemo.CSharp.Soap.Services.Smtp;
using System.Net.Mail;

namespace RS.ScriptLinkDemo.CSharp.Soap.Commands
{
    public class SendEmailCommand : IRunScriptCommand
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly OptionObject2015 _optionObject2015;
        private readonly ISmtpService _smtpService;

        public SendEmailCommand(OptionObject2015 optionObject2015, ISmtpService smtpService)
        {
            _optionObject2015 = optionObject2015;
            _smtpService = smtpService;
        }

        public OptionObject2015 Execute()
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

            return new OptionObject2015()
            {
                EntityID = _optionObject2015.EntityID,
                EpisodeNumber = _optionObject2015.EpisodeNumber,
                ErrorCode = 0,
                ErrorMesg = "Email sent.",
                Facility = _optionObject2015.Facility,
                NamespaceName = _optionObject2015.NamespaceName,
                OptionId = _optionObject2015.OptionId,
                OptionStaffId = _optionObject2015.OptionStaffId,
                OptionUserId = _optionObject2015.OptionUserId,
                ParentNamespace = _optionObject2015.ParentNamespace,
                ServerName = _optionObject2015.ServerName,
                SystemCode = _optionObject2015.SystemCode,
                SessionToken = _optionObject2015.SessionToken
            };
        }
    }
}