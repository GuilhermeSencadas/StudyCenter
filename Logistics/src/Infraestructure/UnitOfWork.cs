using System.Threading.Tasks;
using Logistics.Domain.Shared;

namespace Logistics.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LogisticsDbContext _context;

        public UnitOfWork(LogisticsDbContext context)
        {
            this._context = context;
        }

        public async Task<int> CommitAsync()
        {
            return await this._context.SaveChangesAsync();
        }
    }
}