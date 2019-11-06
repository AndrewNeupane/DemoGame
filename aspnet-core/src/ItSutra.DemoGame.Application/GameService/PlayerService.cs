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
        public async Task CreatePlayer(PlayerInput input)
        {

            // return validation errors to the user
            var createPlayer = ObjectMapper.Map<Player>(input);
            await _playerRepository.InsertAsync(createPlayer);
        }

        public async Task DeletePlayer(int id)
        {
            await _playerRepository.DeleteAsync(id);
        }

        public async Task<ListResultDto<PlayerListItem>> GetPlayerAsync(GetPlayerInput input)
        {
            var playerLists = await _playerRepository
               .GetAll()
               .Where(
                    p => p.Id.ToString().Contains(input.Filter)
                )
                .ToListAsync();

            return new ListResultDto<PlayerListItem>(ObjectMapper.Map<List<PlayerListItem>>(playerLists));
        }

        public async Task GetPlayerById(int id)
        {
            await _playerRepository.GetAsync(id);
        }

        public async Task UpdatePlayer(PlayerInput input)
        {
            // return validation errors to the user
            var updatePlayer = ObjectMapper.Map<Player>(input);
            await _playerRepository.UpdateAsync(updatePlayer);
        }
    }
}
