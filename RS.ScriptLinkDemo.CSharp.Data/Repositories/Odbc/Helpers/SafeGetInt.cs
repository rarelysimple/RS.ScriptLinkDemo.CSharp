namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        private int SafeGetInt(string intString)
        {
            if (int.TryParse(intString, out int returnInt))
                return returnInt;
            return 0;
        }
    }
}
