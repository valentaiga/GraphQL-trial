using GraphQL.Types;
using GraphQL.Web.Models.Author.Mutation;
using GraphQL.Web.Models.Book.Mutation;

namespace GraphQL.Web.Models;

public sealed class StoreMutation : ObjectGraphType
{
    public StoreMutation()
    {
        Name = "Mutation";
        Field<AuthorGroupMutation>("author").Resolve(_ => new {});
        Field<BookGroupMutation>("book").Resolve(_ => new {});
    }
}