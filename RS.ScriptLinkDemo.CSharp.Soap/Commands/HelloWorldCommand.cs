using RS.ScriptLinkDemo.CSharp.Objects;

namespace RS.ScriptLinkDemo.CSharp.Soap.Commands
{
    public class HelloWorldCommand : IRunScriptCommand
    {
        private readonly OptionObject2015 _optionObject2015;

        public HelloWorldCommand(OptionObject2015 optionObject2015)
        {
            _optionObject2015 = optionObject2015;
        }

        public OptionObject2015 Execute()
        {
            return new OptionObject2015()
            {
                EntityID = _optionObject2015.EntityID,
                EpisodeNumber = _optionObject2015.EpisodeNumber,
                ErrorCode = 3,
                ErrorMesg = "Hello, World!",
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