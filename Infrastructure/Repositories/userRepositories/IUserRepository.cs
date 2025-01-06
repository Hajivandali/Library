using Domain.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Repositories.userRepositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);// دریافت یک کاربر با شناسه
        Task<IEnumerable<User>> GetAllAsync();  // دریافت همه کاربران
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);


    }
}
