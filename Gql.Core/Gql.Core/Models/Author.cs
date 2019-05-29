using System.Collections.Generic;

namespace Gql.Core.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
