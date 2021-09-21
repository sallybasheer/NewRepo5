using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data
{
    public class AutomobileDbContext:DbContext
    {
        public AutomobileDbContext(DbContextOptions<AutomobileDbContext>options):base(options)
        {
           

        }
        public DbSet<Color> Color { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Engine> Engine { get; set; }
        public DbSet<Fuel> Fuel { get; set; }
        public DbSet<Gear> Gear { get; set; }
        public DbSet<Motorcycle> Motorcycle { get; set; }
        public DbSet<sqlite_sequence> sqlite_sequence { get; set; }
        public DbSet<Truck> Truck { get; set; }

    }
}
