using System;
using System.Collections.Generic;

namespace Custom_API.Models
{
    public partial class Villains
    {
        public int VillainId { get; set; }
        public string Alias { get; set; }
        public string RealName { get; set; }
        public int? TeamId { get; set; }
        public int? HeroTeamId { get; set; }
        public int? HeroId { get; set; }

        public virtual Heroes Hero { get; set; }
        public virtual Teams HeroTeam { get; set; }
        public virtual Teams Team { get; set; }
    }
}
