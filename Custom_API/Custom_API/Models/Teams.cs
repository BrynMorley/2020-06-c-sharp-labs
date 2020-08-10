using System;
using System.Collections.Generic;

namespace Custom_API.Models
{
    public partial class Teams
    {
        public Teams()
        {
            HeroesTeam = new HashSet<Heroes>();
            HeroesVillainTeam = new HashSet<Heroes>();
            VillainsHeroTeam = new HashSet<Villains>();
            VillainsTeam = new HashSet<Villains>();
        }

        public int TeamId { get; set; }
        public string TeamName { get; set; }

        public virtual ICollection<Heroes> HeroesTeam { get; set; }
        public virtual ICollection<Heroes> HeroesVillainTeam { get; set; }
        public virtual ICollection<Villains> VillainsHeroTeam { get; set; }
        public virtual ICollection<Villains> VillainsTeam { get; set; }
    }
}
