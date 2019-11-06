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

        //(xxx)xxx-xxxx
        public string PhoneNumber { get; set; }

        // MM/DD/YYYY
        // Player must be over 18 yrs
        public string DateOfBirth { get; set; }

        public int Win { get; set; }
        public int Loss { get; set; }
        public int Ties { get; set; }
        public int Score { get; set; }
    }
}
