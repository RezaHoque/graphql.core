using Gql.Core.GraphQL.GraphQLTypes;
using Gql.Core.Services;
using GraphQL.Types;

namespace Gql.Core.GraphQL.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IAuthorRepository repository,IBookRepository bookRepository)
        {
            Field<ListGraphType<AuthorType>>("authors", resolve: x => repository.GetAll());
            Field<ListGraphType<BookType>>("books", resolve: x => bookRepository.GetAll());
            Field<BookType>(
                "book",
                arguments: new QueryArguments(new QueryArgument<StringGraphType> {Name = "bookName"}),
                resolve: x =>
                {
                    var name = x.GetArgument<string>("bookName");
                    return bookRepository.GetByName(name);
                });


        }
    }
}
