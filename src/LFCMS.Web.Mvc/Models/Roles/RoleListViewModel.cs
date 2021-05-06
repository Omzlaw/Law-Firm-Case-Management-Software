using System.Collections.Generic;
using LFCMS.Roles.Dto;

namespace LFCMS.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
