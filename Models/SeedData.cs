using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VehicleApp.Data;
using System;
using System.Linq;

namespace VehicleApp.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new VehicleAppContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<VehicleAppContext>>()))
        {
            // Look for any movies.
            if (context.Vehicle.Any())
            {
                return;   // DB has been seeded
            }
            context.Vehicle.AddRange(
                new Vehicle
                {
                    Name = "TOYOTA",
                    buyDate = DateTime.Parse("2024-2-10"),
                    Model = "Auris",
                    Price = 600000.99M
                },
                new Vehicle
                {
                    Name = "MAZDA",
                    buyDate = DateTime.Parse("2024-1-23"),
                    Model = "BT50",
                    Price = 800000.79M
                },
                new Vehicle
                {
                    Name = "MERCEDES",
                    buyDate = DateTime.Parse("2024-3-14"),
                    Model = "G Wagon",
                    Price = 1000000.99M
                },
                new Vehicle
                {
                    Name = "TOYOTA",
                    buyDate = DateTime.Parse("2024-3-2"),
                    Model = "Prado",
                    Price = 1080000.99M
                }
            );
            context.SaveChanges();
        }
    }
}