namespace CleanFitness.Models;

/*
 Idea here: You can specify what you're tracking over time for yourself
 Groups it so its easier to show on the screen in a nice html format with graphs for yourself
 */
public class MPersonalStat : Model
{
    public string Name { get; set; } = "";
    /// <summary>
    /// Can be 'Name', so string, 'Age', so int, 'Weight', so double
    ///  - didn't put calories in here as that is data polution - calories need their own tracking table for cleaner SQL interop
    /// </summary>
    public string Value { get; set; } = "";
}
