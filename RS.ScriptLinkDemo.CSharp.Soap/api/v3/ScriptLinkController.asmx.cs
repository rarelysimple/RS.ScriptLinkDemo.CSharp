using RS.ScriptLinkDemo.CSharp.Objects;
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
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ScriptLinkController : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetVersion()
        {
            IGetVersionCommand command = new GetVersionCommand(new OptionObject2015());
            return command.Execute();
        }

        [WebMethod]
        public OptionObject2015 RunScript(OptionObject2015 optionObject2015, string parameter)
        {
            IRunScriptCommand command = CommandSelector.GetCommand(optionObject2015, parameter);
            return command.Execute();
        }
    }
}
