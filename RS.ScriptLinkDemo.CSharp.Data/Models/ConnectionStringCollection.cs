namespace RS.ScriptLinkDemo.CSharp.Data.Models
{
    public class ConnectionStringCollection
    {
        public ConnectionStringCollection(string pmString, string cwsString, string msoString)
        {
            PM = pmString;
            CWS = cwsString;
            MSO = msoString;
        }

        public string PM { get; }

        public string CWS { get; }

        public string MSO { get; }
    }
}
