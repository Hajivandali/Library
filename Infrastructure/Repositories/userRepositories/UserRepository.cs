using Domain.Entitie;
using Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.userRepositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryContext? _libraryContext;

        public UserRepository(LibraryContext context) {
            _libraryContext = context;

        }

        public async Task AddAsync(User user) // Add user 
        {
            await _libraryContext.Users.AddAsync(user);
            await _libraryContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)// Delete user 
        {
            var user= _libraryContext.Users.FindAsync(id);
            if (user != null) { 
                _libraryContext.Users.Remove(await user);
                await _libraryContext.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<User>> GetAllAsync() // get All user
        {
            return await _libraryContext.Users.ToListAsync();
        }

        public async Task<User> GetBIdAsync(int id) // find User By ID
        {
            return await _libraryContext.Users.FindAsync(id);
        }

        public async Task UpdateAsync(User user)
        {
            _libraryContext.Users.Update(user); // Update user 
            await _libraryContext.SaveChangesAsync();
        }
    }
}
