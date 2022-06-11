using System.Threading.Tasks;
using apilocadora.Repositories;

namespace apilocadora.Services.Security
{
    public class JwtAuthManager : IJwtAuthManager
    {
        private readonly ISecurityService _securityService;
        private readonly TokenManager _tokenManager;

        public JwtAuthManager(IUserRepository userRepository, ISecurityService securityService, TokenManager tokenManager)
        {
            _securityService = securityService;
            _tokenManager = tokenManager;
        }

        public async Task<bool> ArePasswordsEqualsAsync(string password, string passwordToCompare)
        {
            return await _securityService.ArePasswordsEqualsAsync(password, passwordToCompare);
        }

        public async Task<bool> AuthAsync(string password, string passwordHash)
        {
            return await _securityService.VerifyPasswordAsync(password, passwordHash);
        }

        public async Task<string> GetEncryptedPasswordAsync(string password)
        {
            return await _securityService.EncryptPasswordAsync(password);
        }

        public async Task<string> GetJwtTokenAsync(TokenClaims tokenClaims)
        {
            return await _tokenManager.GenerateTokenAsync(tokenClaims);
        }
    }
}