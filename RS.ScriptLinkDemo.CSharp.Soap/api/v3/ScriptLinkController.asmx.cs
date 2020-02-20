using NLog;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using RS.ScriptLinkDemo.CSharp.Soap.Commands;
using RS.ScriptLinkDemo.CSharp.Soap.Factories;
using System.Web.Services;

namespace RS.ScriptLinkDemo.CSharp.Soap.api.v3
{
    /// <summary>
    /// Summary description for ScriptLinkController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class ScriptLinkController : WebService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        [WebMethod]
        public string GetVersion()
        {
            IGetVersionCommand command = new GetVersionCommand(new OptionObject2015());
            if (command == null)
            {
                logger.Error("A valid GetVersion command was not retrieved.");
                return "";
            }
            return command.Execute();
        }

        [WebMethod]
        public OptionObject2015 RunScript(OptionObject2015 optionObject2015, string parameterString)
        {
            IParameter parameter = new Parameter(parameterString);
            IRunScriptCommand command = CommandSelector.GetCommand(optionObject2015, parameter);
            if (command == null)
            {
                logger.Error("A valid RunScript command was not retrieved.");
                return optionObject2015;
            }
            return (OptionObject2015)command.Execute();
        }
    }
}
