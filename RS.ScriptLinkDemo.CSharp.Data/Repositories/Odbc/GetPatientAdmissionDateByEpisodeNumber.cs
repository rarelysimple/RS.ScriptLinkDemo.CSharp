using System;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public DateTime GetPatientAdmissionDateByEpisodeNumber(string facility, string patientId, double episodeNumber)
        {
            string commandString = @"";

            try
            {
                return GetPatientDateTime(_connectionStringCollection.PM, commandString, facility, patientId, episodeNumber);
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "GetPatientAdmissionDateByEpisodeNumber: An error occurred. Error: {errorMessage}.", ex.Message);
                throw;
            }
        }
    }
}
