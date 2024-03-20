using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using VehicleApp.Models;

namespace VehicleApp.Models;

public class VehicleModelViewModel
{
    public List<Vehicle>? Vehicles { get; set; }
    public SelectList? Models { get; set; }
    public string? VehicleModel { get; set; }
    public string? SearchString { get; set; }
}