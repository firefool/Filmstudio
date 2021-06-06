using Filmstudio.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmstudioAPI
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<RentedMovie> RentedMovies { get; set; }

        /*
        protected AppDbContext(DbContextOptions options) : base(options) { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : this((DbContextOptions)options)
        {

        }*/
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
    }
}
