using NLog;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RS.ScriptLinkDemo.CSharp.Soap.Commands
{
    public class HelloWorldCommand : IRunScriptCommand
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IOptionObjectDecorator _optionObject;

        public HelloWorldCommand(IOptionObjectDecorator optionObject)
        {
            _optionObject = optionObject;
        }

        public IOptionObject2015 Execute()
        {
            logger.Debug("Executing HelloWorldCommand");
            return _optionObject.ToReturnOptionObject(ErrorCode.Informational, "Hello, World!");
        }
    }
}