using NLog;
using RarelySimple.AvatarScriptLink.Objects;
//using RS.ScriptLinkDemo.CSharp.Objects;

namespace RS.ScriptLinkDemo.CSharp.Soap.Commands
{
    public class DefaultCommand : IRunScriptCommand
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly OptionObject2015 _optionObject2015;
        private readonly string _parameter;

        public DefaultCommand(OptionObject2015 optionObject2015, string parameter)
        {
            _optionObject2015 = optionObject2015;
            _parameter = parameter;
        }

        public OptionObject2015 Execute()
        {
            string message = "Error: There is no command matching the parameter '" + _parameter + "'. Please verify your settings.";
            logger.Error(message);

            return new OptionObject2015()
            {
                EntityID = _optionObject2015.EntityID,
                EpisodeNumber = _optionObject2015.EpisodeNumber,
                ErrorCode = 3,
                ErrorMesg = message,
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