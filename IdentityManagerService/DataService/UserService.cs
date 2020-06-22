using IdentityManagerService.DTO;

namespace IdentityManagerService.DataService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public UserDTO Authenticate(string username, string password)
        {
            var user = _userRepo.GetUser(username, password);

            if (user == null) return null;

            var userDTO = new UserDTO()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                RoleId = user.RoleId,
                Username = user.Username
            };
            return userDTO;
        }
    }
}
