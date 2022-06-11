using System;
using System.Threading.Tasks;
using apilocadora.Data.Models;
using apilocadora.Data.Models.InputModel;

namespace apilocadora.Repositories
{
    public interface IUserRepository : IDisposable
    {
        Task<User>GetUserByEmailAsync(string email);
        Task<User>AddUserAsync(User userData);
    }
}