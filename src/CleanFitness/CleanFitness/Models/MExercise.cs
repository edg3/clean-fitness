using Android.Graphics;
using SQLite;

namespace CleanFitness.Models;

[Table("Exercises")]
public class MExercise : Model
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    // TODO: Need to see if this will work in the DB
    // TODO: Verify image size; thinking <= 2mb; will annoy people, but can be worked with I think
    public string Picture { get; set; } = null;
    public string RequiredEquipment { get; set; } = "";
}