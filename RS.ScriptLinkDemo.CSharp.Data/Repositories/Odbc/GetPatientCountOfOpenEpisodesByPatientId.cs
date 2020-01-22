using System;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public int GetPatientCountOfOpenEpisodesByPatientId(string facility, string patientId)
        {
            string commandString = @"";

            try
            {
                return GetPatientInt(_connectionStringCollection.PM, commandString, facility, patientId);
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "GetPatientCountOfOpenEpisodesByPatientId: An error occurred. Error: {errorMessage}.", ex.Message);
                throw;
            }
        }
    }
}
