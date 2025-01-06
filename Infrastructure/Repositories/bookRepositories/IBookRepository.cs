using Domain.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.bookRepositories
{
    public interface IBookRepository
    {
        Task<Book> GetByIdAsync(int id);// دریافت یک کتاب با شناسه
        Task<IEnumerable<Book>> GetAllAsync();// دریافت همه کتاب‌ها
        Task AddAsync(Book book);  // افزودن کتاب جدید
        Task UpdateAsync(Book book);  // به‌روزرسانی کتاب
        Task DeleteAsync(long id);  // حذف کتاب
    }
}
