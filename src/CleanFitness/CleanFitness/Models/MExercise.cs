using SQLite;

namespace CleanFitness.Models;

[Table("Exercises")]
public class MExercise : Model
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    //public <hmm> Picture { get; set; } = null;
}
