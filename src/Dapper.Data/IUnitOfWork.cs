using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Dapper.Data
{
    public interface IUnitOfWork : IDisposable
    {
        DbConnection Connection { get; }
        DbTransaction Transaction { get; }
        void Begin();
        void Commit();
        void Rollback();
        Task BeginAsync();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
