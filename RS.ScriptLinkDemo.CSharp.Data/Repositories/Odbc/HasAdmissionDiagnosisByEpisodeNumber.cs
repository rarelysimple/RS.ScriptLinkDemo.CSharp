using System;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public bool HasAdmissionDiagnosisByEpisodeNumber(string facility, string patientId, double episodeNumber)
        {
            string commandString = @"";

            try
            {
                return GetPatientBool(_connectionStringCollection.PM, commandString, facility, patientId, episodeNumber);
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "HasAdmissionDiagnosisByEpisodeNumber: An error occurred. Error: {errorMessage}.", ex.Message);
                throw;
            }
        }
    }
}
