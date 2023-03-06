namespace GraphQL.Models.Responses.Book;

public class BookWrap<TResponse>
{
    public TResponse Book { get; set; }
}