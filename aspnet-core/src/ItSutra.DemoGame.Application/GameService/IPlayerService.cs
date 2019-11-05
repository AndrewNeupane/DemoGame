using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ItSutra.DemoGame.GameService.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ItSutra.DemoGame.GameService
{
    public interface IPlayerService : IApplicationService
    {
        Task<ListResultDto<PlayerListOutput>> GetPlayerAsync(GetPlayerInput input);

        Task CreatePlayer(CreatePlayerInput input);

        Task DeletePlayer(EntityDto input);

        Task UpdatePlayer(UpdatePlayerOutput input);
        Task GetPlayerById(EntityDto input);
    }
}
