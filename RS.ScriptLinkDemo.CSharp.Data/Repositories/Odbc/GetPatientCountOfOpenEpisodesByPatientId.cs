namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public int GetPatientCountOfOpenEpisodesByPatientId(string facility, string patientId)
        {
            string commandString = @"";

            return GetPatientInt(commandString, facility, patientId);
        }
    }
}
