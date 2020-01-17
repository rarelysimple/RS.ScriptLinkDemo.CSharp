using RS.ScriptLinkDemo.CSharp.Data.Models;
using System.Configuration;

namespace RS.ScriptLinkDemo.CSharp.Soap.Factories
{
    public static class ConnectionStringSelector
    {
        public static ConnectionStringCollection GetConnectionString()
        {
            string pmString = GetConnectionString("AVPM");
            string cwsString = GetConnectionString("AVCWS");
            string msoString = GetConnectionString("AVMSO");
            return new ConnectionStringCollection(pmString, cwsString, msoString);
        }

        private static string GetConnectionString(string namespaceName)
        {
            string connectionName = GetConnectionStringName(namespaceName);
            if (connectionName != null && ConfigurationManager.ConnectionStrings[connectionName] != null)
                return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            return "";
        }

        public static string GetConnectionStringName(string namespaceName)
        {
            return "ODBC" + namespaceName;
        }
    }
}