using NLog;
using RarelySimple.AvatarScriptLink.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RS.ScriptLinkDemo.CSharp.Soap.Commands
{
    public class SetFieldValueCommand : IRunScriptCommand
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly OptionObject2015 _optionObject2015;
        private readonly string _parameter;

        public SetFieldValueCommand(OptionObject2015 optionObject2015, string parameter)
        {
            _optionObject2015 = optionObject2015;
            _parameter = parameter;
        }

        public OptionObject2015 Execute()
        {
            logger.Debug("Executing SetFieldValueCommand");

            if (_optionObject2015.IsFieldPresent("123"))
                _optionObject2015.SetFieldValue("123", "Set by ScriptLink API.");
            return _optionObject2015.ToOptionObject2015();
        }
    }
}