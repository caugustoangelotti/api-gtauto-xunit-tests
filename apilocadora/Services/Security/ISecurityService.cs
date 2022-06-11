using System.Threading.Tasks;

namespace apilocadora.Services.Security
{
    public interface ISecurityService
    {
        Task<bool>ArePasswordsEqualsAsync(string password, string passwordToCompare);
        Task<bool>VerifyPasswordAsync(string password, string passwordHash);
        Task<string>EncryptPasswordAsync(string password);
    }
}