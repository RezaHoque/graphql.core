using Gql.Core.GraphQL.GraphQLTypes;
using Gql.Core.Services;
using GraphQL.Types;

namespace Gql.Core.GraphQL.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IAuthorRepository repository)
        {
            Field<ListGraphType<AuthorType>>("authors", resolve: x => repository.GetAll());
        }
    }
}
