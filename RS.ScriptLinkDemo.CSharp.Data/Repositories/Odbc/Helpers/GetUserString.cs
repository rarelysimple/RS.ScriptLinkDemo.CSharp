using System;
using System.Data.Odbc;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        private string GetUserString(string connectionString, string commandString, string facility, string userId)
        {
            string stringResult = "";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                OdbcCommand command = new OdbcCommand(commandString, connection);
                command.Parameters.Add(new OdbcParameter("FACILITY", facility));
                command.Parameters.Add(new OdbcParameter("USERID", userId));

                try
                {
                    connection.Open();
                    object obj = command.ExecuteScalar();
                    if (obj != null && obj != DBNull.Value)
                        stringResult = (string)obj;
                }
                catch (OdbcException ex)
                {
                    logger.Error(ex, "GetUserString: Could not connect to ODBC data source. See error message. Data Source: {systemDsn}. Error: {errorMessage}", connectionString, ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "GetUserString: An unexpected error occurred. Error Type: {errorType}. Error: {errorMessage}", ex.GetType(), ex.Message);
                    throw;
                }
            }

            return stringResult;
        }
    }
}
