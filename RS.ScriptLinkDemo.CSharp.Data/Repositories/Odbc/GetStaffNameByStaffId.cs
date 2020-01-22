using System;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        public string GetStaffNameByStaffId(string facility, string staffId)
        {
            string commandString = @"";

            try
            {
                return GetStaffString(_connectionStringCollection.PM, commandString, facility, staffId);
            }
            catch (Exception ex)
            {
                logger.Debug(ex, "GetStaffNameByStaffId: An error occurred. Error: {errorMessage}.", ex.Message);
                throw;
            }
        }
    }
}
