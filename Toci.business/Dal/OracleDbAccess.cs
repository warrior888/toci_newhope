using System.Data;

namespace Toci.business.Dal
{
    public class OracleDbAccess : DbAccessBase
    {
        public override bool Connect(string connectionString)
        {
            throw new System.NotImplementedException();
        }

        public override bool ExecuteInsert(string query)
        {
            throw new System.NotImplementedException();
        }

        public override DataTable ExecuteSelect(string @select)
        {
            throw new System.NotImplementedException();
        }
    }
}