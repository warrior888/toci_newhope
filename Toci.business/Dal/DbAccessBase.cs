using System.Data;

namespace Toci.business.Dal
{
    public abstract class DbAccessBase<TResult>
    {

        public abstract bool Connect(string connectionString);

        public abstract int ExecuteInsert(string query);

        public abstract TResult ExecuteSelect(string select);

    }
}