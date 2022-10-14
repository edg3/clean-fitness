using SQLite;

namespace CleanFitness.Models;

/// <summary>
/// Base infrastructure for models
/// </summary>
public class Model
{
    [PrimaryKey, AutoIncrement, Column("Id")]
    public int Id { get; set; } = 0;
    public bool Deleted { get; set; } = false;
}
