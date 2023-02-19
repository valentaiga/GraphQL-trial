using GraphQL.Web.Services;
using Microsoft.AspNetCore;
using GraphQL.Web.Extensions;

namespace GraphQL.Web;

public static class Program
{
    private static readonly CancellationTokenSource TokenSource = new();

    public static async Task Main(string[] args)
    {
        await CreateWebHostBuilder(args).Build().RunAsync(TokenSource.Token);
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        => WebHost.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
            {
                services.AddSingleton<IBookRepository, BookRepository>();
                services.AddSingleton<IAuthorRepository, AuthorRepository>();
                services.AddSingleton<IBookEventService, BookEventService>();

                services.AddGraphQL(options => { options.Endpoint = "/graphql"; });
            })
            .Configure(app => { app.UseGraphQL(); });
}