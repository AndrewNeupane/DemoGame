using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSutra.DemoGame.Game
{
    public class Player: FullAuditedEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }
        public int Ties { get; set; }
        public int Score { get; set; }
    }
}
