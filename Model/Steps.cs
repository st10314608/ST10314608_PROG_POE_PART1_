using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10314608_PROG2A_POE_Part1.Model
{
    internal class Steps //Internal class Steps
    {
        public string Description { get; set; } //Property Description

        public Steps(string description) //Constructor
        {
            Description = description; //Initialize the description property
        }
    }
}
