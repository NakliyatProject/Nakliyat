using Microsoft.AspNetCore.Identity;

namespace Application.Service
{
    public interface IAuthService
    {
        IEnumerable<IdentityRole> Roles { get; }
        IEnumerable<IdentityUser> GetAllUsers();
    }
}
