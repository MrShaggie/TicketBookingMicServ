using IdentityManagerService.Entities;

namespace IdentityManagerService.DataService
{
    public interface IUserRepository
    {
        User GetUser(string username, string password);
    }
}
