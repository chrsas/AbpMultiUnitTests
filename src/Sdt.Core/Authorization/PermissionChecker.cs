using Abp.Authorization;
using Sdt.Authorization.Roles;
using Sdt.Authorization.Users;

namespace Sdt.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
