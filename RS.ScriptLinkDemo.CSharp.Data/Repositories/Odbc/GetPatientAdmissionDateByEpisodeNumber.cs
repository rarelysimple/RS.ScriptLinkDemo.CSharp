using System;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public DateTime GetPatientAdmissionDateByEpisodeNumber(string facility, string patientId, double episodeNumber)
        {
            string commandString = @"";

            return GetPatientDateTime(commandString, facility, patientId, episodeNumber);
        }
    }
}
