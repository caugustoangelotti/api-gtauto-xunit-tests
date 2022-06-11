using System.Threading.Tasks;
using apilocadora.Data.Models;

namespace apilocadora.Services.Security
{
    public interface IJwtAuthManager
    {
        Task<string> GetEncryptedPasswordAsync(string password);
        Task<bool> AuthAsync(string password, string passwordHash);
        Task<bool> ArePasswordsEqualsAsync(string password, string passwordToCompare);
        Task<string> GetJwtTokenAsync(TokenClaims tokenClaims);
    }
}