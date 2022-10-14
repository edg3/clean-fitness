using SQLite;

namespace CleanFitness.Models;

/// <summary>
/// For anything besides the direct calories count;
/// e.g. Sugars (g), 
/// </summary>
public class MBaseCaloriesExtra
{
    [PrimaryKey, AutoIncrement, Column("Id")]
    public int Id { get; set; } = 0;
    public int BaseCaloriesId { get; set; } = 0;
    public string Name { get; set; } = "";
    public double Amount { get; set; } = 0;
}
