using Abp.Authorization;
using Skinet.Authorization.Roles;
using Skinet.Authorization.Users;

namespace Skinet.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
