namespace CleanFitness.Models;

public class MRecipeIngredient : Model
{
    public int RecipeId { get; set; } = 0;
    public string Name { get; set; } = "";
    // e.g. 2 Tablespoons, 350g, 1 cup, etc
    public string Amount { get; set; } = "";
}
