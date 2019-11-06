using Abp.Application.Services.Dto;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ItSutra.DemoGame.Game
{
    public interface IMatchManager : IDomainService
    {
        Task<Match> CreateMatch(Match Entity);
        Task<ListResultDto<Match>> GetMatchList(EntityDto input);
        Task<Player> GetPlayerInfo(EntityDto input);
    }
}
