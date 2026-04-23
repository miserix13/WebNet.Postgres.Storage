using Take.Elephant.Sql.PostgreSql;
using Take.Elephant.Sql.Mapping;

namespace WebNet.Postgres.Storage
{
    public class PgsqlList<T>(string connectionString, ITable table, IMapper<T> mapper) : Take.Elephant.Sql.SqlList<T>(new PostgreSqlDatabaseDriver(), connectionString, table, mapper), Take.Elephant.IList<T>
    {
        public override async Task AddAsync(T value)
        {
            await base.AddAsync(value);
        }

        public override IAsyncEnumerable<T> AsEnumerableAsync(CancellationToken cancellationToken = default)
        {
            return base.AsEnumerableAsync(cancellationToken);
        }

        public override async Task<long> GetLengthAsync(CancellationToken cancellationToken = default)
        {
            return await base.GetLengthAsync(cancellationToken);
        }

        public override async Task<long> RemoveAllAsync(T value)
        {
            return await base.RemoveAllAsync(value);
        }
    }
}
