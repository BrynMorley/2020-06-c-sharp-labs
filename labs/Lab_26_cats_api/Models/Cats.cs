using System;
using System.Collections.Generic;

namespace Lab_26_cats_api.Models
{
    public partial class Cats
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public int? Age { get; set; }
        public string Description { get; set; }
    }
}
