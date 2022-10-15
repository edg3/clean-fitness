using System;

namespace CleanFitness.Models;

public class MBaseCalories_Tracking : Model
{
    public DateTime When { get; set; } = DateTime.Now;
    public string Information { get; set; } = "";
    public double CaloriesBurned { get; set; } = 0;
}
