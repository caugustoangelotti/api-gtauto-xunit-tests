using System.Linq;
using System.Threading.Tasks;
using apilocadora.Data.Models;
using apilocadora.Data.Models.InputModel;
using Microsoft.EntityFrameworkCore;

namespace apilocadora.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppEfCoreDbContext _context;

        public UserRepository(AppEfCoreDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(j => j.Email == email);
            return user;
        }

        public async Task<User> AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}