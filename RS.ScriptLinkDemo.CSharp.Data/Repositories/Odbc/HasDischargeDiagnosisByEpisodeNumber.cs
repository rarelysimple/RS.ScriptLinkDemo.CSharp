﻿namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public bool HasDischargeDiagnosisByEpisodeNumber(string facility, string patientId, double episodeNumber)
        {
            string commandString = @"";

            return GetPatientBool(_connectionStringCollection.PM, commandString, facility, patientId, episodeNumber);
        }
    }
}
