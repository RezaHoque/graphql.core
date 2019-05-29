using Gql.Core.GraphQL.GraphQLQueries;
using GraphQL;
using GraphQL.Types;

namespace Gql.Core.GraphQL.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}
