using System;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public bool HasDischargeDiagnosisByEpisodeNumber(string facility, string patientId, double episodeNumber)
        {
            string commandString = @"";

            try
            {
                return GetPatientBool(_connectionStringCollection.PM, commandString, facility, patientId, episodeNumber);
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "HasDischargeDiagnosisByEpisodeNumber: An error occurred. Error: {errorMessage}.", ex.Message);
                throw;
            }
        }
    }
}
