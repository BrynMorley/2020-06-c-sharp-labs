using System;
using System.Collections.Generic;

namespace ComicDB_API_Client
{
    public partial class Villain
    {
        public int VillainId { get; set; }
        public string Alias { get; set; }
        public string RealName { get; set; }
        public int? TeamId { get; set; }
        public int? HeroTeamId { get; set; }
        public int? HeroId { get; set; }

        public virtual Hero Hero { get; set; }
        public virtual Team HeroTeam { get; set; }
        public virtual Team Team { get; set; }
    }
}
