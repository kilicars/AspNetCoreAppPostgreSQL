using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreAppPostgreSQL.Models
{
    public class TvShowsContext : DbContext
    {
        public TvShowsContext (DbContextOptions<TvShowsContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCoreAppPostgreSQL.Models.TvShow> TvShow { get; set; }
    }
}
