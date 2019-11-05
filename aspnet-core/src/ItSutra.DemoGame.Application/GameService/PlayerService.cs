using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ItSutra.DemoGame.Game;
using ItSutra.DemoGame.GameService.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSutra.DemoGame.GameService
{
    public class PlayerService : DemoGameAppServiceBase, IPlayerService
    {
        private readonly IRepository<Player> _playerRepository;
        public PlayerService(IRepository<Player> playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public async Task CreatePlayer(CreatePlayerInput input)
        {
            var createPlayer = ObjectMapper.Map<Player>(input);
            await _playerRepository.InsertAsync(createPlayer);
        }

        public async Task DeletePlayer(EntityDto input)
        {
            await _playerRepository.DeleteAsync(input.Id);
        }

        public async Task<ListResultDto<PlayerListOutput>> GetPlayerAsync(GetPlayerInput input)
        {
            var playerLists = await _playerRepository
               .GetAll()
               .Where(
                    p => p.Id.ToString().Contains(input.Filter)
                )
                .ToListAsync();

            return new ListResultDto<PlayerListOutput>(ObjectMapper.Map<List<PlayerListOutput>>(playerLists));
        }

        public async Task GetPlayerById(EntityDto input)
        {
            await _playerRepository.GetAsync(input.Id);
        }

        public async Task UpdatePlayer(UpdatePlayerOutput input)
        {
            var updatePlayer = ObjectMapper.Map<Player>(input);
            await _playerRepository.UpdateAsync(updatePlayer);
        }
    }
}
