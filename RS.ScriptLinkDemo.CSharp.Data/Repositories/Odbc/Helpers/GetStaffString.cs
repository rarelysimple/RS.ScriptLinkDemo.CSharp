using System;
using System.Data.Odbc;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        private string GetStaffString(string connectionString, string commandString, string facility, string staffId)
        {
            string stringResult = "";

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                OdbcCommand command = new OdbcCommand(commandString, connection);
                command.Parameters.Add(new OdbcParameter("FACILITY", facility));
                command.Parameters.Add(new OdbcParameter("STAFFID", staffId));

                try
                {
                    connection.Open();
                    stringResult = (string)command.ExecuteScalar();
                }
                catch (OdbcException ex)
                {
                    logger.Error(ex, "GetStaffString: Could not connect to ODBC data source. See error message. Data Source: {systemDsn}. Error: {errorMessage}", connectionString, ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "GetStaffString: An unexpected error occurred. Error Type: {errorType}. Error: {errorMessage}", ex.GetType(), ex.Message);
                    throw;
                }
            }

            return stringResult;
        }
    }
}
