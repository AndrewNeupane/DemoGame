using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ItSutra.DemoGame.Game
{
    public class Match : FullAuditedEntity
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public MatchState State { get; set; }
        public int FirstPlayerId { get; set; }

        public int SecondPlayerId { get; set; }
        public int WinningPlayerId { get; set; }
        public virtual Player FirstPlayer { get; set; }
        public virtual Player SecondPlayer { get; set; }
        public GamePiece FirstPlayerGamePiece { get; set; }

        [ForeignKey(nameof(WinningPlayerId))]
        public virtual Player WinningPlayer { get; set; }

        public virtual ICollection<MatchMove> MatchMoves { get; set; }

        public Match()
        {
            if (State == 0)
            {
                StartTime = DateTime.Now;
            }
            else
            {
                EndTime = DateTime.Now;
            }

            Difference = (EndTime - StartTime);
        }
    }

    public enum GamePiece
    {
        Circle,
        Square
    }
    public enum MatchState : byte
    {
        Open = 0,
        Completed = 1
    }
}

