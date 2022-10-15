namespace CleanFitness.Models;

public class MRecipe : Model
{
    public string Name { get; set; } = "";
    public string Details { get; set; } = "";
    public int Servings { get; set; } = 0;
    public double TotalCalories { get; set; } = 0;
}
