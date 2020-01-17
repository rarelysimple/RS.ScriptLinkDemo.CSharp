namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public string GetStaffNameByStaffId(string facility, string staffId)
        {
            string commandString = @"";

            return GetStaffString(commandString, facility, staffId);
        }
    }
}
