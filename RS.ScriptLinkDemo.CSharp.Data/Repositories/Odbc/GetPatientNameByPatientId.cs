using System;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public string GetPatientNameByPatientId(string facility, string patientId)
        {
            string commandString = @"";

            try
            {
                return GetPatientString(_connectionStringCollection.PM, commandString, facility, patientId);
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "GetPatientNameByPatientId: An error occurred. Error: {errorMessage}.", ex.Message);
                throw;
            }
        }
    }
}
