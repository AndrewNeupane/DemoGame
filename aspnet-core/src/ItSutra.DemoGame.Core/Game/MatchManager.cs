using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace ItSutra.DemoGame.Game
{
    public class MatchManager : DomainService, IMatchManager
    {
        private readonly IRepository<Match> _repositoryMatch;
        public MatchManager(IRepository<Match> repositoryMatch)
        {
            _repositoryMatch = repositoryMatch;
        }
        public async Task<Match> CreateMatch(Match Entity)
        {
            var createMatch = ObjectMapper.Map<Match>(Entity);
            return await _repositoryMatch.InsertAsync(createMatch);
        }

        public async Task<ListResultDto<Match>> GetMatchList(EntityDto input)
        {
            var matchLists = await _repositoryMatch
               .GetAllIncluding(m => m.gamePlayers)
               .FirstOrDefaultAsync(p => p.Id == input.Id); 

            return new ListResultDto<Match>(ObjectMapper.Map<List<Match>>(matchLists));
        }

        public Task<Player> GetPlayerInfo(EntityDto input)
        {
            throw new NotImplementedException();
        }
    }
}
