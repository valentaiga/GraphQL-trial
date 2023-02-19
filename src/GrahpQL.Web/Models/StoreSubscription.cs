using GraphQL.Types;
using GraphQL.Web.Models.Book.Subscription;
using GraphQL.Web.Services;

namespace GraphQL.Web.Models;

public sealed class StoreSubscription : ObjectGraphType
{
    public StoreSubscription(IBookEventService eventService)
    {
        Field<BookEventType>("bookUpdated")
            .Description("Subscribe on book update")
            .ResolveStream(_ => eventService.OnUpdate());
    }
}