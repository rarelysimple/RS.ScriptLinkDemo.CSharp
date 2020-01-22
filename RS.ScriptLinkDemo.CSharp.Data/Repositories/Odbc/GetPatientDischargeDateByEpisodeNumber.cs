using System;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public DateTime GetPatientDischargeDateByEpisodeNumber(string facility, string patientId, double episodeNumber)
        {
            string commandString = @"";

            try
            {
                return GetPatientDateTime(_connectionStringCollection.PM, commandString, facility, patientId, episodeNumber);
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "GetPatientDischargeDateByEpisodeNumber: An error occurred. Error: {errorMessage}.", ex.Message);
                throw;
            }
        }
    }
}
