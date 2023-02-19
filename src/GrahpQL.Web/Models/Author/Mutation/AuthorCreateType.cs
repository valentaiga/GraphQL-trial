using GraphQL.Types;

namespace GraphQL.Web.Models.Author.Mutation;

public sealed class AuthorCreateType: InputObjectGraphType
{
    public AuthorCreateType()
    {
        Field<NonNullGraphType<StringGraphType>>("name");
    }
}