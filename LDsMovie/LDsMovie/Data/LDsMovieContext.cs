using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LDsMovie.Models
{
    public class LDsMovieContext : DbContext
    {
        public LDsMovieContext (DbContextOptions<LDsMovieContext> options)
            : base(options)
        {
        }

        public DbSet<LDsMovie.Models.Movie> Movie { get; set; }
    }
}
