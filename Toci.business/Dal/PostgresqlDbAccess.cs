using System.Data;
using System.Data.Common;
using Npgsql;

namespace Toci.business.Dal
{
    public class PostgresqlDbAccess : DbAccessBase
    {
        protected NpgsqlConnection Connection;

        public override bool Connect(string connectionString)
        {
            Connection = new NpgsqlConnection(connectionString);

            Connection.Open();

            return Connection.State == ConnectionState.Open;
        }

        public override bool ExecuteInsert(string query)
        {
            Connect("User ID=postgres;Password=beatka;Host=localhost;Port=5432;Database=translator;");
            NpgsqlCommand command = Connection.CreateCommand();

            command.CommandText = query;

            return command.ExecuteNonQuery() > 0;


        }

        public override DataTable ExecuteSelect(string @select)
        {
            Connect("User ID=postgres;Password=beatka;Host=localhost;Port=5432;Database=translator;");
            NpgsqlCommand command = Connection.CreateCommand();

            command.CommandText = @select;

            DbDataReader reader = command.ExecuteReader();

            DataTable dtb = new DataTable();

            dtb.Load(reader);

            return dtb;
        }
    }
}