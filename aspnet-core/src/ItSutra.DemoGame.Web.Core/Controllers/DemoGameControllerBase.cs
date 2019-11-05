using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ItSutra.DemoGame.Controllers
{
    public abstract class DemoGameControllerBase: AbpController
    {
        protected DemoGameControllerBase()
        {
            LocalizationSourceName = DemoGameConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
