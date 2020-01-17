using RS.ScriptLinkDemo.CSharp.Objects;
using System.Configuration;

namespace RS.ScriptLinkDemo.CSharp.Soap.Factories
{
    public static class ConnectionStringSelector
    {
        public static string GetConnectionString(OptionObject2015 optionObject)
        {
            if (optionObject == null)
                return "";

            return GetConnectionString(optionObject.NamespaceName);
        }
        public static string GetConnectionString(string namespaceName)
        {
            string connectionName = GetConnectionStringName(namespaceName);
            if (connectionName != null && ConfigurationManager.ConnectionStrings[connectionName] != null)
                return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            return "";
        }

        public static string GetConnectionStringName(OptionObject2015 optionObject)
        {
            if (optionObject == null)
                return "";

            return GetConnectionStringName(optionObject.NamespaceName);
        }

        public static string GetConnectionStringName(string namespaceName)
        {
            return "ODBC" + namespaceName;
        }
    }
}