using System.Collections.Generic;
using LFCMS.Roles.Dto;

namespace LFCMS.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}