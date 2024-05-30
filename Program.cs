//Faeeza Reynolds
//ST10314608
//GR2
//REFERENCES: https://youtu.be/7rgn-zbRNQM?si=gLQWqTXAw1oWoHPG
//https://youtu.be/UDfRWI4suOg?si=ilJaEHJGKREZ2I2J
//https://learn.microsoft.com/en-us/dotnet/api/system.graphics?view=windowsdesktop
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ST10314608_PROG2A_POE_Part1.Model;
using static ST10314608_PROG2A_POE_Part1.Model.Recipe;

namespace ST10314608_PROG2A_POE_Part1
{
   
     class Program // The main program class that contains the entry points of the application.
    {
        static void Main(string[] args) // The command line arguments
        {
            RecipeManager recipeManager = new RecipeManager();

            while (true)
            {
                Recipe recipe = recipeManager.CollectRecipeData(); // Collects data for a new recipe

                Console.WriteLine("\nRecipe details:"); // Displays the details of the recipe
                Console.WriteLine(recipe);

                while (true) // Provides options for scaling, resetting, or clearing all the recipe data
                {
                    Console.WriteLine("\nOptions:");
                    Console.WriteLine("1. Scale Recipe");
                    Console.WriteLine("2. Reset quantities to original values");
                    Console.WriteLine("3. Clear data and enter a new recipe");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice: ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine("Enter a scaling factor (0.5, 2, or 3):"); // Scaling the recipe
                        if (double.TryParse(Console.ReadLine(), out double scale) && (scale == 0.5 || scale == 2 || scale == 3))
                        {
                            recipe.Scale(scale);
                            Console.WriteLine("\nScaled Recipe Details:");
                            Console.WriteLine(recipe);
                        }
                        else
                        {
                            Console.WriteLine("Invalid scaling factor.");
                        }
                    }
                    else if (choice == "2")
                    {
                        recipe.ResetQuantities(); // Resetting the quantities to original values
                        Console.WriteLine("\nRecipe details reset to original values:");
                        Console.WriteLine(recipe);
                    }
                    else if (choice == "3")
                    {
                        break; // Breaking out of the loop to re-collect data for a new recipe
                    }
                    else if (choice == "4")
                    {
                        return; // Exiting the application
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again!");
                    }
                }
            }
        }
    }
}
    




