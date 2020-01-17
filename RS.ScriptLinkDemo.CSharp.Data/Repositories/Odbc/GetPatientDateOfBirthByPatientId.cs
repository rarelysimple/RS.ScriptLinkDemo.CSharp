using System;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public DateTime GetPatientDateOfBirthByPatientId(string facility, string patientId)
        {
            string commandString = @"";

            return GetPatientDateTime(commandString, facility, patientId);
        }
    }
}
