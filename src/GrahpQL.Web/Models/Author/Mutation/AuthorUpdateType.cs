using GraphQL.Types;

namespace GraphQL.Web.Models.Author.Mutation;

public sealed class AuthorUpdateType : InputObjectGraphType
{
    public AuthorUpdateType()
    {
        Field<NonNullGraphType<IntGraphType>>("id");
        Field<StringGraphType>("name");
    }
}