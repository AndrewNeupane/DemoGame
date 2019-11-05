using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSutra.DemoGame.Game
{
    public class Match : FullAuditedEntity
    {
        public bool Player1Status { get; set; }
        public bool Player2Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Difference { get; set; }
        public TaskState State { get; set; }
        public virtual ICollection<Player> gamePlayers { get; set; }

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

    public enum TaskState : byte
    {
        Open = 0,
        Completed = 1
    }
}

