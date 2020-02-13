using NLog;
using RS.ScriptLinkDemo.CSharp.Data.Models;
using System.Configuration;

namespace RS.ScriptLinkDemo.CSharp.Soap.Factories
{
    public static class ConnectionStringSelector
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Create connection string collection.
        /// <para>Use this when you have a single facility or the one account can access all required facilities.</para>
        /// </summary>
        /// <returns></returns>
        public static ConnectionStringCollection GetConnectionStringCollection()
        {
            return GetConnectionStringCollection("1");
        }
        /// <summary>
        /// Create connection string collection based on provided facility.
        /// </summary>
        /// <param name="facility">Facility number from OptionObject.</param>
        /// <returns></returns>
        public static ConnectionStringCollection GetConnectionStringCollection(string facility)
        {
            string pmString = GetConnectionString("AVPM", facility);
            string cwsString = GetConnectionString("AVCWS", facility);
            string msoString = GetConnectionString("AVMSO", facility);
            return new ConnectionStringCollection(pmString, cwsString, msoString);
        }

        public static string GetConnectionString(string namespaceName, string facility)
        {
            string connectionName = GetConnectionStringName(namespaceName, facility);
            if (connectionName != null && ConfigurationManager.ConnectionStrings[connectionName] != null)
                return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            return "";
        }

        public static string GetConnectionStringName(string namespaceName, string facility)
        {
            string connectionStringName = "ODBC" + namespaceName;
            if (facility != "1")
                connectionStringName += facility;
            logger.Debug("Selected Connection String Name {connectionStringName}.", connectionStringName);
            return connectionStringName;
        }
    }
}