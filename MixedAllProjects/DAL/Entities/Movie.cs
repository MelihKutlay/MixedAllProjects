using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedAllProjects.DAL.Entities
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public string MovieCategory { get; set; }
        public int MovieDuration { get; set; }
        public string MovieDescription { get; set; }
        public DateTime MovieCreateDateTime { get; set; }
    }
}
