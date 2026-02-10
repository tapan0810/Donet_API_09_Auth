using Donet_API_09_Auth.Dtos;
using Donet_API_09_Auth.Entities;

namespace Donet_API_09_Auth.Services
{
    public interface IAuthService
    {
         Task<User?> RegisterAsync(UserDto request);

         Task<string?> LoginAsync(UserDto request);

    }
}
