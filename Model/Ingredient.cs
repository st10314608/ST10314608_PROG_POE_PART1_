//Faeeza Reynolds
//ST10314608
//GR2
//REFERENCES: https://youtu.be/7rgn-zbRNQM?si=gLQWqTXAw1oWoHPG
//https://youtu.be/UDfRWI4suOg?si=ilJaEHJGKREZ2I2J
// https://learn.microsoft.com/en-us/dotnet/api/system.graphics?view=windowsdesktop

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10314608_PROG2A_POE_Part1.Model
{
    public class Ingredients //Represents an ingredient in a recipe
    {
        public string Name { get; set; } // Gets or sets the name of the ingredient
        public string Quantity { get; set; } // Gets or sets the quantity of the ingredient
        public string OriginalQuantity { get; set; } // Gets or sets the original quantity of the ingredient
        public string Unit { get; set; } // Gets or sets the unit of measurement for the ingredient
        public int Calories { get; set; } // Gets or sets the number of calories in the ingredients
        public string FoodGroup { get; set; } // Gets or sets the food group that the ingredient belongs to

        public override string ToString() // Returns a string format that represents the ingredient.
        {
            return $"{Quantity} {Unit} of {Name} ({Calories} calories, {FoodGroup})";
        }
    }


}
