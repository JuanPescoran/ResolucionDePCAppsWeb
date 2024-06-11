using Microsoft.AspNetCore.Mvc;
using si730pc2u20221c936.API.Subscriptions.Domain.Services;
using si730pc2u20221c936.API.Subscriptions.Interfaces.REST.Resources;
using si730pc2u20221c936.API.Subscriptions.Interfaces.REST.Transform;

namespace si730pc2u20221c936.API.Subscriptions.Interfaces.REST;

[ApiController]
[Route("api/v1/plans")]
public class PlansController(IPlanCommandService planCommandService):ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreatePlan([FromBody] CreatePlanResource createPlanResource)
    {
        if (await planCommandService.DoesPlanExistWithName(createPlanResource.Name))
        {
            return Conflict("That name is already being used.");
        }
        if (createPlanResource.MaxUsers <= 0)
        {
            return BadRequest("El valor de MaxUsers debe ser mayor que cero.");
        }
        var createPlanCommand = CreatePlanCommandFromResourceAssembler.ToCommandFromResource(createPlanResource);
        var plan = await planCommandService.Handle(createPlanCommand);
        if (plan is null) return BadRequest();
        var resource = PlanResourceFromEntityAssembler.ToResourceFromEntity(plan);
        return new CreatedResult("", resource);
    }
}