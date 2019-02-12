using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FridgeClasses
{
	public class Compact : Refrigerator
	{
		// properties
        public int NumberOfShelves { get; set; }

        public Compact(string makeModel, double capacity, bool energyStarRated, int numberOfShelves)
            : base(makeModel, capacity, energyStarRated)
		{
            NumberOfShelves = numberOfShelves;
		}

		// Overriden ToString method
		public override string ToString()
		{
			// Return a string representation 
			// of a compact fridge.
            string result = base.ToString();
            result += "Compact with " + NumberOfShelves + " shelves";
			return result;
		}
	}

} //end of root namespace