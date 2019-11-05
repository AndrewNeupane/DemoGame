using System.Threading.Tasks;
using Abp.Application.Services;
using ItSutra.DemoGame.Authorization.Accounts.Dto;

namespace ItSutra.DemoGame.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
