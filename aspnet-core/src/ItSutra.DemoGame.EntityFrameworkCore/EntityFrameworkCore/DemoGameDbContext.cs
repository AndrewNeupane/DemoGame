using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ItSutra.DemoGame.Authorization.Roles;
using ItSutra.DemoGame.Authorization.Users;
using ItSutra.DemoGame.MultiTenancy;
using ItSutra.DemoGame.Game;

namespace ItSutra.DemoGame.EntityFrameworkCore
{
    public class DemoGameDbContext : AbpZeroDbContext<Tenant, Role, User, DemoGameDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DemoGameDbContext(DbContextOptions<DemoGameDbContext> options)
            : base(options)
        {
        }
    }
}
