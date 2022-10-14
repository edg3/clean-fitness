using SQLite;

namespace CleanFitness.Models;

[Table("Routines")]
public class MRoutine : Model
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
}
