using SQLite;

namespace CleanFitness.Models;

[Table("Routines")]
public class MRoutine : Model
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public bool Day_Sunday { get; set; } = false;
    public bool Day_Monday { get; set; } = false;
    public bool Day_Tuesday { get; set; } = false;
    public bool Day_Wednesday { get; set; } = false;
    public bool Day_Thursday { get; set; } = false;
    public bool Day_Friday { get; set; } = false;
    public bool Day_Saturday { get; set; } = false;
    // e.g. Stretch on a day without any set to it
    public bool Day_Empty { get; set; } = false;
}
