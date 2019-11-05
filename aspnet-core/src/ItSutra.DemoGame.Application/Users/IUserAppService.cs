using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.DemoGame.Roles.Dto;
using ItSutra.DemoGame.Users.Dto;

namespace ItSutra.DemoGame.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
