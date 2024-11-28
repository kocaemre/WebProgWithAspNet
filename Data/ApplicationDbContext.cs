using Microsoft.EntityFrameworkCore;
using WebProgWithAspNet.Models;

namespace WebProgWithAspNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Veritabanı tablolarını temsil eden DbSet'ler
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Admin> Admin { get; set; }
    }
}
