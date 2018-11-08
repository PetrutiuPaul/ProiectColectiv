using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProiectColectiv.Models;

namespace ProiectColectiv.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Job>().HasData(new Job()
            {
                Id = 1,
                Title = "Astronaut",
                Description = "Se doreste un astronaut part-time.Program flexibil si cina inclusa(cereale dezhidratate)",
                AvailableUntil = new DateTime(2020, 12, 2),
                PostedOn = DateTime.Now
            },
            new Job()
            {
                Id = 2,
                Title = "Pitic",
                Description = "Se doreste un pitic pentru eschibitii pe Piezisa. Program flexibil si bere inclusa(de la Infinity)",
                AvailableUntil = new DateTime(2020, 12, 2),
                PostedOn = DateTime.Now
            },
            new Job()
            {
                Id = 3,
                Title = "Crescatpr de unicorni",
                Description = "Program flexibil si masa inclusa(skittles)",
                AvailableUntil = new DateTime(2020, 12, 2),
                PostedOn = DateTime.Now
            }
            );
        }

        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobAbility> JobAbilities { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<UserAbility> UserAbilities { get; set; }
    }
}
