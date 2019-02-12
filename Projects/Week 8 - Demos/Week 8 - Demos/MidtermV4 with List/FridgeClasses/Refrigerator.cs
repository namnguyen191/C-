using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FridgeClasses
{
    public class Refrigerator
    {
        // fields
        private string makeModel;
        public double Capacity { get; set; }
        public bool EnergyStarRated { get; set; }	

        //properties
        public string MakeModel
        {
            get { return makeModel; }
            set
            {
                if (value != null)
                {
                    makeModel = value;
                }
            }
        }      

        public Refrigerator(string makeModel, double capacity, bool energyStarRated)
        {
            MakeModel = makeModel;
            Capacity = capacity;
            EnergyStarRated = energyStarRated;
        }

        // Overriden ToString method
        public override string ToString()
        {
            // Return a string representation 
            // of a fridge.
            string result = "Refrigerator: " + MakeModel + Environment.NewLine;
            result += "Capacity: " + Capacity + Environment.NewLine;
            result += EnergyStarRated ? "Energy Star Rated\n" : "";
            return result;
        }
    }
} //end of root namespace