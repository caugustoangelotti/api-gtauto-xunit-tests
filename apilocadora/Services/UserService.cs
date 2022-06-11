using System.Threading.Tasks;
using apilocadora.Data.Models;
using apilocadora.Repositories;

namespace apilocadora.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AddUserAsync(User user)
        {
            var newUser = await _userRepository.AddUserAsync(user);
            return newUser;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            return user;
        }

        public void Dispose()
        {
            _userRepository.Dispose();
        }

    }
}