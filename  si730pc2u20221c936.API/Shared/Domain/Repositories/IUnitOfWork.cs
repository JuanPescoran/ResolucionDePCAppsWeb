using System.Threading.Tasks;

namespace si730pc2u20221c936.API.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}