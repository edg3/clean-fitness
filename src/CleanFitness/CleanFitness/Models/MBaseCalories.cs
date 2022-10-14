using SQLite;

namespace CleanFitness.Models;

[Table("BaseCalories")]
public class MBaseCalories
{
    /* Not using Model as we wont 'delete' this data, ever */
    [PrimaryKey, AutoIncrement, Column("Id")]
    public int Id { get; set;} = 0;
    public string Name { get; set; } = "";
    public double CaloriesPer100g { get; set; } = 0;
}
