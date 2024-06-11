using si730pc2u20221c936.API.Subscriptions.Domain.Model.Commands;

namespace si730pc2u20221c936.API.Subscriptions.Domain.Model.Aggregates;

public class Plan
{
    public int Id { get;}
    public string Name { get; private set; }
    public int MaxUsers { get; private set; }
    public int IsDefault { get; private set; }
    
    public Plan(string name, int maxUsers, int isDefault)
    {
        Name = name;
        MaxUsers = maxUsers;
        IsDefault = isDefault;
    }

    public Plan(CreatePlanCommand command)
    {
        Name = command.Name;
        MaxUsers = command.MaxUsers;
        IsDefault = command.IsDefault;
    }
}