using CleanFitness.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;

namespace CleanFitness.Actions;

public class DB
{
    private SQLiteConnection _connection = null;
    private string _dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3");

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
}
