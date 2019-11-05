using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ItSutra.DemoGame.Authorization;
using ItSutra.DemoGame.Authorization.Roles;
using ItSutra.DemoGame.Authorization.Users;
using ItSutra.DemoGame.Editions;
using ItSutra.DemoGame.MultiTenancy;

namespace ItSutra.DemoGame.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
