using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ItSutra.DemoGame.Authorization;

namespace ItSutra.DemoGame
{
    [DependsOn(
        typeof(DemoGameCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DemoGameApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DemoGameAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DemoGameApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
