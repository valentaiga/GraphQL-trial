using System.Text.Json.Serialization;
using GraphQL.SystemTextJson;

namespace GraphQL.Web.Models;

public class GraphQLQuery
{
    public string? OperationName { get; set; }
    public string? Query { get; set; }
    [JsonConverter(typeof(InputsJsonConverter))] public Inputs? Variables { get; set; }
}