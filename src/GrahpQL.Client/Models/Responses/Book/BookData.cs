using GraphQL.Api.Client.Models.Responses.Author;

namespace GraphQL.Api.Client.Models.Responses.Book;

public class BookData
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public AuthorData Author { get; set; }
}