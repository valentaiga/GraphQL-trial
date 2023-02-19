namespace GraphQL.Models.Responses.Author;

public class AuthorData : AuthorShortData
{
    public ICollection<BookData> Books { get; set; }
}