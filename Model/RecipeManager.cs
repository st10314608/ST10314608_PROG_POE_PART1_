using System;
using System.Collections.Generic;
using MiNET;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using ST10314608_PROG2A_POE_Part1.Model;


public delegate void RecipeCaloriesNotificationDelegate(string recipeName);

public class RecipeManager //Constructor
{
   
    private  List<Recipe> recipes;
    public  event RecipeCaloriesNotificationDelegate RecipeCaloriesExceededEvent;

    
    public RecipeManager() // Collects all the recipe data from what the user has entered
    {
        recipes = new List<Recipe>(); // Initialize the list of recipes
    }

    public void AddRecipe(Recipe recipe) // Adds a recipe to the application
    {
        recipes.Add(recipe); // Add the recipe to the list
    }

    public Recipe CollectRecipeData() // Collects recipe data
    {
        Recipe recipe = new Recipe();

        Console.WriteLine("Enter the name of the recipe:"); // Prompts user to enter the name of the recipe
        recipe.Name = Console.ReadLine();

        Console.WriteLine("Enter the description of the recipe:"); // Prompts user to add a recipe description
        recipe.Description = Console.ReadLine();

        Console.WriteLine("Enter the number of ingredients:"); // Prompts user to add the number of ingredients
        int numIngredients = int.Parse(Console.ReadLine());

        for (int i = 0; i < numIngredients; i++) // Loop through each ingredient and collect its details
        {
            Console.WriteLine($"Enter the name of ingredient {i + 1}:");
            string ingredientName = Console.ReadLine();


            Console.WriteLine($"Enter the quantity for ingredient {i + 1}:");
            string quantity = Console.ReadLine();


            Console.WriteLine($"Enter the unit of measurement for ingredient {i + 1}:");
            string unit = Console.ReadLine();

            Console.WriteLine($"Enter the number of calories for ingredient {i + 1}:");
            int calories = int.Parse(Console.ReadLine()); 

            Console.WriteLine($"Enter food group for ingredient {i + 1}:");
            string foodGroup = Console.ReadLine();

            recipe.Ingredients.Add(new Ingredients // Create a new Ingredient object and add it to the recipe
            {
                Name = ingredientName,
                Quantity = quantity,
                OriginalQuantity = quantity,
                Unit = unit,
                Calories = calories,
                FoodGroup = foodGroup
            });
        }

        Console.WriteLine("Enter the number of steps:"); // Prompts user to add the number of steps in their recipe
        int numSteps = int.Parse(Console.ReadLine());

        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine($"Enter description for step {i + 1}:"); // Collect steps/instructions for the recipe
            string stepDescription = Console.ReadLine();
            recipe.Instructions.Add(stepDescription);
        }

        if (recipe.CalculateTotalCalories() > 300)


        //Checks if the calories exceed 300
        {
            RecipeCaloriesExceededEvent?.Invoke($"Warning! The total calories of the recipe '{recipe.Name}' exceed 300!");

        }

        return recipe; // Returns the created recipe
    }

    
    

    public void DisplayAllRecipes() // Displays all the recipes from the user
    {
        if (recipes.Count == 0)
        {
            Console.WriteLine("No recipes found."); // Warning message
            return;
        }
        recipes.Sort((x, y) => string.Compare(x.Name, y.Name));
        Console.WriteLine("All recipes:"); // Shows all recipes
        for (int i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {recipes[i].Name} - Total Calories: {recipes[i].CalculateTotalCalories()}");
        }

        Console.Write("Enter the index of the recipe you want to display: ");
        if (int.TryParse(Console.ReadLine(), out int recipeIndex) && recipeIndex >= 1 && recipeIndex <= recipes.Count)
        {
            Console.WriteLine(recipes[recipeIndex - 1]);
        }
        else
        {
            Console.WriteLine("Invalid Recipe"); // Warning alerting the user that they have entered an invalid recipe
        }

    }
}

//End of the application
