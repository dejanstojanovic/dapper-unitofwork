using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System.Data.Common;

namespace Dapper.Data.PostgreSql.Extensions
{
    public static class DependencyInjection
    {
        public static void AddDapperSqlServer(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<DbConnection>(provider =>
            {
                return new NpgsqlConnection(connectionString);
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
