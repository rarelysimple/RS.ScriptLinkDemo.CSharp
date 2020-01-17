using RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc;
using RS.ScriptLinkDemo.CSharp.Objects;
using RS.ScriptLinkDemo.CSharp.Soap.Commands;

namespace RS.ScriptLinkDemo.CSharp.Soap.Factories
{
    public static class CommandSelector
    {
        /// <summary>
        /// Returns the desired command based on the provided <see cref="OptionObject2015"/> and parameter.
        /// </summary>
        /// <param name="optionObject2015"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static IRunScriptCommand GetCommand(OptionObject2015 optionObject2015, string parameter)
        {
            // Determine ScriptName
            string scriptName = parameter != null ? parameter.Split(',')[0] : "";

            // Get Dependencies
            string odbcConnectionString = ConnectionStringSelector.GetConnectionString(optionObject2015);   // BUG: Connection String Limited to Namespace of OptionObject
            var repository = new GetOdbcDataRepository(odbcConnectionString);

            switch (scriptName)
            {
                #region General Purpose Commands

                #endregion

                #region PM Commands

                #endregion

                #region CWS Commands

                #endregion

                #region MSO Commands

                #endregion

                #region Utility and Testing Commands

                case "HelloWorld":
                    return new HelloWorldCommand(optionObject2015);

                #endregion

                default:
                    return new DefaultCommand(optionObject2015, parameter);
            }
        }
    }
}