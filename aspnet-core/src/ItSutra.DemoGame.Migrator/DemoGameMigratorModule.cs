using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ItSutra.DemoGame.Configuration;
using ItSutra.DemoGame.EntityFrameworkCore;
using ItSutra.DemoGame.Migrator.DependencyInjection;

namespace ItSutra.DemoGame.Migrator
{
    [DependsOn(typeof(DemoGameEntityFrameworkModule))]
    public class DemoGameMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public DemoGameMigratorModule(DemoGameEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(DemoGameMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                DemoGameConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DemoGameMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
