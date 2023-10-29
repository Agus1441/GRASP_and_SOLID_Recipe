using Full_GRASP_And_SOLID;

public class RecipeTextFormatter : IRecipeFormatter
{
    public string FormatRecipe(Recipe recipe)
    {
        return recipe.GetTextToPrint();
    }
}