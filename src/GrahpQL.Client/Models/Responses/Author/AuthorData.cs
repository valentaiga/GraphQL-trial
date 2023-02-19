using GraphQL.Api.Client.Models.Responses.Book;

namespace GraphQL.Api.Client.Models.Responses.Author;

public class AuthorData : AuthorShortData
{
    public ICollection<BookData> Books { get; set; }
}