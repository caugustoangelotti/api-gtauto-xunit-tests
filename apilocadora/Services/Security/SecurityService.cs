using System.Threading.Tasks;
using Bcrypt = BCrypt.Net.BCrypt;

namespace apilocadora.Services.Security
{
    public class SecurityService : ISecurityService
    {
        public Task<bool> ArePasswordsEqualsAsync(string password, string confirmPassword)
        {
            if (password.Trim() == confirmPassword.Trim())
                return Task.FromResult(true);
            return Task.FromResult(false);
        }

        public Task<string> EncryptPasswordAsync(string password)
        {
            string passwordHash = Bcrypt.HashPassword(password.Trim());
            return Task.FromResult(passwordHash);
        }

        public Task<bool> VerifyPasswordAsync(string password, string passwordHash)
        {
            return Task.FromResult(Bcrypt.Verify(password.Trim(), passwordHash));
        }
    }
}