using si730pc2u20221c936.API.Shared.Domain.Repositories;
using si730pc2u20221c936.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using si730pc2u20221c936.API.Subscriptions.Domain.Model.Aggregates;
using si730pc2u20221c936.API.Subscriptions.Domain.Model.Commands;
using si730pc2u20221c936.API.Subscriptions.Domain.Repositories;
using si730pc2u20221c936.API.Subscriptions.Domain.Services;

namespace si730pc2u20221c936.API.Subscriptions.Application.Internal.CommandServices;

public class PlanCommandService(IPlanRepository planRepository, IUnitOfWork unitOfWork) : IPlanCommandService
{
    public async Task<Plan?> Handle(CreatePlanCommand command)
    {
        var plan = new Plan(command);
        try
        {
            await planRepository.AddAsync(plan);
            await unitOfWork.CompleteAsync();
            return plan;
        } catch(Exception e)
        {
            Console.WriteLine($"An error occurred while creating a plan: {e.Message}");
            return null;
        }
    }
    
    public async Task<bool> DoesPlanExistWithName(string name)
    {
        return await planRepository.DoesPlanExistWithName(name);
    }
}