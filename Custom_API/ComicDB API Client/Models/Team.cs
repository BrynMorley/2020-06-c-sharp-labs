using System;
using System.Collections.Generic;

namespace ComicDB_API_Client
{
    public partial class Team
    {
        public Team()
        {
            HeroesTeam = new HashSet<Hero>();
            HeroesVillainTeam = new HashSet<Hero>();
            VillainsHeroTeam = new HashSet<Villain>();
            VillainsTeam = new HashSet<Villain>();
        }

        public int TeamId { get; set; }
        public string TeamName { get; set; }

        public virtual ICollection<Hero> HeroesTeam { get; set; }
        public virtual ICollection<Hero> HeroesVillainTeam { get; set; }
        public virtual ICollection<Villain> VillainsHeroTeam { get; set; }
        public virtual ICollection<Villain> VillainsTeam { get; set; }
    }
}
