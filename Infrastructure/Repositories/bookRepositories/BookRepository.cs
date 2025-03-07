using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entitie;
using Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Repositories.bookRepositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext? _libraryContext;


        public BookRepository (LibraryContext context)
        {
            _libraryContext = context;
        }

       


        public async Task AddAsync(Book book)  // Add Book 
        {
            await _libraryContext.Books.AddAsync(book);
            await _libraryContext.SaveChangesAsync();


        }

        public async Task DeleteAsync(long id)      // Remove Book 
        {
            var book = await _libraryContext.Books.FindAsync(id);
            if (book != null)
            {
                _libraryContext.Books.Remove(book); 
                await _libraryContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Book>> GetAllAsync() // GeT All by ID
        {
            return await _libraryContext.Books.ToListAsync();

        }

        public async Task<Book> GetByIdAsync(int id)  // find by ID
        {
            return await _libraryContext.Books.FindAsync(id);
        }

        public async Task UpdateAsync(Book book)   // Update by ID
        {
            _libraryContext.Books.Update(book);
            await _libraryContext.SaveChangesAsync();
        }
    }
}
