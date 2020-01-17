namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public string GetPatientNameByPatientId(string facility, string patientId)
        {
            string commandString = @"";

            return GetPatientString(commandString, facility, patientId);
        }
    }
}
