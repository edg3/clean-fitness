using System;

namespace CleanFitness.Actions;

public enum NotificationChannel
{
    N1 = 2001, 
    N2 = 2002, 
    N3 = 2003 

}
public abstract class INotify
{
    public abstract void Add(DateTime when, string msg, NotificationChannel chan);
}
