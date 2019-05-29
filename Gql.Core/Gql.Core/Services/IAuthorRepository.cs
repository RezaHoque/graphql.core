using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Gql.Core.Data;
using Gql.Core.Models;

namespace Gql.Core.Services
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAll();
    }

    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _context;

        public AuthorRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Author> GetAll() => _context.Authors.ToList();
    }
}
