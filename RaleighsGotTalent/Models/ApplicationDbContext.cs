using Microsoft.EntityFrameworkCore;

namespace RaleighsGotTalent.Models
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Audition> Auditions { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Photo> Photos { get; set; }

    }
}
