using si730pc2u20221c936.API.Subscriptions.Domain.Model.Aggregates;
using si730pc2u20221c936.API.Subscriptions.Interfaces.REST.Resources;

namespace si730pc2u20221c936.API.Subscriptions.Interfaces.REST.Transform;

public static class PlanResourceFromEntityAssembler
{
    public static PlanResource ToResourceFromEntity(Plan plan)
    {
        return new PlanResource(
            plan.Id,
            plan.Name,
            plan.MaxUsers,
            plan.IsDefault
        );
    }
}