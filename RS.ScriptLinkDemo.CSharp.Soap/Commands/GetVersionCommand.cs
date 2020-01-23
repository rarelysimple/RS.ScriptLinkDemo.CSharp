using NLog;
using RarelySimple.AvatarScriptLink.Objects;
//using RS.ScriptLinkDemo.CSharp.Objects;

namespace RS.ScriptLinkDemo.CSharp.Soap.Commands
{
    public class GetVersionCommand : IGetVersionCommand
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly object _optionObject;

        public GetVersionCommand(object optionObject)
        {
            _optionObject = optionObject;
        }

        public string Execute()
        {
            logger.Debug("Executing GetVersionCommand");

            string version = "v.0.0.1";

            if (_optionObject.GetType() == typeof(OptionObject) ||
                _optionObject.GetType() == typeof(OptionObject2) ||
                _optionObject.GetType() == typeof(OptionObject2015))
                return version + " (" + _optionObject.GetType().Name + ")";
            else
                return version;
        }
    }
}