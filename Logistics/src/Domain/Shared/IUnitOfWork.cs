using System.Threading.Tasks;

namespace Logistics.Domain.Shared
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
    }
}