using RS.ScriptLinkDemo.CSharp.Objects;
using RS.ScriptLinkDemo.CSharp.Soap.Commands;

namespace RS.ScriptLinkDemo.CSharp.Soap.Factories
{
    public static class CommandSelector
    {
        public static IRunScriptCommand GetCommand(OptionObject2015 optionObject2015, string parameter)
        {
            switch (parameter)
            {
                case "HelloWorld":
                    return new HelloWorldCommand(optionObject2015);
                default:
                    return new DefaultCommand(optionObject2015, parameter);
            }
        }
    }
}