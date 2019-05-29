using Gql.Core.Data;
using Gql.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Gql.Core.Services
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book GetByName(string name);
    }
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Book> GetAll() => _context.Books.Include(x => x.Writer).ToList();
        public Book GetByName(string name) => _context.Books.Include(x => x.Writer).FirstOrDefault(x => x.Name == name);


    }
}
