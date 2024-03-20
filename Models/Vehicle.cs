using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace VehicleApp.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string? Name { get; set; }

    [Display(Name = "Buy Date")]
    [DataType(DataType.Date)]

    public DateTime buyDate { get; set; }
    public string? Model { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}