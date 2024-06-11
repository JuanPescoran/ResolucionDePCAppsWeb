using si730pc2u20221c936.API.Subscriptions.Domain.Model.Aggregates;
using si730pc2u20221c936.API.Subscriptions.Domain.Model.Commands;

namespace si730pc2u20221c936.API.Subscriptions.Domain.Services;

public interface IPlanCommandService
{
    Task<bool> DoesPlanExistWithName(string name);
    Task<Plan?> Handle(CreatePlanCommand command);
}