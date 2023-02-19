using GraphQL.Types;
using GraphQL.Web.Models.Author.Query;
using GraphQL.Web.Models.Book.Query;

namespace GraphQL.Web.Models;

public sealed class StoreQuery : ObjectGraphType
{
    public StoreQuery()
    {
        Name = "Query";
        Field<AuthorGroupType>("author").Resolve(_ => new {});
        Field<BookGroupType>("book").Resolve(_ => new {});
    }
}