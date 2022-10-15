using CleanFitness.Models;
using System.Collections.Generic;

namespace CleanFitness.Actions;

public class DB
{
    public static DB I { get; private set; }
    public bool Connected { get; private set; }
    public DB()
    {
        if (null != I) throw new System.Exception("Can't create multiple DB systems yet."); /* TODO: import/export schemes */
        I = this;

        if (true /* file doesnt exist => go to FirstLaunch to input the starting data we save */)
        {
            Connected = false;
        }
        else /* file does exist => you're all sorted */
        {

        }
    }

    public void Insert<T>(T item)
    {
        if (!Connected) return;

        // TODO: clean implementations
    }

    public void Create(List<MBaseCalories> calories, string name, double height, double weight, int age)
    {

    }
}
