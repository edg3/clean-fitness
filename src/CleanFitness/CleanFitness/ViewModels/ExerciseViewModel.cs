using CleanFitness.Actions;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace CleanFitness.ViewModels;

public class ExerciseViewModel : IViewModel
{
    public event PropertyChangedEventHandler PropertyChanged;

    private Command _goBack;
    public Command GoBack => _goBack ??= new Command(() => { CF.Nav.GoTo(NavLocation.Home); });

    private Command _doSelectedExercise;
    public Command DoSelectedExercise => _doSelectedExercise ??= new Command(() => { CF.Popup("TODO","Do exercise; need to consider how this will go.","Ok"); });

    private Command _goNewExercise;
    public Command GoNewExercise => _goNewExercise ??= new Command(() => { CF.Popup("TODO","Add an Exercise to 'Today' in each week; i.e. to the 'Monday' group if today is 'Monday'. As in a fast way, you can see a trainer and have them tell you what you will put in 'just because you want to track it, kinda vibe'","Ok"); });

    private Command _goManageExercise;
    public Command GoManageExercise => _goManageExercise ??= new Command(() => { CF.Popup("TODO", "Manage exercises available; and which part of the week they will show up in; made me thing I should adjust 'MRoutine' since it can just be marked for the days it shows. Perhaps have a way to go here and go 'Do this Exercise' on 'Off' days? Thinking about it more.", "Ok"); });

    private Command _goExerciseLogs;
    public Command GoExerciseLogs => _goExerciseLogs ??= new Command(() => { CF.Popup("TODO", "Make a nice interactive way to check your exercise logs; HTML to open MRoutineTracking HTML content sort of vibes, can have things like you did X exercises in this month; I feel the month options will make this easiest.", "Ok"); });

    public void CleanData()
    {

    }

    public void LoadData()
    {

    }
}
