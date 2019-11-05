using Abp.Application.Services.Dto;

namespace ItSutra.DemoGame.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

