using Microsoft.EntityFrameworkCore;
using si730pc2u20221c936.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using si730pc2u20221c936.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using si730pc2u20221c936.API.Subscriptions.Domain.Model.Aggregates;
using si730pc2u20221c936.API.Subscriptions.Domain.Repositories;

namespace si730pc2u20221c936.API.Subscriptions.Infrastructure.Persistence.EFC.Repositories;

public class PlanRepository(AppDbContext context) : BaseRepository<Plan>(context), IPlanRepository
{
    public async Task<bool> DoesPlanExistWithName(string name)
    {
        return await Context.Plans.AnyAsync(p => p.Name == name);
    }
}