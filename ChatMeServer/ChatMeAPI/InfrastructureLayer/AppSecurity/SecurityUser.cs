using Microsoft.AspNetCore.Identity;

namespace InfrastructureLayer.AppSecurity
{
    public class SecurityUser : IdentityUser<int>
    {
        public string RefreshToken { get; set; }
    }
}
