using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Sdt.Controllers
{
    public abstract class SdtControllerBase: AbpController
    {
        protected SdtControllerBase()
        {
            LocalizationSourceName = SdtConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
