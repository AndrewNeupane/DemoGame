using System.Threading.Tasks;
using Abp.Application.Services;
using ItSutra.DemoGame.Sessions.Dto;

namespace ItSutra.DemoGame.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
