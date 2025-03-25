using DataAccess.Contexts;
using DataAccess.Entities;
using DataAccess.IRepositories;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IdentityAppDbContext _idDbContext;

        public UserRepository(IdentityAppDbContext cntxt)
        {
            _idDbContext = cntxt;
        }
        Task<User> IUserRepository.AddUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        Task IUserRepository.DeleteUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<User> IUserRepository.GetUserByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<User>> IUserRepository.GetUsersAsync()
        {
            return await _idDbContext.Users.ToListAsync();
        }

        Task IUserRepository.UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
