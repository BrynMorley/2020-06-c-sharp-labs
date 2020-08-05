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
        public string Team { get; set; }
        public int? VillainId { get; set; }

        public virtual Villains Villain { get; set; }
        public virtual ICollection<Villains> Villains { get; set; }
    }
}
