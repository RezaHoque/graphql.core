using Gql.Core.Models;
using System.Linq;

namespace Gql.Core.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Authors.Any())
            {
                return;
            }

            if (context.Books.Any())
            {
                return;
            }

            var authors = new Author[]
            {
                new Author {Name = "Fyodor Dostoevsky", Country = "Russia"},
                new Author {Name = "Lev Tolstoj", Country = "Russia"},
                new Author {Name = "Rabindranath Tagore", Country = "India"},
                new Author {Name = "Mary Shelley", Country = "England"},
                new Author {Name = "William Shakespeare", Country = "England"},
                new Author {Name = "Tahmima Anam", Country = "Bangladesh"}

            };

            foreach (var author in authors)
            {
                context.Authors.Add(author);


            }

            var books = new Book[]
            {
                new Book {Name = "Idiot", Writer = authors.FirstOrDefault(x=>x.Name=="Fyodor Dostoevsky"), FirstPublish = "1869"},
                new Book {Name = "The Karamazov Brothers", Writer = authors.FirstOrDefault(x=>x.Name=="Fyodor Dostoevsky"), FirstPublish = "1880"},
                new Book {Name = "War and Peace", Writer = authors.FirstOrDefault(x=>x.Name=="Lev Tolstoj"), FirstPublish = "1869"},
                new Book {Name = "Anna Karenina", Writer = authors.FirstOrDefault(x=>x.Name=="Lev Tolstoj"), FirstPublish = ""},
                new Book {Name = "Gitanjali", Writer = authors.FirstOrDefault(x=>x.Name=="Rabindranath Tagore"), FirstPublish = ""},
                new Book {Name = "Chokher Bali", Writer = authors.FirstOrDefault(x=>x.Name=="Rabindranath Tagore"), FirstPublish = ""},
                new Book {Name = "Frankenstein", Writer = authors.FirstOrDefault(x=>x.Name=="Mary Shelley"), FirstPublish = "1818"},
                new Book {Name = "Hamlet", Writer = authors.FirstOrDefault(x=>x.Name=="William Shakespeare"), FirstPublish = "1609"},
                new Book {Name = "Romeo and Juliet", Writer = authors.FirstOrDefault(x=>x.Name=="William Shakespeare"), FirstPublish = "1597"},
                new Book {Name = "A Golden Age", Writer = authors.FirstOrDefault(x=>x.Name=="Tahmima Anam"), FirstPublish = "2007"},
            };

            foreach (var book in books)
            {
                context.Books.Add(book);


            }

            context.SaveChanges();

        }

    }
}
