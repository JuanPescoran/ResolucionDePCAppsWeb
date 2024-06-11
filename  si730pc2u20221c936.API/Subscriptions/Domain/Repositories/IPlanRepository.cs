using si730pc2u20221c936.API.Shared.Domain.Repositories;
using si730pc2u20221c936.API.Subscriptions.Domain.Model.Aggregates;

namespace si730pc2u20221c936.API.Subscriptions.Domain.Repositories;

public interface IPlanRepository : IBaseRepository<Plan>
{
    Task<bool> DoesPlanExistWithName(string name);
}