using NLog;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RS.ScriptLinkDemo.CSharp.Soap.Commands
{
    public class SetFieldValueCommand : IRunScriptCommand
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IOptionObjectDecorator _optionObject;
        private readonly IParameter _parameter;

        public SetFieldValueCommand(IOptionObjectDecorator optionObject, IParameter parameter)
        {
            _optionObject = optionObject;
            _parameter = parameter;
        }

        public IOptionObject2015 Execute()
        {
            logger.Debug("Executing SetFieldValueCommand");
            string fieldNumber = _parameter.GetString(1);
            if (_optionObject.IsFieldPresent(fieldNumber))
                _optionObject.SetFieldValue(fieldNumber, "Set by ScriptLink API.");
            return _optionObject.ToOptionObject2015();
        }
    }
}