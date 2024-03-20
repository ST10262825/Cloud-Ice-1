using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleApp.Models;

namespace VehicleApp.Data
{
    public class VehicleAppContext : DbContext
    {
        public VehicleAppContext (DbContextOptions<VehicleAppContext> options)
            : base(options)
        {
        }

        public DbSet<VehicleApp.Models.Vehicle> Vehicle { get; set; } = default!;
    }
}
