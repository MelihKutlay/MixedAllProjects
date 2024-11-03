using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstProject1.DAL.Entity
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public int MovieDuration { get; set; }
        public string MovieDescription { get; set; }
        public DateTime MovieCreateDateTime { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

    }
}
