//Faeeza Reynolds
//ST10314608
//GR2
//REFERENCES: https://youtu.be/7rgn-zbRNQM?si=gLQWqTXAw1oWoHPG
//https://youtu.be/UDfRWI4suOg?si=ilJaEHJGKREZ2I2J
// https://learn.microsoft.com/en-us/dotnet/api/system.graphics?view=windowsdesktop
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ST10314608_PROG2A_POE_Part1.Ingredient
{
    internal class Ingredient
    {
        //Declaring variables
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }
    class Step
        //start of application
    {
        public string Description { get; set; }
    }
    class Recipe
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
        }
    }

    class Program
    {
        static Recipe recipe;

        static void Main(string[] args)
        {
            recipe = new Recipe();

            while (true)
            {
                //Option list for user/s to select from
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Enter Recipe Details");
                Console.WriteLine("2. Display Recipe");
                Console.WriteLine("3. Scale Recipe");
                Console.WriteLine("4. Reset Quantities");
                Console.WriteLine("5. Clear all Data");
                Console.WriteLine("6. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        EnterRecipeDetails();
                        break;
                    case 2:
                        DisplayRecipe();
                        break;
                    case 3:
                        ScaleRecipe();
                        break;
                    case 4:
                        ResetQuantities();
                        break;
                    case 5:
                        ClearAllData();
                        break;
                    case 6:
                        EnvironmentExit();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. PLease enter a number from 1 to 6."); //When the user enters an incorrect option, an error message will appear.
                        break;
                }
            }
        }

        private static void EnvironmentExit()
        {
            throw new NotImplementedException();
        }

        private static void ClearAllData()
        {
            throw new NotImplementedException();
        }

        private static void ResetQuantities()
        {
            throw new NotImplementedException();
        }

        private static void ScaleRecipe()
        {
            throw new NotImplementedException();
        }

        private static void DisplayRecipe()
        {
            throw new NotImplementedException();
        }

        static void EnterRecipeDetails()
        {
            recipe = new Recipe();

            Console.WriteLine("Please enter the number of ingredients :");
            int numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Please enter the name of the ingredient #{i + 1}:"); //Asks you to enter the name of the ingredient
                string name = Console.ReadLine();
                Console.WriteLine($"Please enter the quantity of the {name}:"); //Asks you to enter the name of the ingredient
                double quantity = double.Parse(Console.ReadLine());
                Console.WriteLine($"Enter the unit of measurement for {name}:"); //Asks you what unit of measurement you will be using for each ingredient
                string unit = Console.ReadLine();

                recipe.Ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit }); 
            }
            Console.WriteLine("Enter the number of steps:"); //Asks the user to enter the number of steps they will be using
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Recipe details entered successfully!");
            }
            static void DisplayRecipe()  //This will display the recipe the user decides to enter
            {
                if (recipe == null || recipe.Ingredients.Count == 0 || recipe.Steps.Count == 0)
                {
                    Console.WriteLine("Please enter recipe details first.");
                    return;
                }
                // Declaring and displaying option list
                Console.WriteLine("\nRecipe Details:");
                Console.WriteLine("Ingredients:");
                foreach (Ingredient ingredient in recipe.Ingredients)
                {
                    Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
                }
                Console.WriteLine("\nSteps:");
                foreach (Step step in recipe.Steps) //This will display the steps breakdown
                {
                    Console.WriteLine(step.Description);
                }

            }
            static void ScaleRecipe() //Scaling of the recipe factors(includiing measurements)
            {
                if (recipe == null || recipe.Ingredients.Count == 0)
                {
                    Console.WriteLine("PLease enter recipe details first.");
                    return;
                }
                Console.WriteLine("Enter the scaling factor (0.5 for half, 2 for double, 3 for triple):");
                double factor = double.Parse(Console.ReadLine()); //This is where the user enters the scaling factor of the unit of measrement

                foreach (Ingredient ingredient in recipe.Ingredients)
                {
                    ingredient.Quantity *= factor;

                }
                Console.WriteLine("Recipe scale dsuccessfully!");
            }
            static void ResetQuantities()
            {
                if (recipe == null || recipe.Ingredients.Count == 0)
                {
                    Console.WriteLine("PLease enter recipe details first.");
                    return;
                }
                EnterRecipeDetails(); //User is required to enter the recipe details

            }

            static void ClearAllData() //Tells the user that if slected, all the data that was entered will be cleared
            {
                recipe = null;
                Console.WriteLine("All data cleared successfully!"); //Lets the user know that the data has been cleared successfully.
                //End of the Application
            }
        }
    }
}
