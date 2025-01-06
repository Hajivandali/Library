using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entitie;
using Infrastructure.DataContext;


namespace Infrastructure.Repositories.bookRepositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext? _libraryContext;


        public BookRepository (LibraryContext context)
        {
            _libraryContext = context;
        }

        public BookRepository()
        {
            _libraryContext = new LibraryContext();
        }



        public async Task AddAsync(Book book)
        {
            await _libraryContext.Books.AddAsync(book);
            await _libraryContext.SaveChangesAsync();


        }

        public async Task DeleteAsync(long id)
        {
            var book = await _libraryContext.Books.FindAsync(id);
            if (book != null)
            {
                _libraryContext.Books.Remove(book); // حذف کتاب
                await _libraryContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _libraryContext.Books.ToListAsync();

        }

        public async Task<Book> GetByIdAsync(int id)  // find by ID
        {
            return await _libraryContext.Books.findAsync();
        }

        public async Task UpdateAsync(Book book)
        {
            _libraryContext.Books.Update(book);
            await _libraryContext.SaveChangesAsync();
        }
    }
}
