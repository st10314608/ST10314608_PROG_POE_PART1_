using System;
using System.Collections.Generic;

namespace ST10314608_PROG2A_POE_Part1.Model
{
    public class Recipe // Represents a Recipe containing a list of ingredients and instructions.
    {
        // Gets or sets the name of the recipe.
        public string Name { get; set; }
        public string Description { get; set; } // Gets or sets the description of the recipe
        public List<Ingredients> Ingredients { get; set; } // Gets or sets the list of ingredients of the recipe
        public List<string> Instructions { get; set; } // Gets or sets the instructions of the recipe

        public Recipe() // Initializes a new instance of the "Recipe" class
        {
            Ingredients = new List<Ingredients>();
            Instructions = new List<string>();
        }

        public Recipe(int numIngredients, int numInstructions) : this() // Initializes a new instance of the "Recipe" class with specified ingredient and instruction counts
        {
            // Already handled by default constructor
        }

        public Recipe(Recipe otherRecipe) // Copy constructor
        {
            if (otherRecipe == null)
            {
                throw new ArgumentNullException(nameof(otherRecipe), "Other recipe cannot be null");
            }
            Name = otherRecipe.Name;
            Description = otherRecipe.Description;
            Ingredients = new List<Ingredients>(otherRecipe.Ingredients);
            Instructions = new List<string>(otherRecipe.Instructions);
        }


        public int CalculateTotalCalories()
        {
            int totalCalories = 0;
            foreach (var ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }

            public void ResetQuantities() // Resets the quantities of all ingredients to their original values
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity = ingredient.OriginalQuantity;
            }
        }

        public override string ToString() // Returns a string representation of the recipe.
        {
            var ingredientStr = string.Join("\n- ", Ingredients);
            var instructionStr = string.Join("\n", Instructions);
            return $"Recipe: {Name}\n\nDescription:\n{Description}\n\nIngredients:\n{ingredientStr}\n\nInstructions:\n{instructionStr}";
        }

        public void Scale(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity = (Convert.ToDouble(ingredient.OriginalQuantity) * factor).ToString();
            }
        }

        
        }
    }
