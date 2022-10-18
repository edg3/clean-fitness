using CleanFitness.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using Xamarin.Essentials;
using Xamarin.Forms.Internals;
using static SQLite.SQLite3;

namespace CleanFitness.Actions;

public class DB
{
    private SQLiteConnection _connection = null;
    private string _dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "clean-fitness.db3");

    public static DB I { get; private set; }
    public bool Connected { get; private set; }
    public DB()
    {
        if (null != I) throw new System.Exception("Can't create multiple DB systems yet."); /* TODO: import/export schemes */
        I = this;

        if (!File.Exists(_dbPath) /* file doesnt exist => go to FirstLaunch to input the starting data we save */)
        {
            Connected = false;
        }
        else /* file does exist => you're all sorted */
        {
            _connection = new SQLiteConnection(_dbPath);
            Connected = true;
        }
        // DBInit(); /* does this have to be called here on auto connect anyway? */
    }

    public void Insert<T>(T item)
    {
        if (!Connected) return;

        _connection.Insert(item);
    }

    public void Update<T>(T item)
    {
        if (!Connected) return;

        _connection.Update(item);
    }

    public ObservableCollection<T> Get<T>(Expression<Func<T, bool>> condition)
    {
        var answer = new ObservableCollection<T>();

        if (!Connected) return answer;

        switch (typeof(T).ToString().Split('.').Last())
        {
            case "MBaseCalories":
                var _condition0 = condition as Expression<Func<MBaseCalories, bool>>;
                _connection.Table<MBaseCalories>()
                    .Where(_condition0)
                    .ForEach(i => answer.Add((T)Convert.ChangeType(i, typeof(T))));
                break;
            case "MBaseCalories_Tracking":
                var _condition1 = condition as Expression<Func<MBaseCalories_Tracking, bool>>;
                _connection.Table<MBaseCalories_Tracking>()
                    .Where(_condition1)
                    .ForEach(i => answer.Add((T)Convert.ChangeType(i, typeof(T))));
                break;
            case "MExercise":
                var _condition2 = condition as Expression<Func<MExercise, bool>>;
                _connection.Table<MExercise>()
                    .Where(_condition2)
                    .ForEach(i => answer.Add((T)Convert.ChangeType(i, typeof(T))));
                break;
            case "MPersonalStat":
                var _condition3 = condition as Expression<Func<MPersonalStat, bool>>;
                _connection.Table<MPersonalStat>()
                    .Where(_condition3)
                    .ForEach(i => answer.Add((T)Convert.ChangeType(i, typeof(T))));
                break;
            case "MPersonalStatRecord":
                var _condition4 = condition as Expression<Func<MPersonalStatRecord, bool>>;
                _connection.Table<MPersonalStatRecord>()
                    .Where(_condition4)
                    .ForEach(i => answer.Add((T)Convert.ChangeType(i, typeof(T))));
                break;
            case "MRecipe":
                var _condition5 = condition as Expression<Func<MRecipe, bool>>;
                _connection.Table<MRecipe>()
                    .Where(_condition5)
                    .ForEach(i => answer.Add((T)Convert.ChangeType(i, typeof(T))));
                break;
            case "MRecipe_LeftOvers":
                var _condition6 = condition as Expression<Func<MRecipe_LeftOvers, bool>>;
                _connection.Table<MRecipe_LeftOvers>()
                    .Where(_condition6)
                    .ForEach(i => answer.Add((T)Convert.ChangeType(i, typeof(T))));
                break;
            case "MRecipeIngredient":
                var _condition7 = condition as Expression<Func<MRecipeIngredient, bool>>;
                _connection.Table<MRecipeIngredient>()
                    .Where(_condition7)
                    .ForEach(i => answer.Add((T)Convert.ChangeType(i, typeof(T))));
                break;
            case "MRecipeStep":
                var _condition8 = condition as Expression<Func<MRecipeStep, bool>>;
                _connection.Table<MRecipeStep>()
                    .Where(_condition8)
                    .ForEach(i => answer.Add((T)Convert.ChangeType(i, typeof(T))));
                break;
            case "MRoutine":
                var _condition9 = condition as Expression<Func<MRoutine, bool>>;
                _connection.Table<MRoutine>()
                    .Where(_condition9)
                    .ForEach(i => answer.Add((T)Convert.ChangeType(i, typeof(T))));
                break;
            case "MRoutineLink":
                var _condition10 = condition as Expression<Func<MRoutineLink, bool>>;
                _connection.Table<MRoutineLink>()
                    .Where(_condition10)
                    .ForEach(i => answer.Add((T)Convert.ChangeType(i, typeof(T))));
                break;
            case "MRoutineTracking":
                var _condition11 = condition as Expression<Func<MRoutineTracking, bool>>;
                _connection.Table<MRoutineTracking>()
                    .Where(_condition11)
                    .ForEach(i => answer.Add((T)Convert.ChangeType(i, typeof(T))));
                break;
        }

        return answer;
    }

    public void Create(List<MBaseCalories> calories, string name, double height, double weight, int age)
    {
        _connection = new SQLiteConnection(_dbPath);
        Connected = true;
        DBInit();

        // Get base stats in
        Insert(new MPersonalStat()
        {
            Name = "Name",
            Value = name,
        });
        var h = new MPersonalStat()
        {
            Name = "Height",
            Value = "~", // implies all stats that use records, TODO: prevent input of ~
        };
        Insert(h);
        Insert(new MPersonalStatRecord()
        {
            PersonalStatId = h.Id,
            Reading = height,
            ReadingDate = DateTime.Now
        });
        var w = new MPersonalStat()
        {
            Name = "Weight",
            Value = "~",
        };
        Insert(w);
        Insert(new MPersonalStatRecord()
        {
            PersonalStatId = w.Id,
            Reading = weight,
            ReadingDate = DateTime.Now
        });
        Insert(new MPersonalStat()
        {
            Name = "Age",
            Value = age.ToString()
        });

        // Get base exercises and routines in


        // Get base recipes in
        // TODO: consider when I've got recipes in for testing

        // Insert all calories
        calories.ForEach((a) => { Insert(a); });
    }

    private void DBInit()
    {
        _connection.CreateTable<MBaseCalories>();
        _connection.CreateTable<MBaseCalories_Tracking>();
        _connection.CreateTable<MExercise>();
        _connection.CreateTable<MPersonalStat>();
        _connection.CreateTable<MPersonalStatRecord>();
        _connection.CreateTable<MRecipe>();
        _connection.CreateTable<MRecipe_LeftOvers>();
        _connection.CreateTable<MRecipeIngredient>();
        _connection.CreateTable<MRecipeStep>();
        _connection.CreateTable<MRoutine>();
        _connection.CreateTable<MRoutineLink>();
        _connection.CreateTable<MRoutineTracking>();
    }

    public async void ExportDB()
    {
        // TODO: save to local storage?
        await Xamarin.Essentials.Share.RequestAsync(new ShareFileRequest
        {
            Title = "Save DB",
            File = new ShareFile(_dbPath)
        });
    }

    public async void ImportDB()
    {
        var task = await FilePicker.PickAsync();
        if (task.FullPath.Length > 0)
        {
            using (var reader = new StreamReader(File.OpenRead(task.FullPath)))
            {
                using (var writer = new StreamWriter(File.OpenWrite(_dbPath)))
                {
                    // Moght be daft and bad
                    writer.Write(reader.ReadToEnd());
                }
            }
        }
    }
}
