using System;

namespace CleanFitness.Actions;

public enum NotificationChannel
{
    N1 = 2001, // Tomorrow Morning - exercise or at least stretch
    N2 = 2002, // In 4 days of not exercising it reminds you you're meant to

}
public abstract class INotify
{
    public abstract void Add(DateTime when, string msg, NotificationChannel chan);
}
