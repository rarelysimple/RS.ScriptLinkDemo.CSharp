namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository
    {
        private bool SafeGetBool(string boolString)
        {
            switch (boolString.ToUpperInvariant())
            {
                case "1":
                case "TRUE":
                case "Y":
                case "YES":
                    return true;
                default:
                    return false;
            }

        }
    }
}
