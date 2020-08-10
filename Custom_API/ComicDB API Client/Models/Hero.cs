using System;
using System.Collections.Generic;

namespace ComicDB_API_Client
{
    public partial class Hero
    {
        public Hero()
        {
            Villains = new HashSet<Villain>();
        }

        public int HeroId { get; set; }
        public string Alias { get; set; }
        public string RealName { get; set; }
        public int? TeamId { get; set; }
        public int? VillainTeamId { get; set; }

        public virtual Team Team { get; set; }
        public virtual Team VillainTeam { get; set; }
        public virtual ICollection<Villain> Villains { get; set; }
    }
}
