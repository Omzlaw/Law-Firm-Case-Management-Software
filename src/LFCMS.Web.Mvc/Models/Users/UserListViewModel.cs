using System.Collections.Generic;
using LFCMS.Roles.Dto;

namespace LFCMS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
