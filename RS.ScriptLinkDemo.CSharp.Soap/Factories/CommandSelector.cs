using NLog;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using RS.ScriptLinkDemo.CSharp.Data.Models;
using RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc;
using RS.ScriptLinkDemo.CSharp.Soap.Commands;
using RS.ScriptLinkDemo.CSharp.Soap.Services.Smtp;

namespace RS.ScriptLinkDemo.CSharp.Soap.Factories
{
    public static class CommandSelector
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Returns the desired command based on the provided <see cref="OptionObject2015"/> and parameter.
        /// </summary>
        /// <param name="optionObject"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static IRunScriptCommand GetCommand(IOptionObject2015 optionObject, IParameter parameter)
        {
            if (optionObject == null)
                logger.Error("The provided OptionObject2015 is null");

            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            logger.Debug("Script '" + parameter.ScriptName + "' requested.");

            // Get Dependencies
            ConnectionStringCollection odbcConnectionStrings = ConnectionStringSelector.GetConnectionStringCollection();
            var repository = new GetOdbcDataRepository(odbcConnectionStrings);
            var smtpService = new SmtpService();

            switch (parameter.ScriptName)
            {
                #region General Purpose Commands

                #endregion

                #region PM/Cal-PM Commands

                #endregion

                #region CWS Commands

                #endregion

                #region MSO Commands

                #endregion

                #region Utility and Testing Commands

                case "GetOdbcData":
                    logger.Debug("{command} selected.", nameof(GetOdbcDataCommand));
                    return new GetOdbcDataCommand(optionObjectDecorator, repository);

                case "HelloWorld":
                    logger.Debug(nameof(HelloWorldCommand) + " selected.");
                    return new HelloWorldCommand(optionObjectDecorator);

                case "SendEmail":
                    logger.Debug("{command} selected.", nameof(SendEmailCommand));
                    return new SendEmailCommand(optionObjectDecorator, smtpService);

                case "SetFieldValue":
                    logger.Debug("{command} selected.", nameof(SetFieldValueCommand));
                    return new SetFieldValueCommand(optionObjectDecorator, parameter);

                #endregion

                default:
                    logger.Warn(nameof(DefaultCommand) + " selected because ScriptName '" + parameter.ScriptName + "' does not match an existing command option.");
                    return new DefaultCommand(optionObjectDecorator, parameter);
            }
        }
    }
}