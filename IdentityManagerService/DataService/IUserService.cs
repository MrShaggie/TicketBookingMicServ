using IdentityManagerService.DTO;

namespace IdentityManagerService.DataService
{
    public interface IUserService
    {
        UserDTO Authenticate(string username, string password);
    }
}
