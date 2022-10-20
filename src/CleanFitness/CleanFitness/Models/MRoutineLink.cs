using SQLite;
using SQLiteNetExtensions.Attributes;

namespace CleanFitness.Models;

[Table("RoutineLinks")]
public class MRoutineLink : Model
{
    /* hmm... find ManyToMany foreign key for sqlite-net-pcl */
    public int ExerciseId { get; set; } = 0;
    public int RoutineId { get; set; } = 0;
    public int OrderNumber { get; set; } = 0;
    /* Amount e.g. '12 reps', or '60 seconds'; you can always be lazy and just write '12' since it's 'pushups' and you know its reps*/
    public string Amount { get; set; } = "";
    public bool Timed { get; set; } = false;
    /* Other */
    public string Special { get; set; } = "";
    public RoutineRestAfter RestAfter { get; set; } = RoutineRestAfter.Yes;

}

public enum RoutineRestAfter
{
    Yes,
    No
}
