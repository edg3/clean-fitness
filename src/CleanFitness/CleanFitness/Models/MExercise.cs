using Android.Graphics;
using Java.IO;
using Java.Interop;
using SQLite;
using System.IO;
using Xamarin.Forms;

namespace CleanFitness.Models;

[Table("Exercises")]
public class MExercise : Model
{
    [Unique]
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Image { get; set; } = null;
    public string RequiredEquipment { get; set; } = "";
}