using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IRecipe recipe)
        {
            Header = recipe.Name;
            ShowHeaderPanel();

            Console.WriteLine();
            Console.WriteLine("Ingredienser");
            Console.WriteLine("============");

            foreach (IIngredient item in recipe.Ingredients)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Gör så här:");
            Console.WriteLine("===========");

            int itemNumber = 1;
            foreach (string item in recipe.Instructions)
            {
                Console.WriteLine("<{0}>", itemNumber);
                Console.WriteLine(item);
                itemNumber = itemNumber + 1;
            }
            
        }

        public void Show(IEnumerable<IRecipe> recipes)
        {
            foreach (IRecipe item in recipes)
            {
                Show(item);
                ContinueOnKeyPressed();
            }
        }
    }
}
