using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Skinet.Controllers
{
    public abstract class SkinetControllerBase: AbpController
    {
        protected SkinetControllerBase()
        {
            LocalizationSourceName = SkinetConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
