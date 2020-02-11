using NLog;
using RS.ScriptLinkDemo.CSharp.Data.Models;

namespace RS.ScriptLinkDemo.CSharp.Data.Repositories.Odbc
{
    public partial class GetOdbcDataRepository : IGetDataRepository
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly ConnectionStringCollection _connectionStringCollection;
        
        public GetOdbcDataRepository(ConnectionStringCollection connectionStringCollection)
        {
            _connectionStringCollection = connectionStringCollection;
        }
    }
}
