using Abp.Authorization;
using ItSutra.DemoGame.Authorization.Roles;
using ItSutra.DemoGame.Authorization.Users;

namespace ItSutra.DemoGame.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
