using Abp.Authorization;
using LFCMS.Authorization.Roles;
using LFCMS.Authorization.Users;

namespace LFCMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
