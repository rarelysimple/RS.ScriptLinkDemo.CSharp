namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public string GetStaffNameByStaffId(string facility, string staffId)
        {
            string commandString = @"";

            return GetStaffString(_connectionStringCollection.PM, commandString, facility, staffId);
        }
    }
}
