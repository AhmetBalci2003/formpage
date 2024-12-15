using Microsoft.EntityFrameworkCore;

namespace formpage.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Otobus> Otobus { get; set; }
        public DbSet<Oteller> Oteller { get; set; }
        public DbSet<Otobus_rezervasyon> Otobus_rezervasyon {get; set;}
        public DbSet<Seferler> Seferler { get; set; }
        public DbSet<Otel_Rezervasyonlar> Otel_Rezervasyonlar { get; set; }



    }

}
