using System;
using System.Collections.Generic;

namespace Custom_API.Models
{
    public partial class Villains
    {
        public Villains()
        {
            Heroes = new HashSet<Heroes>();
        }

        public int VillainId { get; set; }
        public string Alias { get; set; }
        public string RealName { get; set; }
        public string Team { get; set; }
        public int? HeroId { get; set; }

        public virtual Heroes Hero { get; set; }
        public virtual ICollection<Heroes> Heroes { get; set; }
    }
}
