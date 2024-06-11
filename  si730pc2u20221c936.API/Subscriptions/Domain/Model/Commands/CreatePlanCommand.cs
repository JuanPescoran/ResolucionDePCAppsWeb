namespace si730pc2u20221c936.API.Subscriptions.Domain.Model.Commands;

public record CreatePlanCommand(string Name, int MaxUsers, int IsDefault);