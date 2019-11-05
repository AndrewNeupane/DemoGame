using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ItSutra.DemoGame.Configuration;

namespace ItSutra.DemoGame.Web.Host.Startup
{
    [DependsOn(
       typeof(DemoGameWebCoreModule))]
    public class DemoGameWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DemoGameWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DemoGameWebHostModule).GetAssembly());
        }
    }
}
