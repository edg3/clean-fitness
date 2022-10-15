namespace CleanFitness.Models;

public class MRecipeStep : Model
{
    public int RecipeId { get; set; } = 0;
    public int Order { get; set; } = 0;
    public string Action { get; set; } = "";
}
