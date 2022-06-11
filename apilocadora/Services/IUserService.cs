using System;
using System.Threading.Tasks;
using apilocadora.Data.Models;

namespace apilocadora.Services
{
    public interface IUserService : IDisposable
    {
        Task<User>GetUserByEmailAsync(string email);
        Task<User>AddUserAsync(User user);
    }
}