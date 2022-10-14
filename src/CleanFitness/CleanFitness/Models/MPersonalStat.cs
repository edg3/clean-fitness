namespace CleanFitness.Models;

/*
 Idea here: You can specify what you're tracking over time for yourself
 Groups it so its easier to show on the screen in a nice html format with graphs for yourself
 */
public class MPersonalStat : Model
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
}
