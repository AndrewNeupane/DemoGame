using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.DemoGame.MultiTenancy.Dto;

namespace ItSutra.DemoGame.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

