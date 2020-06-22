using IdentityManagerService.Entities;
using IdentityManagerService.Infrastructure;
using System.Linq;

namespace IdentityManagerService.DataService
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext;
        public UserRepository(UserContext context)
        {
            _userContext = context;
        }
        public User GetUser(string username, string password)
        {
            return _userContext.Users.SingleOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}
