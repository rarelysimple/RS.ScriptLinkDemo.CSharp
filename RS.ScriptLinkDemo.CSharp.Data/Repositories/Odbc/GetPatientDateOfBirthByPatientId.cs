using System;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public DateTime GetPatientDateOfBirthByPatientId(string facility, string patientId)
        {
            string commandString = @"";

            try
            {
                return GetPatientDateTime(_connectionStringCollection.PM, commandString, facility, patientId);
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "GetPatientDateOfBirthByPatientId: An error occurred. Error: {errorMessage}.", ex.Message);
                throw;
            }
        }
    }
}
