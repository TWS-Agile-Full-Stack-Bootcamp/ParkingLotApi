using System.Security.Policy;
using Microsoft.EntityFrameworkCore;

namespace ParkingLotApi.Repository
{
    public class ParkingLotContext : DbContext
    {
        public ParkingLotContext(DbContextOptions<ParkingLotContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<ParkingBoy> ParkingBoys { get; set; }
        public DbSet<SmartParkingBoy> SmartParkingBoys { get; set; }
    }
}