using System;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public DateTime GetPatientDischargeDateByEpisodeNumber(string facility, string patientId, double episodeNumber)
        {
            string commandString = @"";

            return GetPatientDateTime(_connectionStringCollection.PM, commandString, facility, patientId, episodeNumber);
        }
    }
}
