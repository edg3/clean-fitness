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
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    // Moved to app storage
    public string Image { get; set; } = null;
    public string RequiredEquipment { get; set; } = "";

    [Ignore]
    public string ImageLoader
    {
        get
        {
            return Image; //ImageSource.FromFile(System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), Image));
        }
    }
}