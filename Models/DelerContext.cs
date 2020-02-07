using Microsoft.EntityFrameworkCore;

namespace CarPartsAPI {

    public class DelerContext : DbContext {

        public DelerContext(DbContextOptions<DelerContext> options):base(options) {}

        public DbSet<CarPartsAPI.Models.Deler> Deler { get; set; }
    }
}