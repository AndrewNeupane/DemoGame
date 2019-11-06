using Abp.Domain.Entities;

namespace ItSutra.DemoGame.Game
{
    public class MatchMove : Entity
    {
        public int MatchId { get; set; }
        public int Location { get; set; }
        public int PlayerId { get; set; }
    }
}