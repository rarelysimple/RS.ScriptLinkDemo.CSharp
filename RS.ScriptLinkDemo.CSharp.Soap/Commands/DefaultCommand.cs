using NLog;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RS.ScriptLinkDemo.CSharp.Soap.Commands
{
    public class DefaultCommand : IRunScriptCommand
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IOptionObjectDecorator _optionObjectDecorator;
        private readonly IParameter _parameter;

        public DefaultCommand(IOptionObjectDecorator optionObjectDecorator, IParameter parameter)
        {
            _optionObjectDecorator = optionObjectDecorator;
            _parameter = parameter;
        }

        public IOptionObject2015 Execute()
        {
            string message = "Error: There is no command matching the script name '" + _parameter.ScriptName + "'. Please verify your settings.";
            logger.Error(message);
            return _optionObjectDecorator.ToReturnOptionObject(ErrorCode.Alert, message);
        }
    }
}