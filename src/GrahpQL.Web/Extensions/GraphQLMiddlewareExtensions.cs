using GraphQL.Web.Middleware;
using GraphQL.Web.Models;
using GraphQLOptions = GraphQL.Web.Options.GraphQLOptions;

namespace GraphQL.Web.Extensions;

public static class GraphQLMiddlewareExtensions
{
    public static IApplicationBuilder UseGraphQL(this IApplicationBuilder builder)
    {
        builder.UseWebSockets();
        builder.UseGraphQLAltair();
        return builder.UseMiddleware<GraphQLMiddleware>();
    }

    public static IServiceCollection AddGraphQL(this IServiceCollection services, Action<GraphQLOptions> action)
    {
        services.AddGraphQL(b => b
            .AddSystemTextJson()
            .AddDocumentExecuter<DocumentExecuter>()
            .AddGraphTypes()
            .AddSchema<StoreSchema>()
            .AddComplexityAnalyzer(opt =>
            {
#if !DEBUG
                opt.MaxComplexity = 200;
#endif
            })
        );
        
        return services.Configure(action);
    }
}