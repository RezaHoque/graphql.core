using Gql.Core.Models;
using GraphQL.Types;

namespace Gql.Core.GraphQL.GraphQLTypes
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id of the Author object");
            Field(x => x.Name).Description("Name property of the Author object");
            Field(x => x.Country).Description("Country property of the Author object");
        }
    }
}
