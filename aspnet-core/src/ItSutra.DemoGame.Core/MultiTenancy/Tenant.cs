using Abp.MultiTenancy;
using ItSutra.DemoGame.Authorization.Users;

namespace ItSutra.DemoGame.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
