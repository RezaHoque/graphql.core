using Gql.Core.Models;
using GraphQL.Types;

namespace Gql.Core.GraphQL.GraphQLTypes
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id of the Book object");
            Field(x => x.Name).Description("Name property of the Book object");
            Field(x => x.FirstPublish).Description("The First publish year of the Book object");
            Field<AuthorType>(nameof(Book.Writer));//.Description("The Author of the Book");
        }
    }
}
