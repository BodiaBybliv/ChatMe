using System.Security.Claims;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IServices.IHelpers
{
    public interface IJwtHelper
    {
        Task<ClaimsIdentity> GetIdentityAsync(string email);

        string GenerateRefreshToken(int size = 32);

        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
