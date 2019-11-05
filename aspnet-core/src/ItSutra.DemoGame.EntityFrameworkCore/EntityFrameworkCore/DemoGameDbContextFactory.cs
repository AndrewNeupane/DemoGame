using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ItSutra.DemoGame.Configuration;
using ItSutra.DemoGame.Web;

namespace ItSutra.DemoGame.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DemoGameDbContextFactory : IDesignTimeDbContextFactory<DemoGameDbContext>
    {
        public DemoGameDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DemoGameDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DemoGameDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DemoGameConsts.ConnectionStringName));

            return new DemoGameDbContext(builder.Options);
        }
    }
}
