using System;

namespace CleanFitness.Models;

/*
 Idea here: we can put in stats we feel like tracking (e.g. body wright, waist measurement) then add 'readings' to it
  - idea is to take ~60 days (near 2 months) in past and map out in html graph for the user to see in a web view
  - this way you can (possibly) set a notification reminder, think 'every Monday morning update tracked numbers'
 You should then be able to see changes over time, I think, in a nice way
 TODO: Consider exporting data historicaly, move out DB into email perhaps, and cleaning data so there's less
        - Kinda suggests also the exercise exports to external places can help with cleaning data; can be simple html reports in a folder on OneDrive, for instance, I figure
 */
public class MPersonalStatRecord : Model
{
    public int PersonalStatId { get; set; } = 0;
    public DateTime ReadingDate { get; set; } = DateTime.Now;
    public double Reading { get; set; } = 0;
}
