using MixedAllProjects.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedAllProjects.DAL.Context
{
    public class MovieContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
