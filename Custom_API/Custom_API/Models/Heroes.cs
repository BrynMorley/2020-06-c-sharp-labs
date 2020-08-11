using System;
using System.Collections.Generic;

namespace Custom_API.Models
{
    public partial class Heroes
    {
        public Heroes()
        {
            Villains = new HashSet<Villains>();
        }

        public int HeroId { get; set; }
        public string Alias { get; set; }
        public string RealName { get; set; }
        public int? TeamId { get; set; }
        public int? VillainTeamId { get; set; }

        public virtual Teams Team { get; set; }
        public virtual Teams VillainTeam { get; set; }
        public virtual ICollection<Villains> Villains { get; set; }
    }
}
