using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        private IRecipeFormatter recipeFormatter;

        public ConsolePrinter(IRecipeFormatter recipeFormatter)
        {
            this.recipeFormatter = recipeFormatter;
        }

        public void PrintRecipe(Recipe recipe)
        {
            string formattedRecipe = recipeFormatter.FormatRecipe(recipe);
            Console.WriteLine(formattedRecipe);
        }
    }
}