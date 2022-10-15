namespace CleanFitness.Models;

public class MRecipe_LeftOvers
{
    /* says recipe; portions left - i.e. 3 single person servings; calorie intake tracking can reuse the amount
       not '100%' accurate, but it's meant to make sure you can watch your food intakes */
    /* when we make and eat a meal we state 'made 5 servings', '1 eaten by me' => add to calories count, '3 left' which adds this in left-overs
       it doesnt worry too much since we can delete it when we throw the left overs away */
    public string Name { get; set; } = "";
    public int Portions { get; set; } = 0;
    public double CaloriesPerPortion { get; set; } = 0;
}
