using System;

namespace CleanFitness.Models;

public class MRoutineTracking : Model
{
    public DateTime WhenStarted { get; set; } = DateTime.Now;
    public DateTime? WhenCompleted { get; set; } = null;
    public string RoutineName { get; set; } = "";
    public string RoutineDescription { get; set; } = "";
    /* Document considered a nice looking content for a <section> in html with styling
     * - As you finish steps it adds a row with the data
     * - If you write a note as you finish the step it can log it as well, e.g. type '24' hit 'kg' button and it adds the text in the field, and then can tap 'done' and its added to the document
     * - this way you can quickly add info when needed, like weights, or if you feel bad about something, such as 'pain in shoulder', can track it, then 'abort' exercise and you have a good log
     * TODO: experiment with 'https://www.nuget.org/packages/NReco.ImageGenerator/' or similar
     */
    public string Document { get; set; } = "";
}
