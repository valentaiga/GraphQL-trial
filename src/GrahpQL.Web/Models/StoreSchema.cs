using GraphQL.Types;

namespace GraphQL.Web.Models;

public sealed class StoreSchema : Schema
{
    public StoreSchema(IServiceProvider serviceProvider)
        : base(serviceProvider)
    {
        Query = serviceProvider.GetRequiredService<StoreQuery>();
        Mutation = serviceProvider.GetRequiredService<StoreMutation>();
        Subscription = serviceProvider.GetRequiredService<StoreSubscription>();
    }
}