namespace GraphQL.Api.Client.Models.Responses.Book;

public class BookWrap<TResponse>
{
    public TResponse Book { get; set; }
}