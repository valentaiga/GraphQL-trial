using GraphQL.Types;
using GraphQL.Web.Models.Book.Query;

namespace GraphQL.Web.Models.Book.Subscription;

public sealed class BookEventType : ObjectGraphType<BookEvent>
{
    public BookEventType()
    {
        Field<BookType>("book")
            .Resolve(ctx => ctx.Source.Book);
        Field(f => f.Timestamp);
    }
}